namespace ApartmentRentalAdmin
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLandlordPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLandlordName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudArea = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRooms = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAnnualRevenue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMonthlyRevenue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRented = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFindUndervalued = new System.Windows.Forms.Button();
            this.btnCalculateOptimal = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtLandlordPhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLandlordName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkAvailable);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudArea);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudRooms);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление квартирами";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(450, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(450, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(450, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(450, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLandlordPhone
            // 
            this.txtLandlordPhone.Location = new System.Drawing.Point(120, 200);
            this.txtLandlordPhone.Name = "txtLandlordPhone";
            this.txtLandlordPhone.Size = new System.Drawing.Size(150, 20);
            this.txtLandlordPhone.TabIndex = 14;
            this.txtLandlordPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLandlordPhone_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Телефон:";
            // 
            // txtLandlordName
            // 
            this.txtLandlordName.Location = new System.Drawing.Point(120, 170);
            this.txtLandlordName.Name = "txtLandlordName";
            this.txtLandlordName.Size = new System.Drawing.Size(150, 20);
            this.txtLandlordName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ФИО:";
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Checked = true;
            this.chkAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAvailable.Location = new System.Drawing.Point(300, 140);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(94, 17);
            this.chkAvailable.TabIndex = 10;
            this.chkAvailable.Text = "Доступна для аренды";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 110);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 50);
            this.txtDescription.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Описание:";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrice.Location = new System.Drawing.Point(120, 80);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 20);
            this.nudPrice.TabIndex = 7;
            this.nudPrice.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена:";
            // 
            // nudArea
            // 
            this.nudArea.DecimalPlaces = 1;
            this.nudArea.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudArea.Location = new System.Drawing.Point(300, 50);
            this.nudArea.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudArea.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudArea.Name = "nudArea";
            this.nudArea.Size = new System.Drawing.Size(120, 20);
            this.nudArea.TabIndex = 5;
            this.nudArea.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Площадь:";
            // 
            // nudRooms
            // 
            this.nudRooms.Location = new System.Drawing.Point(120, 50);
            this.nudRooms.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRooms.Name = "nudRooms";
            this.nudRooms.Size = new System.Drawing.Size(120, 20);
            this.nudRooms.TabIndex = 3;
            this.nudRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Комнат:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblAnnualRevenue);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblMonthlyRevenue);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblRented);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblAvailable);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(618, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статистика";
            // 
            // lblAnnualRevenue
            // 
            this.lblAnnualRevenue.AutoSize = true;
            this.lblAnnualRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnualRevenue.Location = new System.Drawing.Point(80, 120);
            this.lblAnnualRevenue.Name = "lblAnnualRevenue";
            this.lblAnnualRevenue.Size = new System.Drawing.Size(41, 13);
            this.lblAnnualRevenue.TabIndex = 9;
            this.lblAnnualRevenue.Text = "0 руб";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Годовой:";
            // 
            // lblMonthlyRevenue
            // 
            this.lblMonthlyRevenue.AutoSize = true;
            this.lblMonthlyRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMonthlyRevenue.Location = new System.Drawing.Point(80, 100);
            this.lblMonthlyRevenue.Name = "lblMonthlyRevenue";
            this.lblMonthlyRevenue.Size = new System.Drawing.Size(41, 13);
            this.lblMonthlyRevenue.TabIndex = 7;
            this.lblMonthlyRevenue.Text = "0 руб";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Месячный:";
            // 
            // lblRented
            // 
            this.lblRented.AutoSize = true;
            this.lblRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRented.Location = new System.Drawing.Point(80, 60);
            this.lblRented.Name = "lblRented";
            this.lblRented.Size = new System.Drawing.Size(14, 13);
            this.lblRented.TabIndex = 5;
            this.lblRented.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Сдано:";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvailable.Location = new System.Drawing.Point(80, 40);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(14, 13);
            this.lblAvailable.TabIndex = 3;
            this.lblAvailable.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Свободно:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(80, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Всего квартир:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnFindUndervalued);
            this.groupBox3.Controls.Add(this.btnCalculateOptimal);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Location = new System.Drawing.Point(618, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 94);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Аналитика";
            // 
            // btnFindUndervalued
            // 
            this.btnFindUndervalued.BackColor = System.Drawing.Color.Green;
            this.btnFindUndervalued.ForeColor = System.Drawing.Color.White;
            this.btnFindUndervalued.Location = new System.Drawing.Point(10, 55);
            this.btnFindUndervalued.Name = "btnFindUndervalued";
            this.btnFindUndervalued.Size = new System.Drawing.Size(150, 30);
            this.btnFindUndervalued.TabIndex = 2;
            this.btnFindUndervalued.Text = "Найти недорогие";
            this.btnFindUndervalued.UseVisualStyleBackColor = false;
            this.btnFindUndervalued.Click += new System.EventHandler(this.btnFindUndervalued_Click);
            // 
            // btnCalculateOptimal
            // 
            this.btnCalculateOptimal.BackColor = System.Drawing.Color.Blue;
            this.btnCalculateOptimal.ForeColor = System.Drawing.Color.White;
            this.btnCalculateOptimal.Location = new System.Drawing.Point(10, 20);
            this.btnCalculateOptimal.Name = "btnCalculateOptimal";
            this.btnCalculateOptimal.Size = new System.Drawing.Size(150, 30);
            this.btnCalculateOptimal.TabIndex = 1;
            this.btnCalculateOptimal.Text = "Оптимальная цена";
            this.btnCalculateOptimal.UseVisualStyleBackColor = false;
            this.btnCalculateOptimal.Click += new System.EventHandler(this.btnCalculateOptimal_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(10, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(816, 619);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система аренды квартир - Администратор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.TextBox txtLandlordName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLandlordPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRented;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAnnualRevenue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMonthlyRevenue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCalculateOptimal;
        private System.Windows.Forms.Button btnFindUndervalued;
    }
}