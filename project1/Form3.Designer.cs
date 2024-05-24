namespace project1
{
    partial class Form3
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

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.cbSelectRecordClients = new System.Windows.Forms.ComboBox();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.tabContracts = new System.Windows.Forms.TabPage();
            this.lblClientNameContract = new System.Windows.Forms.Label();
            this.cbClientNameContract = new System.Windows.Forms.ComboBox();
            this.lblProductNameContract = new System.Windows.Forms.Label();
            this.cbProductNameContract = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPrepayment = new System.Windows.Forms.Label();
            this.numPrepayment = new System.Windows.Forms.NumericUpDown();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.numTotalAmount = new System.Windows.Forms.NumericUpDown();
            this.cbSelectRecordContracts = new System.Windows.Forms.ComboBox();
            this.btnSaveContract = new System.Windows.Forms.Button();
            this.btnDeleteContract = new System.Windows.Forms.Button();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.numProductPrice = new System.Windows.Forms.NumericUpDown();
            this.cbSelectRecordProducts = new System.Windows.Forms.ComboBox();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.tabPayments = new System.Windows.Forms.TabPage();
            this.lblContractIdPayment = new System.Windows.Forms.Label();
            this.cbContractIdPayment = new System.Windows.Forms.ComboBox();
            this.lblAmountPayment = new System.Windows.Forms.Label();
            this.numAmountPayment = new System.Windows.Forms.NumericUpDown();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.cbSelectRecordPayments = new System.Windows.Forms.ComboBox();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.tabShipments = new System.Windows.Forms.TabPage();
            this.lblContractIdShipment = new System.Windows.Forms.Label();
            this.cbContractIdShipment = new System.Windows.Forms.ComboBox();
            this.lblQuantityShipment = new System.Windows.Forms.Label();
            this.numQuantityShipment = new System.Windows.Forms.NumericUpDown();
            this.cbSelectRecordShipments = new System.Windows.Forms.ComboBox();
            this.btnSaveShipment = new System.Windows.Forms.Button();
            this.btnDeleteShipment = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabClients.SuspendLayout();
            this.tabContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalAmount)).BeginInit();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).BeginInit();
            this.tabPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountPayment)).BeginInit();
            this.tabShipments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityShipment)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabClients);
            this.tabControl.Controls.Add(this.tabContracts);
            this.tabControl.Controls.Add(this.tabProducts);
            this.tabControl.Controls.Add(this.tabPayments);
            this.tabControl.Controls.Add(this.tabShipments);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(320, 300);
            this.tabControl.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.lblClientName);
            this.tabClients.Controls.Add(this.txtClientName);
            this.tabClients.Controls.Add(this.cbSelectRecordClients);
            this.tabClients.Controls.Add(this.btnSaveClient);
            this.tabClients.Controls.Add(this.btnDeleteClient);
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(312, 274);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Клиенты";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(10, 47);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(73, 13);
            this.lblClientName.TabIndex = 7;
            this.lblClientName.Text = "Имя клиента";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(100, 44);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(200, 20);
            this.txtClientName.TabIndex = 8;
            // 
            // cbSelectRecordClients
            // 
            this.cbSelectRecordClients.FormattingEnabled = true;
            this.cbSelectRecordClients.Location = new System.Drawing.Point(10, 17);
            this.cbSelectRecordClients.Name = "cbSelectRecordClients";
            this.cbSelectRecordClients.Size = new System.Drawing.Size(290, 21);
            this.cbSelectRecordClients.TabIndex = 0;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveClient.Location = new System.Drawing.Point(10, 243);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(144, 23);
            this.btnSaveClient.TabIndex = 2;
            this.btnSaveClient.Text = "Сохранить";
            this.btnSaveClient.UseVisualStyleBackColor = false;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteClient.Location = new System.Drawing.Point(156, 243);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(144, 23);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Удалить";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // tabContracts
            // 
            this.tabContracts.Controls.Add(this.lblClientNameContract);
            this.tabContracts.Controls.Add(this.cbClientNameContract);
            this.tabContracts.Controls.Add(this.lblProductNameContract);
            this.tabContracts.Controls.Add(this.cbProductNameContract);
            this.tabContracts.Controls.Add(this.lblQuantity);
            this.tabContracts.Controls.Add(this.numQuantity);
            this.tabContracts.Controls.Add(this.lblPrepayment);
            this.tabContracts.Controls.Add(this.numPrepayment);
            this.tabContracts.Controls.Add(this.lblTotalAmount);
            this.tabContracts.Controls.Add(this.numTotalAmount);
            this.tabContracts.Controls.Add(this.cbSelectRecordContracts);
            this.tabContracts.Controls.Add(this.btnSaveContract);
            this.tabContracts.Controls.Add(this.btnDeleteContract);
            this.tabContracts.Location = new System.Drawing.Point(4, 22);
            this.tabContracts.Name = "tabContracts";
            this.tabContracts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContracts.Size = new System.Drawing.Size(312, 274);
            this.tabContracts.TabIndex = 1;
            this.tabContracts.Text = "Договоры";
            this.tabContracts.UseVisualStyleBackColor = true;
            // 
            // lblClientNameContract
            // 
            this.lblClientNameContract.AutoSize = true;
            this.lblClientNameContract.Location = new System.Drawing.Point(10, 47);
            this.lblClientNameContract.Name = "lblClientNameContract";
            this.lblClientNameContract.Size = new System.Drawing.Size(73, 13);
            this.lblClientNameContract.TabIndex = 9;
            this.lblClientNameContract.Text = "Имя клиента";
            // 
            // cbClientNameContract
            // 
            this.cbClientNameContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientNameContract.FormattingEnabled = true;
            this.cbClientNameContract.Location = new System.Drawing.Point(100, 44);
            this.cbClientNameContract.Name = "cbClientNameContract";
            this.cbClientNameContract.Size = new System.Drawing.Size(200, 21);
            this.cbClientNameContract.TabIndex = 10;
            // 
            // lblProductNameContract
            // 
            this.lblProductNameContract.AutoSize = true;
            this.lblProductNameContract.Location = new System.Drawing.Point(10, 77);
            this.lblProductNameContract.Name = "lblProductNameContract";
            this.lblProductNameContract.Size = new System.Drawing.Size(95, 13);
            this.lblProductNameContract.TabIndex = 11;
            this.lblProductNameContract.Text = "Название товара";
            // 
            // cbProductNameContract
            // 
            this.cbProductNameContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductNameContract.FormattingEnabled = true;
            this.cbProductNameContract.Location = new System.Drawing.Point(100, 74);
            this.cbProductNameContract.Name = "cbProductNameContract";
            this.cbProductNameContract.Size = new System.Drawing.Size(200, 21);
            this.cbProductNameContract.TabIndex = 12;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(10, 107);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(66, 13);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Количество";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(100, 105);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(200, 20);
            this.numQuantity.TabIndex = 14;
            // 
            // lblPrepayment
            // 
            this.lblPrepayment.AutoSize = true;
            this.lblPrepayment.Location = new System.Drawing.Point(10, 137);
            this.lblPrepayment.Name = "lblPrepayment";
            this.lblPrepayment.Size = new System.Drawing.Size(68, 13);
            this.lblPrepayment.TabIndex = 15;
            this.lblPrepayment.Text = "Предоплата";
            // 
            // numPrepayment
            // 
            this.numPrepayment.Location = new System.Drawing.Point(100, 135);
            this.numPrepayment.Name = "numPrepayment";
            this.numPrepayment.Size = new System.Drawing.Size(200, 20);
            this.numPrepayment.TabIndex = 16;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(10, 167);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(78, 13);
            this.lblTotalAmount.TabIndex = 17;
            this.lblTotalAmount.Text = "Общая сумма";
            // 
            // numTotalAmount
            // 
            this.numTotalAmount.Location = new System.Drawing.Point(100, 165);
            this.numTotalAmount.Name = "numTotalAmount";
            this.numTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.numTotalAmount.TabIndex = 18;
            // 
            // cbSelectRecordContracts
            // 
            this.cbSelectRecordContracts.FormattingEnabled = true;
            this.cbSelectRecordContracts.Location = new System.Drawing.Point(10, 17);
            this.cbSelectRecordContracts.Name = "cbSelectRecordContracts";
            this.cbSelectRecordContracts.Size = new System.Drawing.Size(290, 21);
            this.cbSelectRecordContracts.TabIndex = 0;
            // 
            // btnSaveContract
            // 
            this.btnSaveContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveContract.Location = new System.Drawing.Point(10, 243);
            this.btnSaveContract.Name = "btnSaveContract";
            this.btnSaveContract.Size = new System.Drawing.Size(144, 23);
            this.btnSaveContract.TabIndex = 2;
            this.btnSaveContract.Text = "Сохранить";
            this.btnSaveContract.UseVisualStyleBackColor = false;
            this.btnSaveContract.Click += new System.EventHandler(this.btnSaveContract_Click);
            // 
            // btnDeleteContract
            // 
            this.btnDeleteContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteContract.Location = new System.Drawing.Point(156, 243);
            this.btnDeleteContract.Name = "btnDeleteContract";
            this.btnDeleteContract.Size = new System.Drawing.Size(144, 23);
            this.btnDeleteContract.TabIndex = 3;
            this.btnDeleteContract.Text = "Удалить";
            this.btnDeleteContract.UseVisualStyleBackColor = false;
            this.btnDeleteContract.Click += new System.EventHandler(this.btnDeleteContract_Click);
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.lblProductName);
            this.tabProducts.Controls.Add(this.txtProductName);
            this.tabProducts.Controls.Add(this.lblProductPrice);
            this.tabProducts.Controls.Add(this.numProductPrice);
            this.tabProducts.Controls.Add(this.cbSelectRecordProducts);
            this.tabProducts.Controls.Add(this.btnSaveProduct);
            this.tabProducts.Controls.Add(this.btnDeleteProduct);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(312, 274);
            this.tabProducts.TabIndex = 2;
            this.tabProducts.Text = "Товары";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(10, 47);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(95, 13);
            this.lblProductName.TabIndex = 19;
            this.lblProductName.Text = "Название товара";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(100, 44);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 20;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(10, 77);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(33, 13);
            this.lblProductPrice.TabIndex = 21;
            this.lblProductPrice.Text = "Цена";
            // 
            // numProductPrice
            // 
            this.numProductPrice.Location = new System.Drawing.Point(100, 74);
            this.numProductPrice.Name = "numProductPrice";
            this.numProductPrice.Size = new System.Drawing.Size(200, 20);
            this.numProductPrice.TabIndex = 22;
            // 
            // cbSelectRecordProducts
            // 
            this.cbSelectRecordProducts.FormattingEnabled = true;
            this.cbSelectRecordProducts.Location = new System.Drawing.Point(10, 17);
            this.cbSelectRecordProducts.Name = "cbSelectRecordProducts";
            this.cbSelectRecordProducts.Size = new System.Drawing.Size(290, 21);
            this.cbSelectRecordProducts.TabIndex = 0;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveProduct.Location = new System.Drawing.Point(10, 243);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(144, 23);
            this.btnSaveProduct.TabIndex = 2;
            this.btnSaveProduct.Text = "Сохранить";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteProduct.Location = new System.Drawing.Point(156, 243);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(144, 23);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Удалить";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // tabPayments
            // 
            this.tabPayments.Controls.Add(this.lblContractIdPayment);
            this.tabPayments.Controls.Add(this.cbContractIdPayment);
            this.tabPayments.Controls.Add(this.lblAmountPayment);
            this.tabPayments.Controls.Add(this.numAmountPayment);
            this.tabPayments.Controls.Add(this.cbPaymentType);
            this.tabPayments.Controls.Add(this.lblPaymentType);
            this.tabPayments.Controls.Add(this.cbSelectRecordPayments);
            this.tabPayments.Controls.Add(this.btnSavePayment);
            this.tabPayments.Controls.Add(this.btnDeletePayment);
            this.tabPayments.Location = new System.Drawing.Point(4, 22);
            this.tabPayments.Name = "tabPayments";
            this.tabPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayments.Size = new System.Drawing.Size(312, 274);
            this.tabPayments.TabIndex = 3;
            this.tabPayments.Text = "Оплаты";
            this.tabPayments.UseVisualStyleBackColor = true;
            // 
            // lblContractIdPayment
            // 
            this.lblContractIdPayment.AutoSize = true;
            this.lblContractIdPayment.Location = new System.Drawing.Point(10, 47);
            this.lblContractIdPayment.Name = "lblContractIdPayment";
            this.lblContractIdPayment.Size = new System.Drawing.Size(68, 13);
            this.lblContractIdPayment.TabIndex = 23;
            this.lblContractIdPayment.Text = "ID договора";
            // 
            // cbContractIdPayment
            // 
            this.cbContractIdPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContractIdPayment.FormattingEnabled = true;
            this.cbContractIdPayment.Location = new System.Drawing.Point(100, 44);
            this.cbContractIdPayment.Name = "cbContractIdPayment";
            this.cbContractIdPayment.Size = new System.Drawing.Size(200, 21);
            this.cbContractIdPayment.TabIndex = 24;
            // 
            // lblAmountPayment
            // 
            this.lblAmountPayment.AutoSize = true;
            this.lblAmountPayment.Location = new System.Drawing.Point(10, 77);
            this.lblAmountPayment.Name = "lblAmountPayment";
            this.lblAmountPayment.Size = new System.Drawing.Size(41, 13);
            this.lblAmountPayment.TabIndex = 25;
            this.lblAmountPayment.Text = "Сумма";
            // 
            // numAmountPayment
            // 
            this.numAmountPayment.Location = new System.Drawing.Point(100, 74);
            this.numAmountPayment.Name = "numAmountPayment";
            this.numAmountPayment.Size = new System.Drawing.Size(200, 20);
            this.numAmountPayment.TabIndex = 26;
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Items.AddRange(new object[] {
            "cash",
            "transfer"});
            this.cbPaymentType.Location = new System.Drawing.Point(100, 104);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(200, 21);
            this.cbPaymentType.TabIndex = 28;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(10, 107);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(66, 13);
            this.lblPaymentType.TabIndex = 27;
            this.lblPaymentType.Text = "Тип оплаты";
            // 
            // cbSelectRecordPayments
            // 
            this.cbSelectRecordPayments.FormattingEnabled = true;
            this.cbSelectRecordPayments.Location = new System.Drawing.Point(10, 17);
            this.cbSelectRecordPayments.Name = "cbSelectRecordPayments";
            this.cbSelectRecordPayments.Size = new System.Drawing.Size(290, 21);
            this.cbSelectRecordPayments.TabIndex = 0;
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSavePayment.Location = new System.Drawing.Point(10, 243);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(144, 23);
            this.btnSavePayment.TabIndex = 2;
            this.btnSavePayment.Text = "Сохранить";
            this.btnSavePayment.UseVisualStyleBackColor = false;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeletePayment.Location = new System.Drawing.Point(156, 243);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(144, 23);
            this.btnDeletePayment.TabIndex = 3;
            this.btnDeletePayment.Text = "Удалить";
            this.btnDeletePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletePayment.UseVisualStyleBackColor = false;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // tabShipments
            // 
            this.tabShipments.Controls.Add(this.lblContractIdShipment);
            this.tabShipments.Controls.Add(this.cbContractIdShipment);
            this.tabShipments.Controls.Add(this.lblQuantityShipment);
            this.tabShipments.Controls.Add(this.numQuantityShipment);
            this.tabShipments.Controls.Add(this.cbSelectRecordShipments);
            this.tabShipments.Controls.Add(this.btnSaveShipment);
            this.tabShipments.Controls.Add(this.btnDeleteShipment);
            this.tabShipments.Location = new System.Drawing.Point(4, 22);
            this.tabShipments.Name = "tabShipments";
            this.tabShipments.Padding = new System.Windows.Forms.Padding(3);
            this.tabShipments.Size = new System.Drawing.Size(312, 274);
            this.tabShipments.TabIndex = 4;
            this.tabShipments.Text = "Отгрузки";
            this.tabShipments.UseVisualStyleBackColor = true;
            // 
            // lblContractIdShipment
            // 
            this.lblContractIdShipment.AutoSize = true;
            this.lblContractIdShipment.Location = new System.Drawing.Point(10, 47);
            this.lblContractIdShipment.Name = "lblContractIdShipment";
            this.lblContractIdShipment.Size = new System.Drawing.Size(68, 13);
            this.lblContractIdShipment.TabIndex = 29;
            this.lblContractIdShipment.Text = "ID договора";
            // 
            // cbContractIdShipment
            // 
            this.cbContractIdShipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContractIdShipment.FormattingEnabled = true;
            this.cbContractIdShipment.Location = new System.Drawing.Point(100, 44);
            this.cbContractIdShipment.Name = "cbContractIdShipment";
            this.cbContractIdShipment.Size = new System.Drawing.Size(200, 21);
            this.cbContractIdShipment.TabIndex = 30;
            // 
            // lblQuantityShipment
            // 
            this.lblQuantityShipment.AutoSize = true;
            this.lblQuantityShipment.Location = new System.Drawing.Point(10, 77);
            this.lblQuantityShipment.Name = "lblQuantityShipment";
            this.lblQuantityShipment.Size = new System.Drawing.Size(66, 13);
            this.lblQuantityShipment.TabIndex = 31;
            this.lblQuantityShipment.Text = "Количество";
            // 
            // numQuantityShipment
            // 
            this.numQuantityShipment.Location = new System.Drawing.Point(100, 74);
            this.numQuantityShipment.Name = "numQuantityShipment";
            this.numQuantityShipment.Size = new System.Drawing.Size(200, 20);
            this.numQuantityShipment.TabIndex = 32;
            // 
            // cbSelectRecordShipments
            // 
            this.cbSelectRecordShipments.FormattingEnabled = true;
            this.cbSelectRecordShipments.Location = new System.Drawing.Point(10, 17);
            this.cbSelectRecordShipments.Name = "cbSelectRecordShipments";
            this.cbSelectRecordShipments.Size = new System.Drawing.Size(290, 21);
            this.cbSelectRecordShipments.TabIndex = 0;
            // 
            // btnSaveShipment
            // 
            this.btnSaveShipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveShipment.Location = new System.Drawing.Point(10, 243);
            this.btnSaveShipment.Name = "btnSaveShipment";
            this.btnSaveShipment.Size = new System.Drawing.Size(144, 23);
            this.btnSaveShipment.TabIndex = 2;
            this.btnSaveShipment.Text = "Сохранить";
            this.btnSaveShipment.UseVisualStyleBackColor = false;
            this.btnSaveShipment.Click += new System.EventHandler(this.btnSaveShipment_Click);
            // 
            // btnDeleteShipment
            // 
            this.btnDeleteShipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteShipment.Location = new System.Drawing.Point(156, 243);
            this.btnDeleteShipment.Name = "btnDeleteShipment";
            this.btnDeleteShipment.Size = new System.Drawing.Size(144, 23);
            this.btnDeleteShipment.TabIndex = 3;
            this.btnDeleteShipment.Text = "Удалить";
            this.btnDeleteShipment.UseVisualStyleBackColor = false;
            this.btnDeleteShipment.Click += new System.EventHandler(this.btnDeleteShipment_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.tabControl);
            this.Name = "Form3";
            this.Text = "Изменение записей";
            this.tabControl.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            this.tabClients.PerformLayout();
            this.tabContracts.ResumeLayout(false);
            this.tabContracts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalAmount)).EndInit();
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).EndInit();
            this.tabPayments.ResumeLayout(false);
            this.tabPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountPayment)).EndInit();
            this.tabShipments.ResumeLayout(false);
            this.tabShipments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityShipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabContracts;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabPayments;
        private System.Windows.Forms.TabPage tabShipments;
        private System.Windows.Forms.ComboBox cbSelectRecordClients;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.ComboBox cbSelectRecordContracts;
        private System.Windows.Forms.Button btnSaveContract;
        private System.Windows.Forms.Button btnDeleteContract;
        private System.Windows.Forms.ComboBox cbSelectRecordProducts;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.ComboBox cbSelectRecordPayments;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.ComboBox cbSelectRecordShipments;
        private System.Windows.Forms.Button btnSaveShipment;
        private System.Windows.Forms.Button btnDeleteShipment;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblClientNameContract;
        private System.Windows.Forms.ComboBox cbClientNameContract;
        private System.Windows.Forms.Label lblProductNameContract;
        private System.Windows.Forms.ComboBox cbProductNameContract;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblPrepayment;
        private System.Windows.Forms.NumericUpDown numPrepayment;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.NumericUpDown numTotalAmount;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.NumericUpDown numProductPrice;
        private System.Windows.Forms.Label lblContractIdPayment;
        private System.Windows.Forms.ComboBox cbContractIdPayment;
        private System.Windows.Forms.Label lblAmountPayment;
        private System.Windows.Forms.NumericUpDown numAmountPayment;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblContractIdShipment;
        private System.Windows.Forms.ComboBox cbContractIdShipment;
        private System.Windows.Forms.Label lblQuantityShipment;
        private System.Windows.Forms.NumericUpDown numQuantityShipment;
    }
}
