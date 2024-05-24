using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace project1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadClientRecords();
            LoadContractRecords();
            LoadProductRecords();
            LoadPaymentRecords();
            LoadShipmentRecords();

            cbSelectRecordClients.SelectedIndexChanged += cbSelectRecordClients_SelectedIndexChanged;
            cbSelectRecordContracts.SelectedIndexChanged += cbSelectRecordContracts_SelectedIndexChanged;
            cbSelectRecordProducts.SelectedIndexChanged += cbSelectRecordProducts_SelectedIndexChanged;
            cbSelectRecordPayments.SelectedIndexChanged += cbSelectRecordPayments_SelectedIndexChanged;
            cbSelectRecordShipments.SelectedIndexChanged += cbSelectRecordShipments_SelectedIndexChanged;
        }

        private void LoadClientRecords()
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
                            var dt = new DataTable();
                            dt.Load(reader);
                            cbSelectRecordClients.DataSource = dt;
                            cbSelectRecordClients.DisplayMember = "name";
                            cbSelectRecordClients.ValueMember = "id";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadContractRecords()
        {
            try
            {
                string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT id, client_id, product_id, quantity, prepayment, total_amount FROM contracts";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new DataTable();
                            dt.Load(reader);
                            cbSelectRecordContracts.DataSource = dt;
                            cbSelectRecordContracts.DisplayMember = "id";
                            cbSelectRecordContracts.ValueMember = "id";
                        }
                    }

                    sql = "SELECT id, name FROM clients";
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

                    sql = "SELECT id, name FROM products";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new DataTable();
                            dt.Load(reader);
                            cbProductNameContract.DataSource = dt;
                            cbProductNameContract.DisplayMember = "name";
                            cbProductNameContract.ValueMember = "id";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductRecords()
        {
            try
            {
                string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT id, name, price FROM products";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new DataTable();
                            dt.Load(reader);
                            cbSelectRecordProducts.DataSource = dt;
                            cbSelectRecordProducts.DisplayMember = "name";
                            cbSelectRecordProducts.ValueMember = "id";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPaymentRecords()
        {
            try
            {
                string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT id, contract_id, amount, payment_type FROM payments";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new DataTable();
                            dt.Load(reader);
                            cbSelectRecordPayments.DataSource = dt;
                            cbSelectRecordPayments.DisplayMember = "id";
                            cbSelectRecordPayments.ValueMember = "id";
                        }
                    }

                    sql = "SELECT id FROM contracts";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new DataTable();
                            dt.Load(reader);
                            cbContractIdPayment.DataSource = dt;
                            cbContractIdPayment.DisplayMember = "id";
                            cbContractIdPayment.ValueMember = "id";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadShipmentRecords()
        {
            try
            {
                string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT id, contract_id, quantity FROM shipments";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new DataTable();
                            dt.Load(reader);
                            cbSelectRecordShipments.DataSource = dt;
                            cbSelectRecordShipments.DisplayMember = "id";
                            cbSelectRecordShipments.ValueMember = "id";
                        }
                    }

                    sql = "SELECT id FROM contracts";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new DataTable();
                            dt.Load(reader);
                            cbContractIdShipment.DataSource = dt;
                            cbContractIdShipment.DisplayMember = "id";
                            cbContractIdShipment.ValueMember = "id";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSelectRecordClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectRecordClients.SelectedValue != null)
            {
                LoadClientRecord();
            }
        }

        private void cbSelectRecordContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectRecordContracts.SelectedValue != null)
            {
                LoadContractRecord();
            }
        }

        private void cbSelectRecordProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectRecordProducts.SelectedValue != null)
            {
                LoadProductRecord();
            }
        }

        private void cbSelectRecordPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectRecordPayments.SelectedValue != null)
            {
                LoadPaymentRecord();
            }
        }

        private void cbSelectRecordShipments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectRecordShipments.SelectedValue != null)
            {
                LoadShipmentRecord();
            }
        }

        private void LoadClientRecord()
        {
            int clientId = (int)cbSelectRecordClients.SelectedValue;
            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT name FROM clients WHERE id = @clientId";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("clientId", clientId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtClientName.Text = reader.GetString(0);
                        }
                    }
                }
            }
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            int clientId = (int)cbSelectRecordClients.SelectedValue;
            string clientName = txtClientName.Text;

            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "UPDATE clients SET name = @clientName WHERE id = @clientId";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("clientName", clientName);
                    cmd.Parameters.AddWithValue("clientId", clientId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Запись обновлена успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadClientRecords();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            int clientId = (int)cbSelectRecordClients.SelectedValue;

            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "DELETE FROM clients WHERE id = @clientId";
                try
                {
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("clientId", clientId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Запись удалена успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Npgsql.PostgresException ex) when (ex.SqlState == "23503")
                {
                    MessageBox.Show("Не удалось удалить запись, так как она используется в других таблицах. Сначала удалите связанные записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadClientRecords();
        }

        private void LoadContractRecord()
        {
            int contractId = (int)cbSelectRecordContracts.SelectedValue;
            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT client_id, product_id, quantity, prepayment, total_amount FROM contracts WHERE id = @contractId";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("contractId", contractId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cbClientNameContract.SelectedValue = reader.GetInt32(0);
                            cbProductNameContract.SelectedValue = reader.GetInt32(1);
                            numQuantity.Value = reader.GetInt32(2);

                            // Установить максимальные значения для NumericUpDown элементов
                            numPrepayment.Maximum = Decimal.MaxValue;
                            numTotalAmount.Maximum = Decimal.MaxValue;

                            numPrepayment.Value = reader.GetDecimal(3);
                            numTotalAmount.Value = reader.GetDecimal(4);
                        }
                    }
                }
            }
        }

        private void btnSaveContract_Click(object sender, EventArgs e)
        {
            int contractId = (int)cbSelectRecordContracts.SelectedValue;
            int clientId = (int)cbClientNameContract.SelectedValue;
            int productId = (int)cbProductNameContract.SelectedValue;
            int quantity = (int)numQuantity.Value;
            decimal prepayment = numPrepayment.Value;
            decimal totalAmount = numTotalAmount.Value;

            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = @"
                    UPDATE contracts
                    SET client_id = @clientId,
                        product_id = @productId,
                        quantity = @quantity,
                        prepayment = @prepayment,
                        total_amount = @totalAmount
                    WHERE id = @contractId";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("clientId", clientId);
                    cmd.Parameters.AddWithValue("productId", productId);
                    cmd.Parameters.AddWithValue("quantity", quantity);
                    cmd.Parameters.AddWithValue("prepayment", prepayment);
                    cmd.Parameters.AddWithValue("totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("contractId", contractId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Запись обновлена успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadContractRecords();
        }

        private void btnDeleteContract_Click(object sender, EventArgs e)
        {
            int contractId = (int)cbSelectRecordContracts.SelectedValue;

            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "DELETE FROM contracts WHERE id = @contractId";
                try
                {
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("contractId", contractId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Запись удалена успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Npgsql.PostgresException ex) when (ex.SqlState == "23503")
                {
                    MessageBox.Show("Не удалось удалить запись, так как она используется в других таблицах. Сначала удалите связанные записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadContractRecords();
        }

        private void LoadProductRecord()
        {
            int productId = (int)cbSelectRecordProducts.SelectedValue;
            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT name, price FROM products WHERE id = @productId";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("productId", productId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtProductName.Text = reader.GetString(0);
                            numProductPrice.Maximum = Decimal.MaxValue; // Установить максимальные значения для NumericUpDown элементов
                            numProductPrice.Value = reader.GetDecimal(1);
                        }
                    }
                }
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            int productId = (int)cbSelectRecordProducts.SelectedValue;
            string productName = txtProductName.Text;
            decimal productPrice = numProductPrice.Value;

            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "UPDATE products SET name = @productName, price = @productPrice WHERE id = @productId";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("productName", productName);
                    cmd.Parameters.AddWithValue("productPrice", productPrice);
                    cmd.Parameters.AddWithValue("productId", productId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Запись обновлена успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProductRecords();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int productId = (int)cbSelectRecordProducts.SelectedValue;

            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "DELETE FROM products WHERE id = @productId";
                try
                {
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("productId", productId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Запись удалена успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Npgsql.PostgresException ex) when (ex.SqlState == "23503")
                {
                    MessageBox.Show("Не удалось удалить запись, так как она используется в других таблицах. Сначала удалите связанные записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadProductRecords();
        }

        private void LoadPaymentRecord()
        {
            int paymentId = (int)cbSelectRecordPayments.SelectedValue;
            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT contract_id, amount, payment_type FROM payments WHERE id = @paymentId";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("paymentId", paymentId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cbContractIdPayment.SelectedValue = reader.GetInt32(0);

                            numAmountPayment.Maximum = Decimal.MaxValue;

                            numAmountPayment.Value = reader.GetDecimal(1);
                            cbPaymentType.SelectedItem = reader.GetString(2);
                        }
                    }
                }
            }
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            int paymentId = (int)cbSelectRecordPayments.SelectedValue;
            int contractId = (int)cbContractIdPayment.SelectedValue;
            decimal amount = numAmountPayment.Value;
            string paymentType = cbPaymentType.SelectedItem.ToString();

            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = @"
                    UPDATE payments
                    SET contract_id = @contractId,
                        amount = @amount,
                        payment_type = @paymentType
                    WHERE id = @paymentId";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("contractId", contractId);
                    cmd.Parameters.AddWithValue("amount", amount);
                    cmd.Parameters.AddWithValue("paymentType", paymentType);
                    cmd.Parameters.AddWithValue("paymentId", paymentId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Запись обновлена успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPaymentRecords();
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            int paymentId = (int)cbSelectRecordPayments.SelectedValue;

            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "DELETE FROM payments WHERE id = @paymentId";
                try
                {
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("paymentId", paymentId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Запись удалена успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Npgsql.PostgresException ex) when (ex.SqlState == "23503")
                {
                    MessageBox.Show("Не удалось удалить запись, так как она используется в других таблицах. Сначала удалите связанные записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadPaymentRecords();
        }

        private void LoadShipmentRecord()
        {
            int shipmentId = (int)cbSelectRecordShipments.SelectedValue;
            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT contract_id, quantity FROM shipments WHERE id = @shipmentId";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("shipmentId", shipmentId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cbContractIdShipment.SelectedValue = reader.GetInt32(0);
                            numQuantityShipment.Value = reader.GetInt32(1);
                        }
                    }
                }
            }
        }

        private void btnSaveShipment_Click(object sender, EventArgs e)
        {
            int shipmentId = (int)cbSelectRecordShipments.SelectedValue;
            int contractId = (int)cbContractIdShipment.SelectedValue;
            int quantity = (int)numQuantityShipment.Value;

            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = @"
                    UPDATE shipments
                    SET contract_id = @contractId,
                        quantity = @quantity
                    WHERE id = @shipmentId";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("contractId", contractId);
                    cmd.Parameters.AddWithValue("quantity", quantity);
                    cmd.Parameters.AddWithValue("shipmentId", shipmentId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Запись обновлена успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadShipmentRecords();
        }

        private void btnDeleteShipment_Click(object sender, EventArgs e)
        {
            int shipmentId = (int)cbSelectRecordShipments.SelectedValue;

            string connString = "Host=127.0.0.1;Username=postgres;Password=123;Database=project";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "DELETE FROM shipments WHERE id = @shipmentId";
                try
                {
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("shipmentId", shipmentId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Запись удалена успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Npgsql.PostgresException ex) when (ex.SqlState == "23503")
                {
                    MessageBox.Show("Не удалось удалить запись, так как она используется в других таблицах. Сначала удалите связанные записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadShipmentRecords();
        }
    }
}
