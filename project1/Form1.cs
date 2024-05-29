using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Npgsql;
using OfficeOpenXml;
using System.Windows.Forms.DataVisualization.Charting;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadClients();
        }

        private void btnGenerateReport1_Click(object sender, EventArgs e)
        {
            List<int> clientIds = chkAllClients.Checked ? null : cbClients.CheckedItems.Cast<DataRowView>().Select(item => (int)item["id"]).ToList();
            GenerateReport1(dtpFromDate.Value, dtpToDate.Value, clientIds);
        }

        private void btnGenerateReport2_Click(object sender, EventArgs e)
        {
            List<int> clientIds = chkAllClients.Checked ? null : cbClients.CheckedItems.Cast<DataRowView>().Select(item => (int)item["id"]).ToList();
            GenerateReport2(dtpFromDate.Value, dtpToDate.Value, clientIds);
        }

        private void btnExportReport1_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dgvReport1, "Report1.xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте отчёта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportReport2_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dgvReport2, "Report2.xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте отчёта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => LoadClients();
            form2.ShowDialog();
        }

        private void btnOpenForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void LoadClients()
        {
            try
            {
                string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT id, name FROM clients";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cbClients.DataSource = dt;
                            cbClients.DisplayMember = "name";
                            cbClients.ValueMember = "id";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке клиентов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateReport1(DateTime fromDate, DateTime toDate, List<int> clientIds)
        {
            try
            {
                string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = @"
                        SELECT p.name AS Товар, c.quantity AS Количество, c.total_amount AS Сумма
                        FROM contracts c
                        LEFT JOIN shipments s ON c.id = s.contract_id
                        JOIN products p ON c.product_id = p.id
                        JOIN clients cl ON c.client_id = cl.id
                        WHERE s.id IS NULL
                        AND c.created_at BETWEEN @fromDate AND @toDate";

                    if (clientIds != null && clientIds.Count > 0)
                    {
                        sql += " AND cl.id = ANY(@clientIds)";
                    }

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("fromDate", fromDate);
                        cmd.Parameters.AddWithValue("toDate", toDate);

                        if (clientIds != null && clientIds.Count > 0)
                        {
                            cmd.Parameters.AddWithValue("clientIds", clientIds);
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Нет данных для отображения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            dgvReport1.DataSource = dt;
                            UpdateChart(chartReport1, dt, "Товар", "Количество", SeriesChartType.Pie);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при генерации отчёта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateReport2(DateTime fromDate, DateTime toDate, List<int> clientIds)
        {
            try
            {
                string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = @"
                SELECT 
                    p.name AS Товар,
                    s.shipment_date AS Дата, 
                    SUM(c.total_amount - COALESCE(pmt.amount, 0)) AS Сумма_неоплаченная
                FROM 
                    shipments s
                JOIN 
                    contracts c ON s.contract_id = c.id
                LEFT JOIN 
                    (
                        SELECT contract_id, SUM(amount) AS amount
                        FROM payments
                        GROUP BY contract_id
                    ) pmt ON c.id = pmt.contract_id
                JOIN 
                    products p ON c.product_id = p.id
                JOIN 
                    clients cl ON c.client_id = cl.id
                WHERE 
                    s.shipment_date BETWEEN @fromDate AND @toDate";

                    if (clientIds != null && clientIds.Count > 0)
                    {
                        sql += " AND cl.id = ANY(@clientIds)";
                    }

                    sql += " GROUP BY s.shipment_date, p.name, cl.name HAVING SUM(c.total_amount - COALESCE(pmt.amount, 0)) > 0";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("fromDate", fromDate);
                        cmd.Parameters.AddWithValue("toDate", toDate);

                        if (clientIds != null && clientIds.Count > 0)
                        {
                            cmd.Parameters.AddWithValue("clientIds", clientIds);
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Нет данных для отображения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            dgvReport2.DataSource = dt;
                            UpdateChart(chartReport2, dt, "Товар", "Сумма_неоплаченная", SeriesChartType.Bar);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при генерации отчёта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcel(DataGridView dgv, string filePath)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var pck = new ExcelPackage())
                {
                    var ws = pck.Workbook.Worksheets.Add("Report");

                    // Динамические заголовки и подзаголовки
                    ws.Cells["A1"].Value = "Отчёт по данным";
                    ws.Cells["A2"].Value = $"Дата создания: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
                    ws.Cells["A3"].Value = $"Период: {dtpFromDate.Value.ToString("yyyy-MM-dd")} - {dtpToDate.Value.ToString("yyyy-MM-dd")}";
                    ws.Cells["A1:C1"].Merge = true;
                    ws.Cells["A2:C2"].Merge = true;
                    ws.Cells["A3:C3"].Merge = true;
                    ws.Cells["A1:C3"].Style.Font.Bold = true;
                    ws.Cells["A1:C3"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Контактная информация
                    ws.Cells["A4"].Value = "Контактная информация: info@example.com";
                    ws.Cells["A4:C4"].Merge = true;
                    ws.Cells["A4:C4"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Установка заголовков с фильтрами
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        var cell = ws.Cells[6, i + 1];
                        cell.Value = dgv.Columns[i].HeaderText;
                        cell.Style.Font.Bold = true;
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        cell.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                    }

                    // Заполнение данных
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            var cell = ws.Cells[i + 7, j + 1];
                            cell.Value = dgv.Rows[i].Cells[j].Value;
                            cell.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                            // Установка форматирования для числовых данных
                            if (dgv.Columns[j].ValueType == typeof(int) || dgv.Columns[j].ValueType == typeof(decimal))
                            {
                                cell.Style.Numberformat.Format = "#,##0";
                            }
                            else if (dgv.Columns[j].ValueType == typeof(DateTime))
                            {
                                cell.Style.Numberformat.Format = "yyyy-mm-dd";
                            }
                        }
                    }

                    // Добавление итогов
                    var totalRow = ws.Cells[dgv.Rows.Count + 7, 1, dgv.Rows.Count + 7, dgv.Columns.Count];
                    totalRow.Style.Font.Bold = true;
                    totalRow.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    totalRow.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Columns[j].ValueType == typeof(int) || dgv.Columns[j].ValueType == typeof(decimal))
                        {
                            ws.Cells[dgv.Rows.Count + 7, j + 1].Formula = $"SUM({ws.Cells[7, j + 1].Address}:{ws.Cells[dgv.Rows.Count + 6, j + 1].Address})";
                        }
                    }

                    // Включение фильтров
                    ws.Cells[6, 1, 6, dgv.Columns.Count].AutoFilter = true;

                    // Автоматическое подгонка ширины колонок
                    ws.Cells[ws.Dimension.Address].AutoFitColumns();

                    var condRange = ws.Cells[7, 1, dgv.Rows.Count + 6, dgv.Columns.Count];
                    var condition = condRange.ConditionalFormatting.AddThreeColorScale();
                    condition.LowValue.Color = System.Drawing.Color.White;
                    condition.MiddleValue.Color = System.Drawing.Color.LightYellow;
                    condition.HighValue.Color = System.Drawing.Color.LightGray;

                    // Добавление диаграммы
                    var chart = ws.Drawings.AddChart("Chart", OfficeOpenXml.Drawing.Chart.eChartType.ColumnClustered);
                    chart.SetPosition(7, 0, dgv.Columns.Count + 1, 0);
                    chart.SetSize(600, 300); // Уменьшенный размер диаграммы
                    chart.Series.Add(ws.Cells[7, 2, dgv.Rows.Count + 6, 2], ws.Cells[7, 1, dgv.Rows.Count + 6, 1]);
                    chart.Title.Text = "Данные по товарам";
                    chart.XAxis.Title.Text = "Товары";
                    chart.YAxis.Title.Text = "Количество";

                    // Сохранение файла
                    pck.SaveAs(new System.IO.FileInfo(filePath));
                }

                MessageBox.Show("Отчёт успешно экспортирован в Excel.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте отчёта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkAllClients_CheckedChanged(object sender, EventArgs e)
        {
            cbClients.Enabled = !chkAllClients.Checked;
        }

        private void UpdateChart(Chart chart, DataTable dataTable, string xValueMember, string yValueMember, SeriesChartType chartType)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.ChartAreas.Add(new ChartArea());

            Series series = new Series
            {
                ChartType = chartType,
                XValueMember = xValueMember,
                YValueMembers = yValueMember,
                IsValueShownAsLabel = true
            };

            chart.Series.Add(series);
            chart.DataSource = dataTable;
            chart.DataBind();

            if (chartType == SeriesChartType.Pie)
            {
                series.Label = "#PERCENT{P0}";
                series.LegendText = "#VALX"; 
            }
            else
            {
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "#,##0.00"; 
            }

            if (chartType == SeriesChartType.Bar || chartType == SeriesChartType.Column)
            {
                if (chart.Legends.Count > 0)
                {
                    chart.Legends[0].Enabled = false;
                }
            }
            else
            {
                if (chart.Legends.Count == 0)
                {
                    chart.Legends.Add(new Legend());
                }
                chart.Legends[0].Enabled = true;
            }
        }
    }
}
