using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                LoadClients();
                LoadContractIds();
                LoadProductNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClients()
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
                        var dt = new DataTable();
                        dt.Load(reader);
                        cbClientNameContract.DataSource = dt;
                        cbClientNameContract.DisplayMember = "name";
                        cbClientNameContract.ValueMember = "id";
                    }
                }
            }
        }

        private void LoadContractIds()
        {
            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT id FROM contracts";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbContractIdPayment.Items.Add(reader.GetInt32(0));
                            cbContractIdShipment.Items.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
        }

        private void LoadProductNames()
        {
            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT name FROM products";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        cbProductName.DataSource = dt;
                        cbProductName.DisplayMember = "name";
                    }
                }
            }
        }

        private bool ValidateClientData()
        {
            if (string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                MessageBox.Show("Имя клиента не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidateContractData()
        {
            if (cbClientNameContract.SelectedItem == null)
            {
                MessageBox.Show("Выберите клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbProductName.SelectedItem == null)
            {
                MessageBox.Show("Выберите название товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numQuantity.Value <= 0)
            {
                MessageBox.Show("Количество товара должно быть больше нуля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numPrepayment.Value < 0)
            {
                MessageBox.Show("Предоплата не может быть отрицательной.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numTotalAmount.Value <= 0)
            {
                MessageBox.Show("Общая сумма должна быть больше нуля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidatePaymentData()
        {
            if (cbContractIdPayment.SelectedItem == null)
            {
                MessageBox.Show("Выберите ID договора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numAmountPayment.Value <= 0)
            {
                MessageBox.Show("Сумма оплаты должна быть больше нуля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidateShipmentData()
        {
            if (cbContractIdShipment.SelectedItem == null)
            {
                MessageBox.Show("Выберите ID договора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numQuantityShipment.Value <= 0)
            {
                MessageBox.Show("Количество отгружаемого товара должно быть больше нуля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            if (ValidateClientData())
            {
                try
                {
                    string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
                    using (var conn = new NpgsqlConnection(connString))
                    {
                        conn.Open();
                        string sql = "INSERT INTO clients (name) VALUES (@clientName)";
                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("clientName", txtClientName.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Клиент успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveContract_Click(object sender, EventArgs e)
        {
            if (ValidateContractData())
            {
                try
                {
                    string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
                    using (var conn = new NpgsqlConnection(connString))
                    {
                        conn.Open();
                        string sql = @"
                            INSERT INTO contracts (client_id, product_id, quantity, prepayment, total_amount, created_at)
                            VALUES (
                                @clientId,
                                (SELECT id FROM products WHERE name = @productName),
                                @quantity, @prepayment, @totalAmount, NOW())";

                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("clientId", cbClientNameContract.SelectedValue);
                            cmd.Parameters.AddWithValue("productName", cbProductName.Text);
                            cmd.Parameters.AddWithValue("quantity", numQuantity.Value);
                            cmd.Parameters.AddWithValue("prepayment", numPrepayment.Value);
                            cmd.Parameters.AddWithValue("totalAmount", numTotalAmount.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Договор успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении договора: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "INSERT INTO products (name, price) VALUES (@productName, @price)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("productName", txtProductNameAdd.Text);
                        cmd.Parameters.AddWithValue("price", numProductPrice.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Товар успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении товара: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            if (ValidatePaymentData())
            {
                try
                {
                    string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
                    using (var conn = new NpgsqlConnection(connString))
                    {
                        conn.Open();
                        string sql = @"
                            INSERT INTO payments (contract_id, amount, payment_date, payment_type)
                            VALUES (
                                @contractId,
                                @amount, NOW(), @paymentType)";

                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("contractId", cbContractIdPayment.SelectedItem);
                            cmd.Parameters.AddWithValue("amount", numAmountPayment.Value);
                            cmd.Parameters.AddWithValue("paymentType", cbPaymentType.SelectedItem.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Оплата успешно сохранена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении оплаты: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveShipment_Click(object sender, EventArgs e)
        {
            if (ValidateShipmentData())
            {
                try
                {
                    string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
                    using (var conn = new NpgsqlConnection(connString))
                    {
                        conn.Open();
                        string sql = @"
                            INSERT INTO shipments (contract_id, quantity, shipment_date)
                            VALUES (
                                @contractId,
                                @quantity, NOW())";

                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("contractId", cbContractIdShipment.SelectedItem);
                            cmd.Parameters.AddWithValue("quantity", numQuantityShipment.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Отгрузка успешно сохранена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении отгрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
