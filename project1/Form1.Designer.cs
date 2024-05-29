namespace project1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.filterGroup = new System.Windows.Forms.GroupBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblClient = new System.Windows.Forms.Label();
            this.cbClients = new System.Windows.Forms.CheckedListBox();
            this.chkAllClients = new System.Windows.Forms.CheckBox();
            this.btnGenerateReport1 = new System.Windows.Forms.Button();
            this.btnGenerateReport2 = new System.Windows.Forms.Button();
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.btnOpenForm3 = new System.Windows.Forms.Button();
            this.dgvReport1 = new System.Windows.Forms.DataGridView();
            this.dgvReport2 = new System.Windows.Forms.DataGridView();
            this.btnExportReport1 = new System.Windows.Forms.Button();
            this.btnExportReport2 = new System.Windows.Forms.Button();
            this.chartReport1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartReport2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.filterGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport2)).BeginInit();
            this.SuspendLayout();
            // 
            // filterGroup
            // 
            this.filterGroup.Controls.Add(this.lblFromDate);
            this.filterGroup.Controls.Add(this.dtpFromDate);
            this.filterGroup.Controls.Add(this.lblToDate);
            this.filterGroup.Controls.Add(this.dtpToDate);
            this.filterGroup.Controls.Add(this.lblClient);
            this.filterGroup.Controls.Add(this.cbClients);
            this.filterGroup.Controls.Add(this.chkAllClients);
            this.filterGroup.Controls.Add(this.btnGenerateReport1);
            this.filterGroup.Controls.Add(this.btnGenerateReport2);
            this.filterGroup.Controls.Add(this.btnOpenForm2);
            this.filterGroup.Controls.Add(this.btnOpenForm3);
            this.filterGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterGroup.Location = new System.Drawing.Point(0, 0);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.Size = new System.Drawing.Size(773, 132);
            this.filterGroup.TabIndex = 1;
            this.filterGroup.TabStop = false;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(10, 20);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(20, 13);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "От";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(70, 15);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFromDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(276, 20);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(22, 13);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "До";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(304, 15);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpToDate.TabIndex = 3;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(10, 50);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 13);
            this.lblClient.TabIndex = 4;
            this.lblClient.Text = "Клиент";
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(70, 45);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(200, 34);
            this.cbClients.TabIndex = 5;
            // 
            // chkAllClients
            // 
            this.chkAllClients.AutoSize = true;
            this.chkAllClients.Location = new System.Drawing.Point(290, 47);
            this.chkAllClients.Name = "chkAllClients";
            this.chkAllClients.Size = new System.Drawing.Size(91, 17);
            this.chkAllClients.TabIndex = 6;
            this.chkAllClients.Text = "Все клиенты";
            this.chkAllClients.UseVisualStyleBackColor = true;
            this.chkAllClients.CheckedChanged += new System.EventHandler(this.chkAllClients_CheckedChanged);
            // 
            // btnGenerateReport1
            // 
            this.btnGenerateReport1.Location = new System.Drawing.Point(10, 91);
            this.btnGenerateReport1.Name = "btnGenerateReport1";
            this.btnGenerateReport1.Size = new System.Drawing.Size(280, 23);
            this.btnGenerateReport1.TabIndex = 7;
            this.btnGenerateReport1.Text = "Сформировать отчёт по товарам для отгрузки";
            this.btnGenerateReport1.UseVisualStyleBackColor = true;
            this.btnGenerateReport1.Click += new System.EventHandler(this.btnGenerateReport1_Click);
            // 
            // btnGenerateReport2
            // 
            this.btnGenerateReport2.Location = new System.Drawing.Point(296, 91);
            this.btnGenerateReport2.Name = "btnGenerateReport2";
            this.btnGenerateReport2.Size = new System.Drawing.Size(280, 23);
            this.btnGenerateReport2.TabIndex = 8;
            this.btnGenerateReport2.Text = "Сформировать отчёт по неоплаченным отгрузкам";
            this.btnGenerateReport2.UseVisualStyleBackColor = true;
            this.btnGenerateReport2.Click += new System.EventHandler(this.btnGenerateReport2_Click);
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Location = new System.Drawing.Point(582, 30);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(180, 39);
            this.btnOpenForm2.TabIndex = 9;
            this.btnOpenForm2.Text = "Открыть форму ввода данных";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // btnOpenForm3
            // 
            this.btnOpenForm3.Location = new System.Drawing.Point(582, 75);
            this.btnOpenForm3.Name = "btnOpenForm3";
            this.btnOpenForm3.Size = new System.Drawing.Size(180, 39);
            this.btnOpenForm3.TabIndex = 10;
            this.btnOpenForm3.Text = "Открыть форму изменения и удаления данных";
            this.btnOpenForm3.UseVisualStyleBackColor = true;
            this.btnOpenForm3.Click += new System.EventHandler(this.btnOpenForm3_Click);
            // 
            // dgvReport1
            // 
            this.dgvReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport1.Location = new System.Drawing.Point(0, 131);
            this.dgvReport1.Name = "dgvReport1";
            this.dgvReport1.Size = new System.Drawing.Size(391, 325);
            this.dgvReport1.TabIndex = 2;
            // 
            // dgvReport2
            // 
            this.dgvReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport2.Location = new System.Drawing.Point(0, 457);
            this.dgvReport2.Name = "dgvReport2";
            this.dgvReport2.Size = new System.Drawing.Size(391, 323);
            this.dgvReport2.TabIndex = 3;
            // 
            // btnExportReport1
            // 
            this.btnExportReport1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExportReport1.Location = new System.Drawing.Point(0, 803);
            this.btnExportReport1.Name = "btnExportReport1";
            this.btnExportReport1.Size = new System.Drawing.Size(773, 23);
            this.btnExportReport1.TabIndex = 4;
            this.btnExportReport1.Text = "Экспорт отчёта по товарам в Excel";
            this.btnExportReport1.UseVisualStyleBackColor = true;
            this.btnExportReport1.Click += new System.EventHandler(this.btnExportReport1_Click);
            // 
            // btnExportReport2
            // 
            this.btnExportReport2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExportReport2.Location = new System.Drawing.Point(0, 780);
            this.btnExportReport2.Name = "btnExportReport2";
            this.btnExportReport2.Size = new System.Drawing.Size(773, 23);
            this.btnExportReport2.TabIndex = 5;
            this.btnExportReport2.Text = "Экспорт отчёта по неоплаченным отгрузкам в Excel";
            this.btnExportReport2.UseVisualStyleBackColor = true;
            this.btnExportReport2.Click += new System.EventHandler(this.btnExportReport2_Click);
            // 
            // chartReport1
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReport1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReport1.Legends.Add(legend1);
            this.chartReport1.Location = new System.Drawing.Point(397, 131);
            this.chartReport1.Name = "chartReport1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartReport1.Series.Add(series1);
            this.chartReport1.Size = new System.Drawing.Size(376, 325);
            this.chartReport1.TabIndex = 6;
            this.chartReport1.Text = "chart1";
            // 
            // chartReport2
            // 
            chartArea2.Name = "ChartArea1";
            this.chartReport2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartReport2.Legends.Add(legend2);
            this.chartReport2.Location = new System.Drawing.Point(397, 457);
            this.chartReport2.Name = "chartReport2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartReport2.Series.Add(series2);
            this.chartReport2.Size = new System.Drawing.Size(376, 323);
            this.chartReport2.TabIndex = 7;
            this.chartReport2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 826);
            this.Controls.Add(this.chartReport2);
            this.Controls.Add(this.chartReport1);
            this.Controls.Add(this.btnExportReport2);
            this.Controls.Add(this.btnExportReport1);
            this.Controls.Add(this.dgvReport2);
            this.Controls.Add(this.dgvReport1);
            this.Controls.Add(this.filterGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Отчеты / Вариант 14";
            this.filterGroup.ResumeLayout(false);
            this.filterGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport2)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.GroupBox filterGroup;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.CheckedListBox cbClients;
        private System.Windows.Forms.CheckBox chkAllClients;
        private System.Windows.Forms.Button btnGenerateReport1;
        private System.Windows.Forms.Button btnGenerateReport2;
        private System.Windows.Forms.DataGridView dgvReport1;
        private System.Windows.Forms.DataGridView dgvReport2;
        private System.Windows.Forms.Button btnExportReport1;
        private System.Windows.Forms.Button btnExportReport2;
        private System.Windows.Forms.Button btnOpenForm3;
        private System.Windows.Forms.Button btnOpenForm2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport2;
    }
}
