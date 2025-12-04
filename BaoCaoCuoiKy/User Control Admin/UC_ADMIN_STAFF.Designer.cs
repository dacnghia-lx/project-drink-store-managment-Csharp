namespace BaoCaoCuoiKy.User_Control
{
    partial class UC_ADMIN_STAFF
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ADMIN_STAFF));
            this.dg_nhanvien = new System.Windows.Forms.DataGridView();
            this.col_ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelControl = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChooseImage = new Guna.UI2.WinForms.Guna2Button();
            this.ImgEmployee = new Guna.UI2.WinForms.Guna2PictureBox();
            this.comboBoxPosition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateTimePickerStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePickerDob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textBoxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.textboxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panelDataListTable = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dg_nhanvien)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEmployee)).BeginInit();
            this.panelDataListTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_nhanvien
            // 
            this.dg_nhanvien.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            this.dg_nhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_nhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_nhanvien.ColumnHeadersHeight = 40;
            this.dg_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ma,
            this.col_ten,
            this.col_dt,
            this.col_gt,
            this.col_ns,
            this.col_cv,
            this.col_dc,
            this.col_nvl,
            this.col_anh,
            this.col_status});
            this.dg_nhanvien.Location = new System.Drawing.Point(18, 74);
            this.dg_nhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.dg_nhanvien.Name = "dg_nhanvien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_nhanvien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            this.dg_nhanvien.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_nhanvien.Size = new System.Drawing.Size(1608, 408);
            this.dg_nhanvien.TabIndex = 1;
            this.dg_nhanvien.SelectionChanged += new System.EventHandler(this.DgNhanVien_SelectionChanged);
            // 
            // col_ma
            // 
            this.col_ma.HeaderText = "Mã ";
            this.col_ma.Name = "col_ma";
            // 
            // col_ten
            // 
            this.col_ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ten.HeaderText = "Họ Tên";
            this.col_ten.Name = "col_ten";
            // 
            // col_dt
            // 
            this.col_dt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dt.HeaderText = "Điện Thoại";
            this.col_dt.Name = "col_dt";
            // 
            // col_gt
            // 
            this.col_gt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_gt.HeaderText = "Giới Tính";
            this.col_gt.Name = "col_gt";
            // 
            // col_ns
            // 
            this.col_ns.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ns.HeaderText = "Ngày Sinh";
            this.col_ns.Name = "col_ns";
            // 
            // col_cv
            // 
            this.col_cv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_cv.HeaderText = "Chức vụ";
            this.col_cv.Name = "col_cv";
            // 
            // col_dc
            // 
            this.col_dc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dc.HeaderText = "Địa Chỉ";
            this.col_dc.Name = "col_dc";
            // 
            // col_nvl
            // 
            this.col_nvl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_nvl.HeaderText = "Ngày vào làm";
            this.col_nvl.Name = "col_nvl";
            // 
            // col_anh
            // 
            this.col_anh.HeaderText = "Anh";
            this.col_anh.Name = "col_anh";
            this.col_anh.Visible = false;
            // 
            // col_status
            // 
            this.col_status.HeaderText = "Trạng thái";
            this.col_status.Name = "col_status";
            this.col_status.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "ĐIện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(914, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1209, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(914, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1209, 221);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ngày vào làm";
            // 
            // btn_save
            // 
            this.btn_save.BorderRadius = 12;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.Green;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1492, 324);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(140, 50);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "Lưu";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(16, 26);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(381, 39);
            this.lblHeader.TabIndex = 25;
            this.lblHeader.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl.BorderRadius = 16;
            this.panelControl.BorderThickness = 1;
            this.panelControl.Controls.Add(this.btnChooseImage);
            this.panelControl.Controls.Add(this.ImgEmployee);
            this.panelControl.Controls.Add(this.comboBoxPosition);
            this.panelControl.Controls.Add(this.dateTimePickerStartDate);
            this.panelControl.Controls.Add(this.dateTimePickerDob);
            this.panelControl.Controls.Add(this.btn_save);
            this.panelControl.Controls.Add(this.textBoxAddress);
            this.panelControl.Controls.Add(this.label9);
            this.panelControl.Controls.Add(this.textboxPhone);
            this.panelControl.Controls.Add(this.comboBoxGender);
            this.panelControl.Controls.Add(this.textBoxName);
            this.panelControl.Controls.Add(this.textBoxId);
            this.panelControl.Controls.Add(this.btnClear);
            this.panelControl.Controls.Add(this.btnCreate);
            this.panelControl.Controls.Add(this.label8);
            this.panelControl.Controls.Add(this.btnDelete);
            this.panelControl.Controls.Add(this.btnEdit);
            this.panelControl.Controls.Add(this.label7);
            this.panelControl.Controls.Add(this.label10);
            this.panelControl.Controls.Add(this.label6);
            this.panelControl.Controls.Add(this.label5);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Location = new System.Drawing.Point(23, 86);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1646, 388);
            this.panelControl.TabIndex = 26;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseImage.BorderRadius = 12;
            this.btnChooseImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.Color.White;
            this.btnChooseImage.Location = new System.Drawing.Point(41, 288);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(180, 45);
            this.btnChooseImage.TabIndex = 45;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.UseTransparentBackground = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // ImgEmployee
            // 
            this.ImgEmployee.Image = ((System.Drawing.Image)(resources.GetObject("ImgEmployee.Image")));
            this.ImgEmployee.ImageRotate = 0F;
            this.ImgEmployee.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgEmployee.InitialImage")));
            this.ImgEmployee.Location = new System.Drawing.Point(32, 61);
            this.ImgEmployee.Name = "ImgEmployee";
            this.ImgEmployee.Size = new System.Drawing.Size(201, 221);
            this.ImgEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgEmployee.TabIndex = 44;
            this.ImgEmployee.TabStop = false;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxPosition.BorderColor = System.Drawing.Color.Green;
            this.comboBoxPosition.BorderRadius = 10;
            this.comboBoxPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxPosition.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPosition.ItemHeight = 36;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Phục vụ",
            "Pha chế",
            "Thu ngân"});
            this.comboBoxPosition.Location = new System.Drawing.Point(614, 245);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(243, 42);
            this.comboBoxPosition.TabIndex = 43;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerStartDate.BorderColor = System.Drawing.Color.Green;
            this.dateTimePickerStartDate.BorderRadius = 12;
            this.dateTimePickerStartDate.BorderThickness = 1;
            this.dateTimePickerStartDate.Checked = true;
            this.dateTimePickerStartDate.FillColor = System.Drawing.Color.White;
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(1212, 243);
            this.dateTimePickerStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(277, 43);
            this.dateTimePickerStartDate.TabIndex = 42;
            this.dateTimePickerStartDate.Value = new System.DateTime(2025, 12, 10, 10, 26, 0, 0);
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.BackColor = System.Drawing.Color.White;
            this.dateTimePickerDob.BorderColor = System.Drawing.Color.Green;
            this.dateTimePickerDob.BorderRadius = 12;
            this.dateTimePickerDob.BorderThickness = 1;
            this.dateTimePickerDob.Checked = true;
            this.dateTimePickerDob.FillColor = System.Drawing.Color.White;
            this.dateTimePickerDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePickerDob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerDob.Location = new System.Drawing.Point(1212, 132);
            this.dateTimePickerDob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(277, 43);
            this.dateTimePickerDob.TabIndex = 41;
            this.dateTimePickerDob.Value = new System.DateTime(2025, 12, 10, 10, 26, 0, 0);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BorderColor = System.Drawing.Color.Green;
            this.textBoxAddress.BorderRadius = 10;
            this.textBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddress.DefaultText = "";
            this.textBoxAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.ForeColor = System.Drawing.Color.Black;
            this.textBoxAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAddress.Location = new System.Drawing.Point(917, 244);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.PasswordChar = '\0';
            this.textBoxAddress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxAddress.PlaceholderText = "Nhập vào địa chỉ của nhân viên ....";
            this.textBoxAddress.SelectedText = "";
            this.textBoxAddress.Size = new System.Drawing.Size(242, 43);
            this.textBoxAddress.TabIndex = 39;
            // 
            // textboxPhone
            // 
            this.textboxPhone.BorderColor = System.Drawing.Color.Green;
            this.textboxPhone.BorderRadius = 10;
            this.textboxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxPhone.DefaultText = "";
            this.textboxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPhone.ForeColor = System.Drawing.Color.Black;
            this.textboxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxPhone.Location = new System.Drawing.Point(614, 131);
            this.textboxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxPhone.Name = "textboxPhone";
            this.textboxPhone.PasswordChar = '\0';
            this.textboxPhone.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textboxPhone.PlaceholderText = "Nhập số diện thoại ...";
            this.textboxPhone.SelectedText = "";
            this.textboxPhone.Size = new System.Drawing.Size(248, 43);
            this.textboxPhone.TabIndex = 38;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxGender.BorderColor = System.Drawing.Color.Green;
            this.comboBoxGender.BorderRadius = 10;
            this.comboBoxGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxGender.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGender.ItemHeight = 36;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.comboBoxGender.Location = new System.Drawing.Point(917, 133);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(243, 42);
            this.comboBoxGender.TabIndex = 37;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderColor = System.Drawing.Color.Green;
            this.textBoxName.BorderRadius = 10;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Location = new System.Drawing.Point(285, 243);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxName.PlaceholderText = "Họ và tên nhân viên ...";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(277, 43);
            this.textBoxName.TabIndex = 35;
            // 
            // textBoxId
            // 
            this.textBoxId.BorderColor = System.Drawing.Color.Green;
            this.textBoxId.BorderRadius = 10;
            this.textBoxId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxId.DefaultText = "";
            this.textBoxId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.ForeColor = System.Drawing.Color.Black;
            this.textBoxId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxId.Location = new System.Drawing.Point(285, 131);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PasswordChar = '\0';
            this.textBoxId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxId.PlaceholderText = "Nhập mã nhân viên ...";
            this.textBoxId.SelectedText = "";
            this.textBoxId.Size = new System.Drawing.Size(277, 43);
            this.textBoxId.TabIndex = 34;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 12;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1452, 14);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 45);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Reset thông tin";
            this.btnClear.UseTransparentBackground = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BorderRadius = 12;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.LimeGreen;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(893, 14);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 45);
            this.btnCreate.TabIndex = 32;
            this.btnCreate.Text = "Thêm nhân viên mới";
            this.btnCreate.UseTransparentBackground = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 12;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1265, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 45);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Xoá nhân viên";
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 12;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1079, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 45);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Chỉnh sửa thông tin";
            this.btnEdit.UseTransparentBackground = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(14, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Thông tin nhân viên";
            // 
            // panelDataListTable
            // 
            this.panelDataListTable.BorderColor = System.Drawing.Color.Silver;
            this.panelDataListTable.BorderRadius = 20;
            this.panelDataListTable.BorderThickness = 1;
            this.panelDataListTable.Controls.Add(this.guna2Button1);
            this.panelDataListTable.Controls.Add(this.label1);
            this.panelDataListTable.Controls.Add(this.dg_nhanvien);
            this.panelDataListTable.Location = new System.Drawing.Point(23, 480);
            this.panelDataListTable.Name = "panelDataListTable";
            this.panelDataListTable.Size = new System.Drawing.Size(1646, 496);
            this.panelDataListTable.TabIndex = 27;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.SystemColors.HotTrack;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1533, 22);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(80, 45);
            this.guna2Button1.TabIndex = 46;
            this.guna2Button1.Text = "Xuất";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UC_ADMIN_STAFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panelDataListTable);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ADMIN_STAFF";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.UC_QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_nhanvien)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEmployee)).EndInit();
            this.panelDataListTable.ResumeLayout(false);
            this.panelDataListTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_nhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2Panel panelControl;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxGender;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxId;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox textboxPhone;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerDob;
        private Guna.UI2.WinForms.Guna2TextBox textBoxAddress;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelDataListTable;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerStartDate;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxPosition;
        private Guna.UI2.WinForms.Guna2PictureBox ImgEmployee;
        private Guna.UI2.WinForms.Guna2Button btnChooseImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ns;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
    }
}
