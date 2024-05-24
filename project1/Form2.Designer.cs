namespace project1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.tabContracts = new System.Windows.Forms.TabPage();
            this.lblClientNameContract = new System.Windows.Forms.Label();
            this.cbClientNameContract = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPrepayment = new System.Windows.Forms.Label();
            this.numPrepayment = new System.Windows.Forms.NumericUpDown();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.numTotalAmount = new System.Windows.Forms.NumericUpDown();
            this.btnSaveContract = new System.Windows.Forms.Button();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.txtProductNameAdd = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.numProductPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.tabPayments = new System.Windows.Forms.TabPage();
            this.lblContractIdPayment = new System.Windows.Forms.Label();
            this.cbContractIdPayment = new System.Windows.Forms.ComboBox();
            this.lblAmountPayment = new System.Windows.Forms.Label();
            this.numAmountPayment = new System.Windows.Forms.NumericUpDown();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.tabShipments = new System.Windows.Forms.TabPage();
            this.lblContractIdShipment = new System.Windows.Forms.Label();
            this.cbContractIdShipment = new System.Windows.Forms.ComboBox();
            this.lblQuantityShipment = new System.Windows.Forms.Label();
            this.numQuantityShipment = new System.Windows.Forms.NumericUpDown();
            this.btnSaveShipment = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.tabClients.Controls.Add(this.btnSaveClient);
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
            this.lblClientName.Location = new System.Drawing.Point(10, 20);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(73, 13);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Имя клиента";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(100, 17);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(200, 20);
            this.txtClientName.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtClientName, "Введите имя клиента");
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveClient.Location = new System.Drawing.Point(13, 243);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(287, 23);
            this.btnSaveClient.TabIndex = 2;
            this.btnSaveClient.Text = "Сохранить клиента";
            this.toolTip.SetToolTip(this.btnSaveClient, "Нажмите, чтобы сохранить данные клиента");
            this.btnSaveClient.UseVisualStyleBackColor = false;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // tabContracts
            // 
            this.tabContracts.Controls.Add(this.lblClientNameContract);
            this.tabContracts.Controls.Add(this.cbClientNameContract);
            this.tabContracts.Controls.Add(this.lblProductName);
            this.tabContracts.Controls.Add(this.cbProductName);
            this.tabContracts.Controls.Add(this.lblQuantity);
            this.tabContracts.Controls.Add(this.numQuantity);
            this.tabContracts.Controls.Add(this.lblPrepayment);
            this.tabContracts.Controls.Add(this.numPrepayment);
            this.tabContracts.Controls.Add(this.lblTotalAmount);
            this.tabContracts.Controls.Add(this.numTotalAmount);
            this.tabContracts.Controls.Add(this.btnSaveContract);
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
            this.lblClientNameContract.Location = new System.Drawing.Point(10, 20);
            this.lblClientNameContract.Name = "lblClientNameContract";
            this.lblClientNameContract.Size = new System.Drawing.Size(73, 13);
            this.lblClientNameContract.TabIndex = 0;
            this.lblClientNameContract.Text = "Имя клиента";
            // 
            // cbClientNameContract
            // 
            this.cbClientNameContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientNameContract.FormattingEnabled = true;
            this.cbClientNameContract.Location = new System.Drawing.Point(100, 17);
            this.cbClientNameContract.Name = "cbClientNameContract";
            this.cbClientNameContract.Size = new System.Drawing.Size(200, 21);
            this.cbClientNameContract.TabIndex = 1;
            this.toolTip.SetToolTip(this.cbClientNameContract, "Выберите имя клиента");
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(10, 50);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(95, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Название товара";
            // 
            // cbProductName
            // 
            this.cbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(100, 47);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(200, 21);
            this.cbProductName.TabIndex = 3;
            this.toolTip.SetToolTip(this.cbProductName, "Выберите название товара");
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(10, 80);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(66, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Количество";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(100, 78);
            this.numQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(200, 20);
            this.numQuantity.TabIndex = 5;
            this.toolTip.SetToolTip(this.numQuantity, "Введите количество товара");
            // 
            // lblPrepayment
            // 
            this.lblPrepayment.AutoSize = true;
            this.lblPrepayment.Location = new System.Drawing.Point(10, 110);
            this.lblPrepayment.Name = "lblPrepayment";
            this.lblPrepayment.Size = new System.Drawing.Size(68, 13);
            this.lblPrepayment.TabIndex = 6;
            this.lblPrepayment.Text = "Предоплата";
            // 
            // numPrepayment
            // 
            this.numPrepayment.Location = new System.Drawing.Point(100, 108);
            this.numPrepayment.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrepayment.Name = "numPrepayment";
            this.numPrepayment.Size = new System.Drawing.Size(200, 20);
            this.numPrepayment.TabIndex = 7;
            this.toolTip.SetToolTip(this.numPrepayment, "Введите сумму предоплаты");
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(10, 140);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(78, 13);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "Общая сумма";
            // 
            // numTotalAmount
            // 
            this.numTotalAmount.Location = new System.Drawing.Point(100, 138);
            this.numTotalAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTotalAmount.Name = "numTotalAmount";
            this.numTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.numTotalAmount.TabIndex = 9;
            this.toolTip.SetToolTip(this.numTotalAmount, "Введите общую сумму");
            // 
            // btnSaveContract
            // 
            this.btnSaveContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveContract.Location = new System.Drawing.Point(13, 243);
            this.btnSaveContract.Name = "btnSaveContract";
            this.btnSaveContract.Size = new System.Drawing.Size(287, 23);
            this.btnSaveContract.TabIndex = 10;
            this.btnSaveContract.Text = "Сохранить договор";
            this.toolTip.SetToolTip(this.btnSaveContract, "Нажмите, чтобы сохранить данные договора");
            this.btnSaveContract.UseVisualStyleBackColor = false;
            this.btnSaveContract.Click += new System.EventHandler(this.btnSaveContract_Click);
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.lblProductNameAdd);
            this.tabProducts.Controls.Add(this.txtProductNameAdd);
            this.tabProducts.Controls.Add(this.lblProductPrice);
            this.tabProducts.Controls.Add(this.numProductPrice);
            this.tabProducts.Controls.Add(this.btnSaveProduct);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(312, 274);
            this.tabProducts.TabIndex = 4;
            this.tabProducts.Text = "Товары";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(10, 20);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(95, 13);
            this.lblProductNameAdd.TabIndex = 0;
            this.lblProductNameAdd.Text = "Название товара";
            // 
            // txtProductNameAdd
            // 
            this.txtProductNameAdd.Location = new System.Drawing.Point(100, 17);
            this.txtProductNameAdd.Name = "txtProductNameAdd";
            this.txtProductNameAdd.Size = new System.Drawing.Size(200, 20);
            this.txtProductNameAdd.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtProductNameAdd, "Введите название товара");
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(10, 50);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(33, 13);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "Цена";
            // 
            // numProductPrice
            // 
            this.numProductPrice.DecimalPlaces = 2;
            this.numProductPrice.Location = new System.Drawing.Point(100, 47);
            this.numProductPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numProductPrice.Name = "numProductPrice";
            this.numProductPrice.Size = new System.Drawing.Size(200, 20);
            this.numProductPrice.TabIndex = 3;
            this.toolTip.SetToolTip(this.numProductPrice, "Введите цену товара");
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveProduct.Location = new System.Drawing.Point(13, 243);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(287, 23);
            this.btnSaveProduct.TabIndex = 4;
            this.btnSaveProduct.Text = "Сохранить товар";
            this.toolTip.SetToolTip(this.btnSaveProduct, "Нажмите, чтобы сохранить данные товара");
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // tabPayments
            // 
            this.tabPayments.Controls.Add(this.lblContractIdPayment);
            this.tabPayments.Controls.Add(this.cbContractIdPayment);
            this.tabPayments.Controls.Add(this.lblAmountPayment);
            this.tabPayments.Controls.Add(this.numAmountPayment);
            this.tabPayments.Controls.Add(this.cbPaymentType);
            this.tabPayments.Controls.Add(this.lblPaymentType);
            this.tabPayments.Controls.Add(this.btnSavePayment);
            this.tabPayments.Location = new System.Drawing.Point(4, 22);
            this.tabPayments.Name = "tabPayments";
            this.tabPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayments.Size = new System.Drawing.Size(312, 274);
            this.tabPayments.TabIndex = 2;
            this.tabPayments.Text = "Оплаты";
            this.tabPayments.UseVisualStyleBackColor = true;
            // 
            // lblContractIdPayment
            // 
            this.lblContractIdPayment.AutoSize = true;
            this.lblContractIdPayment.Location = new System.Drawing.Point(10, 20);
            this.lblContractIdPayment.Name = "lblContractIdPayment";
            this.lblContractIdPayment.Size = new System.Drawing.Size(68, 13);
            this.lblContractIdPayment.TabIndex = 0;
            this.lblContractIdPayment.Text = "ID договора";
            // 
            // cbContractIdPayment
            // 
            this.cbContractIdPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContractIdPayment.FormattingEnabled = true;
            this.cbContractIdPayment.Location = new System.Drawing.Point(100, 17);
            this.cbContractIdPayment.Name = "cbContractIdPayment";
            this.cbContractIdPayment.Size = new System.Drawing.Size(200, 21);
            this.cbContractIdPayment.TabIndex = 1;
            this.toolTip.SetToolTip(this.cbContractIdPayment, "Выберите ID договора");
            // 
            // lblAmountPayment
            // 
            this.lblAmountPayment.AutoSize = true;
            this.lblAmountPayment.Location = new System.Drawing.Point(10, 50);
            this.lblAmountPayment.Name = "lblAmountPayment";
            this.lblAmountPayment.Size = new System.Drawing.Size(41, 13);
            this.lblAmountPayment.TabIndex = 2;
            this.lblAmountPayment.Text = "Сумма";
            // 
            // numAmountPayment
            // 
            this.numAmountPayment.Location = new System.Drawing.Point(100, 47);
            this.numAmountPayment.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAmountPayment.Name = "numAmountPayment";
            this.numAmountPayment.Size = new System.Drawing.Size(200, 20);
            this.numAmountPayment.TabIndex = 3;
            this.toolTip.SetToolTip(this.numAmountPayment, "Введите сумму оплаты");
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Items.AddRange(new object[] {
            "cash",
            "transfer"});
            this.cbPaymentType.Location = new System.Drawing.Point(100, 77);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(200, 21);
            this.cbPaymentType.TabIndex = 5;
            this.toolTip.SetToolTip(this.cbPaymentType, "Выберите тип оплаты");
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(10, 80);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(66, 13);
            this.lblPaymentType.TabIndex = 4;
            this.lblPaymentType.Text = "Тип оплаты";
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSavePayment.Location = new System.Drawing.Point(13, 243);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(287, 23);
            this.btnSavePayment.TabIndex = 4;
            this.btnSavePayment.Text = "Сохранить оплату";
            this.toolTip.SetToolTip(this.btnSavePayment, "Нажмите, чтобы сохранить данные оплаты");
            this.btnSavePayment.UseVisualStyleBackColor = false;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // tabShipments
            // 
            this.tabShipments.Controls.Add(this.lblContractIdShipment);
            this.tabShipments.Controls.Add(this.cbContractIdShipment);
            this.tabShipments.Controls.Add(this.lblQuantityShipment);
            this.tabShipments.Controls.Add(this.numQuantityShipment);
            this.tabShipments.Controls.Add(this.btnSaveShipment);
            this.tabShipments.Location = new System.Drawing.Point(4, 22);
            this.tabShipments.Name = "tabShipments";
            this.tabShipments.Padding = new System.Windows.Forms.Padding(3);
            this.tabShipments.Size = new System.Drawing.Size(312, 274);
            this.tabShipments.TabIndex = 3;
            this.tabShipments.Text = "Отгрузки";
            this.tabShipments.UseVisualStyleBackColor = true;
            // 
            // lblContractIdShipment
            // 
            this.lblContractIdShipment.AutoSize = true;
            this.lblContractIdShipment.Location = new System.Drawing.Point(10, 20);
            this.lblContractIdShipment.Name = "lblContractIdShipment";
            this.lblContractIdShipment.Size = new System.Drawing.Size(68, 13);
            this.lblContractIdShipment.TabIndex = 0;
            this.lblContractIdShipment.Text = "ID договора";
            // 
            // cbContractIdShipment
            // 
            this.cbContractIdShipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContractIdShipment.FormattingEnabled = true;
            this.cbContractIdShipment.Location = new System.Drawing.Point(100, 17);
            this.cbContractIdShipment.Name = "cbContractIdShipment";
            this.cbContractIdShipment.Size = new System.Drawing.Size(200, 21);
            this.cbContractIdShipment.TabIndex = 1;
            this.toolTip.SetToolTip(this.cbContractIdShipment, "Выберите ID договора");
            // 
            // lblQuantityShipment
            // 
            this.lblQuantityShipment.AutoSize = true;
            this.lblQuantityShipment.Location = new System.Drawing.Point(10, 50);
            this.lblQuantityShipment.Name = "lblQuantityShipment";
            this.lblQuantityShipment.Size = new System.Drawing.Size(66, 13);
            this.lblQuantityShipment.TabIndex = 2;
            this.lblQuantityShipment.Text = "Количество";
            // 
            // numQuantityShipment
            // 
            this.numQuantityShipment.Location = new System.Drawing.Point(100, 47);
            this.numQuantityShipment.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQuantityShipment.Name = "numQuantityShipment";
            this.numQuantityShipment.Size = new System.Drawing.Size(200, 20);
            this.numQuantityShipment.TabIndex = 3;
            this.toolTip.SetToolTip(this.numQuantityShipment, "Введите количество отгружаемого товара");
            // 
            // btnSaveShipment
            // 
            this.btnSaveShipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveShipment.Location = new System.Drawing.Point(13, 243);
            this.btnSaveShipment.Name = "btnSaveShipment";
            this.btnSaveShipment.Size = new System.Drawing.Size(287, 23);
            this.btnSaveShipment.TabIndex = 4;
            this.btnSaveShipment.Text = "Сохранить отгрузку";
            this.toolTip.SetToolTip(this.btnSaveShipment, "Нажмите, чтобы сохранить данные отгрузки");
            this.btnSaveShipment.UseVisualStyleBackColor = false;
            this.btnSaveShipment.Click += new System.EventHandler(this.btnSaveShipment_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Ввод данных";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.Label lblClientNameContract;
        private System.Windows.Forms.ComboBox cbClientNameContract;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblPrepayment;
        private System.Windows.Forms.NumericUpDown numPrepayment;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.NumericUpDown numTotalAmount;
        private System.Windows.Forms.Button btnSaveContract;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.TextBox txtProductNameAdd;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.NumericUpDown numProductPrice;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Label lblContractIdPayment;
        private System.Windows.Forms.ComboBox cbContractIdPayment;
        private System.Windows.Forms.Label lblAmountPayment;
        private System.Windows.Forms.NumericUpDown numAmountPayment;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.Label lblContractIdShipment;
        private System.Windows.Forms.ComboBox cbContractIdShipment;
        private System.Windows.Forms.Label lblQuantityShipment;
        private System.Windows.Forms.NumericUpDown numQuantityShipment;
        private System.Windows.Forms.Button btnSaveShipment;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
