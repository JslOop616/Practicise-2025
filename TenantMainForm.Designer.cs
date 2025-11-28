namespace ApartmentRentalSystem
{
    partial class TenantMainForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageApartments = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSelectedApartment = new System.Windows.Forms.Label();
            this.dataGridViewApartments = new System.Windows.Forms.DataGridView();
            this.lblApartmentCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxRooms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinRooms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageApplication = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSubmitApplication = new System.Windows.Forms.Button();
            this.txtApplicationComments = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numRentalPeriod = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpMoveInDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenantEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenantPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageMyApplications = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewApplications = new System.Windows.Forms.DataGridView();
            this.lblApplicationCount = new System.Windows.Forms.Label();
            this.btnLoadMyApplications = new System.Windows.Forms.Button();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageApartments.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApartments)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageApplication.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentalPeriod)).BeginInit();
            this.tabPageMyApplications.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageApartments);
            this.tabControl1.Controls.Add(this.tabPageApplication);
            this.tabControl1.Controls.Add(this.tabPageMyApplications);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageApartments
            // 
            this.tabPageApartments.Controls.Add(this.groupBox2);
            this.tabPageApartments.Controls.Add(this.groupBox1);
            this.tabPageApartments.Location = new System.Drawing.Point(4, 22);
            this.tabPageApartments.Name = "tabPageApartments";
            this.tabPageApartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApartments.Size = new System.Drawing.Size(876, 535);
            this.tabPageApartments.TabIndex = 0;
            this.tabPageApartments.Text = "Поиск квартир";
            this.tabPageApartments.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblSelectedApartment);
            this.groupBox2.Controls.Add(this.dataGridViewApartments);
            this.groupBox2.Controls.Add(this.lblApartmentCount);
            this.groupBox2.Location = new System.Drawing.Point(8, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 407);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Доступные квартиры";
            // 
            // lblSelectedApartment
            // 
            this.lblSelectedApartment.AutoSize = true;
            this.lblSelectedApartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedApartment.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSelectedApartment.Location = new System.Drawing.Point(6, 380);
            this.lblSelectedApartment.Name = "lblSelectedApartment";
            this.lblSelectedApartment.Size = new System.Drawing.Size(154, 15);
            this.lblSelectedApartment.TabIndex = 2;
            this.lblSelectedApartment.Text = "Выберите квартиру →";
            // 
            // dataGridViewApartments
            // 
            this.dataGridViewApartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewApartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApartments.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewApartments.Name = "dataGridViewApartments";
            this.dataGridViewApartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewApartments.Size = new System.Drawing.Size(848, 358);
            this.dataGridViewApartments.TabIndex = 1;
            this.dataGridViewApartments.SelectionChanged += new System.EventHandler(this.dataGridViewApartments_SelectionChanged);
            // 
            // lblApartmentCount
            // 
            this.lblApartmentCount.AutoSize = true;
            this.lblApartmentCount.Location = new System.Drawing.Point(6, 360);
            this.lblApartmentCount.Name = "lblApartmentCount";
            this.lblApartmentCount.Size = new System.Drawing.Size(89, 13);
            this.lblApartmentCount.TabIndex = 0;
            this.lblApartmentCount.Text = "Найдено квартир: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClearSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtMaxPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaxRooms);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMinRooms);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearchAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.Orange;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(600, 65);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(120, 30);
            this.btnClearSearch.TabIndex = 9;
            this.btnClearSearch.Text = "Сбросить";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(600, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 30);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(450, 65);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(120, 20);
            this.txtMaxPrice.TabIndex = 7;
            this.txtMaxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Макс. цена (руб):";
            // 
            // txtMaxRooms
            // 
            this.txtMaxRooms.Location = new System.Drawing.Point(450, 25);
            this.txtMaxRooms.Name = "txtMaxRooms";
            this.txtMaxRooms.Size = new System.Drawing.Size(120, 20);
            this.txtMaxRooms.TabIndex = 5;
            this.txtMaxRooms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinRooms_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Макс. комнат:";
            // 
            // txtMinRooms
            // 
            this.txtMinRooms.Location = new System.Drawing.Point(200, 65);
            this.txtMinRooms.Name = "txtMinRooms";
            this.txtMinRooms.Size = new System.Drawing.Size(120, 20);
            this.txtMinRooms.TabIndex = 3;
            this.txtMinRooms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinRooms_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Мин. комнат:";
            // 
            // txtSearchAddress
            // 
            this.txtSearchAddress.Location = new System.Drawing.Point(200, 25);
            this.txtSearchAddress.Name = "txtSearchAddress";
            this.txtSearchAddress.Size = new System.Drawing.Size(120, 20);
            this.txtSearchAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес (часть):";
            // 
            // tabPageApplication
            // 
            this.tabPageApplication.Controls.Add(this.groupBox4);
            this.tabPageApplication.Location = new System.Drawing.Point(4, 22);
            this.tabPageApplication.Name = "tabPageApplication";
            this.tabPageApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApplication.Size = new System.Drawing.Size(876, 535);
            this.tabPageApplication.TabIndex = 1;
            this.tabPageApplication.Text = "Подача заявки";
            this.tabPageApplication.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnSubmitApplication);
            this.groupBox4.Controls.Add(this.txtApplicationComments);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.numRentalPeriod);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.dtpMoveInDate);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtTenantEmail);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtTenantPhone);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtTenantName);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(860, 350);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Заявка на аренду";
            // 
            // btnSubmitApplication
            // 
            this.btnSubmitApplication.BackColor = System.Drawing.Color.Green;
            this.btnSubmitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmitApplication.ForeColor = System.Drawing.Color.White;
            this.btnSubmitApplication.Location = new System.Drawing.Point(350, 280);
            this.btnSubmitApplication.Name = "btnSubmitApplication";
            this.btnSubmitApplication.Size = new System.Drawing.Size(180, 40);
            this.btnSubmitApplication.TabIndex = 13;
            this.btnSubmitApplication.Text = "Подать заявку";
            this.btnSubmitApplication.UseVisualStyleBackColor = false;
            this.btnSubmitApplication.Click += new System.EventHandler(this.btnSubmitApplication_Click);
            // 
            // txtApplicationComments
            // 
            this.txtApplicationComments.Location = new System.Drawing.Point(200, 200);
            this.txtApplicationComments.Multiline = true;
            this.txtApplicationComments.Name = "txtApplicationComments";
            this.txtApplicationComments.Size = new System.Drawing.Size(330, 70);
            this.txtApplicationComments.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Комментарий:";
            // 
            // numRentalPeriod
            // 
            this.numRentalPeriod.Location = new System.Drawing.Point(200, 170);
            this.numRentalPeriod.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numRentalPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRentalPeriod.Name = "numRentalPeriod";
            this.numRentalPeriod.Size = new System.Drawing.Size(120, 20);
            this.numRentalPeriod.TabIndex = 10;
            this.numRentalPeriod.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Срок (месяцев):";
            // 
            // dtpMoveInDate
            // 
            this.dtpMoveInDate.Location = new System.Drawing.Point(200, 140);
            this.dtpMoveInDate.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpMoveInDate.Name = "dtpMoveInDate";
            this.dtpMoveInDate.Size = new System.Drawing.Size(200, 20);
            this.dtpMoveInDate.TabIndex = 8;
            this.dtpMoveInDate.Value = new System.DateTime(2024, 11, 28, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Желаемая дата:";
            // 
            // txtTenantEmail
            // 
            this.txtTenantEmail.Location = new System.Drawing.Point(200, 110);
            this.txtTenantEmail.Name = "txtTenantEmail";
            this.txtTenantEmail.Size = new System.Drawing.Size(200, 20);
            this.txtTenantEmail.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Email:";
            // 
            // txtTenantPhone
            // 
            this.txtTenantPhone.Location = new System.Drawing.Point(200, 80);
            this.txtTenantPhone.Name = "txtTenantPhone";
            this.txtTenantPhone.Size = new System.Drawing.Size(200, 20);
            this.txtTenantPhone.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Телефон:";
            // 
            // txtTenantName
            // 
            this.txtTenantName.Location = new System.Drawing.Point(200, 50);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.Size = new System.Drawing.Size(200, 20);
            this.txtTenantName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ФИО:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(100, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Сначала выберите квартиру на вкладке \"Поиск квартир\" ↑";
            // 
            // tabPageMyApplications
            // 
            this.tabPageMyApplications.Controls.Add(this.groupBox3);
            this.tabPageMyApplications.Location = new System.Drawing.Point(4, 22);
            this.tabPageMyApplications.Name = "tabPageMyApplications";
            this.tabPageMyApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMyApplications.Size = new System.Drawing.Size(876, 535);
            this.tabPageMyApplications.TabIndex = 2;
            this.tabPageMyApplications.Text = "Мои заявки";
            this.tabPageMyApplications.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridViewApplications);
            this.groupBox3.Controls.Add(this.lblApplicationCount);
            this.groupBox3.Controls.Add(this.btnLoadMyApplications);
            this.groupBox3.Controls.Add(this.txtSearchPhone);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(860, 521);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Мои заявки на аренду";
            // 
            // dataGridViewApplications
            // 
            this.dataGridViewApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplications.Location = new System.Drawing.Point(6, 80);
            this.dataGridViewApplications.Name = "dataGridViewApplications";
            this.dataGridViewApplications.ReadOnly = true;
            this.dataGridViewApplications.Size = new System.Drawing.Size(848, 435);
            this.dataGridViewApplications.TabIndex = 4;
            // 
            // lblApplicationCount
            // 
            this.lblApplicationCount.AutoSize = true;
            this.lblApplicationCount.Location = new System.Drawing.Point(6, 60);
            this.lblApplicationCount.Name = "lblApplicationCount";
            this.lblApplicationCount.Size = new System.Drawing.Size(85, 13);
            this.lblApplicationCount.TabIndex = 3;
            this.lblApplicationCount.Text = "Найдено заявок: 0";
            // 
            // btnLoadMyApplications
            // 
            this.btnLoadMyApplications.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoadMyApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadMyApplications.ForeColor = System.Drawing.Color.White;
            this.btnLoadMyApplications.Location = new System.Drawing.Point(300, 25);
            this.btnLoadMyApplications.Name = "btnLoadMyApplications";
            this.btnLoadMyApplications.Size = new System.Drawing.Size(120, 30);
            this.btnLoadMyApplications.TabIndex = 2;
            this.btnLoadMyApplications.Text = "Загрузить заявки";
            this.btnLoadMyApplications.UseVisualStyleBackColor = false;
            this.btnLoadMyApplications.Click += new System.EventHandler(this.btnLoadMyApplications_Click);
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.Location = new System.Drawing.Point(150, 28);
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(130, 20);
            this.txtSearchPhone.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ваш телефон для поиска:";
            // 
            // TenantMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "TenantMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система аренды квартир - Версия арендатора";
            this.Load += new System.EventHandler(this.TenantMainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageApartments.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApartments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageApplication.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentalPeriod)).EndInit();
            this.tabPageMyApplications.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageApartments;
        private System.Windows.Forms.TabPage tabPageApplication;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewApartments;
        private System.Windows.Forms.Label lblApartmentCount;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxRooms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSubmitApplication;
        private System.Windows.Forms.TextBox txtApplicationComments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numRentalPeriod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpMoveInDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenantEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenantPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenantName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageMyApplications;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewApplications;
        private System.Windows.Forms.Label lblApplicationCount;
        private System.Windows.Forms.Button btnLoadMyApplications;
        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSelectedApartment;
    }
}