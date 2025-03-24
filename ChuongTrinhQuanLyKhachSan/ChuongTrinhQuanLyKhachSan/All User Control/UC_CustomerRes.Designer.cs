namespace ChuongTrinhQuanLyKhachSan.All_User_Control
{
    partial class UC_CustomerRes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nationality = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Dob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_IDProof = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Checkin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Bed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Room = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_RoomNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_AllotCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gdvKS = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_FinalPrice = new System.Windows.Forms.Label();
            this.cmb_Discount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvKS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(50, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.DefaultText = "";
            this.txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Name.ForeColor = System.Drawing.Color.Black;
            this.txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Location = new System.Drawing.Point(54, 113);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PlaceholderText = "Enter Name";
            this.txt_Name.SelectedText = "";
            this.txt_Name.Size = new System.Drawing.Size(515, 74);
            this.txt_Name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Name.TabIndex = 2;
            this.txt_Name.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // txt_Contact
            // 
            this.txt_Contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Contact.DefaultText = "";
            this.txt_Contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Contact.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_Contact.ForeColor = System.Drawing.Color.Black;
            this.txt_Contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Contact.Location = new System.Drawing.Point(54, 267);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.PasswordChar = '\0';
            this.txt_Contact.PlaceholderText = "Enter Phone Number";
            this.txt_Contact.SelectedText = "";
            this.txt_Contact.Size = new System.Drawing.Size(515, 74);
            this.txt_Contact.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Contact.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(50, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Điện Thoại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Nationality
            // 
            this.txt_Nationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nationality.DefaultText = "";
            this.txt_Nationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Nationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Nationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Nationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Nationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Nationality.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_Nationality.ForeColor = System.Drawing.Color.Black;
            this.txt_Nationality.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Nationality.Location = new System.Drawing.Point(54, 420);
            this.txt_Nationality.Name = "txt_Nationality";
            this.txt_Nationality.PasswordChar = '\0';
            this.txt_Nationality.PlaceholderText = "Enter Nationnality";
            this.txt_Nationality.SelectedText = "";
            this.txt_Nationality.Size = new System.Drawing.Size(515, 74);
            this.txt_Nationality.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Nationality.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(50, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quốc Tịch";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(50, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới Tính";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_Gender
            // 
            this.txt_Gender.BackColor = System.Drawing.Color.Transparent;
            this.txt_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Gender.ForeColor = System.Drawing.Color.Black;
            this.txt_Gender.ItemHeight = 30;
            this.txt_Gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.txt_Gender.Location = new System.Drawing.Point(54, 573);
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.Size = new System.Drawing.Size(515, 36);
            this.txt_Gender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Gender.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(627, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày Sinh";
            // 
            // txt_Dob
            // 
            this.txt_Dob.Checked = true;
            this.txt_Dob.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.txt_Dob.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Dob.Location = new System.Drawing.Point(631, 573);
            this.txt_Dob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_Dob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_Dob.Name = "txt_Dob";
            this.txt_Dob.Size = new System.Drawing.Size(515, 36);
            this.txt_Dob.TabIndex = 10;
            this.txt_Dob.Value = new System.DateTime(2024, 12, 5, 14, 45, 50, 318);
            // 
            // txt_Address
            // 
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.DefaultText = "";
            this.txt_Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_Address.ForeColor = System.Drawing.Color.Black;
            this.txt_Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Address.Location = new System.Drawing.Point(625, 267);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.PlaceholderText = "Enter Address";
            this.txt_Address.SelectedText = "";
            this.txt_Address.Size = new System.Drawing.Size(515, 74);
            this.txt_Address.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Address.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(621, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Địa Chỉ";
            // 
            // txt_IDProof
            // 
            this.txt_IDProof.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IDProof.DefaultText = "";
            this.txt_IDProof.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IDProof.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IDProof.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDProof.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDProof.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDProof.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_IDProof.ForeColor = System.Drawing.Color.Black;
            this.txt_IDProof.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDProof.Location = new System.Drawing.Point(625, 113);
            this.txt_IDProof.Name = "txt_IDProof";
            this.txt_IDProof.PasswordChar = '\0';
            this.txt_IDProof.PlaceholderText = "Enter ID";
            this.txt_IDProof.SelectedText = "";
            this.txt_IDProof.Size = new System.Drawing.Size(515, 74);
            this.txt_IDProof.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_IDProof.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(621, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mã Định Danh";
            // 
            // txt_Checkin
            // 
            this.txt_Checkin.Checked = true;
            this.txt_Checkin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.txt_Checkin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Checkin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Checkin.Location = new System.Drawing.Point(625, 458);
            this.txt_Checkin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_Checkin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_Checkin.Name = "txt_Checkin";
            this.txt_Checkin.Size = new System.Drawing.Size(515, 36);
            this.txt_Checkin.TabIndex = 16;
            this.txt_Checkin.Value = new System.DateTime(2024, 12, 5, 14, 45, 50, 318);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(627, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ngày Đăng Ký";
            // 
            // txt_Bed
            // 
            this.txt_Bed.BackColor = System.Drawing.Color.Transparent;
            this.txt_Bed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_Bed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Bed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Bed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Bed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Bed.ForeColor = System.Drawing.Color.Black;
            this.txt_Bed.ItemHeight = 30;
            this.txt_Bed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.txt_Bed.Location = new System.Drawing.Point(17, 88);
            this.txt_Bed.Name = "txt_Bed";
            this.txt_Bed.Size = new System.Drawing.Size(515, 36);
            this.txt_Bed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Bed.TabIndex = 18;
            this.txt_Bed.SelectedIndexChanged += new System.EventHandler(this.txt_Bed_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(13, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Loại Giường";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_Room
            // 
            this.txt_Room.BackColor = System.Drawing.Color.Transparent;
            this.txt_Room.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_Room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Room.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Room.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Room.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Room.ForeColor = System.Drawing.Color.Black;
            this.txt_Room.ItemHeight = 30;
            this.txt_Room.Items.AddRange(new object[] {
            "Thuong",
            "Vip"});
            this.txt_Room.Location = new System.Drawing.Point(17, 199);
            this.txt_Room.Name = "txt_Room";
            this.txt_Room.Size = new System.Drawing.Size(515, 36);
            this.txt_Room.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Room.TabIndex = 20;
            this.txt_Room.SelectedIndexChanged += new System.EventHandler(this.txt_Room_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(13, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "Loại Phòng";
            // 
            // txt_RoomNo
            // 
            this.txt_RoomNo.BackColor = System.Drawing.Color.Transparent;
            this.txt_RoomNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_RoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_RoomNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RoomNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_RoomNo.ForeColor = System.Drawing.Color.Black;
            this.txt_RoomNo.ItemHeight = 30;
            this.txt_RoomNo.Location = new System.Drawing.Point(17, 316);
            this.txt_RoomNo.Name = "txt_RoomNo";
            this.txt_RoomNo.Size = new System.Drawing.Size(515, 36);
            this.txt_RoomNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_RoomNo.TabIndex = 22;
            this.txt_RoomNo.SelectedIndexChanged += new System.EventHandler(this.txt_RoomNo_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(13, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Số Phòng";
            // 
            // txt_Price
            // 
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.DefaultText = "";
            this.txt_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_Price.ForeColor = System.Drawing.Color.Black;
            this.txt_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Location = new System.Drawing.Point(17, 422);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.PlaceholderText = "";
            this.txt_Price.ReadOnly = true;
            this.txt_Price.SelectedText = "";
            this.txt_Price.Size = new System.Drawing.Size(515, 74);
            this.txt_Price.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Price.TabIndex = 24;
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(13, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = "Giá Tiền";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // btn_AllotCustomer
            // 
            this.btn_AllotCustomer.BorderRadius = 18;
            this.btn_AllotCustomer.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btn_AllotCustomer.BorderThickness = 1;
            this.btn_AllotCustomer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_AllotCustomer.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_AllotCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AllotCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AllotCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AllotCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AllotCustomer.FillColor = System.Drawing.Color.White;
            this.btn_AllotCustomer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_AllotCustomer.ForeColor = System.Drawing.Color.Black;
            this.btn_AllotCustomer.Location = new System.Drawing.Point(1629, 768);
            this.btn_AllotCustomer.Name = "btn_AllotCustomer";
            this.btn_AllotCustomer.Size = new System.Drawing.Size(223, 71);
            this.btn_AllotCustomer.TabIndex = 25;
            this.btn_AllotCustomer.Text = "Đặt Phòng";
            this.btn_AllotCustomer.Click += new System.EventHandler(this.btn_AllotCustomer_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label14);
            this.guna2GroupBox1.Controls.Add(this.cmb_Discount);
            this.guna2GroupBox1.Controls.Add(this.lbl_FinalPrice);
            this.guna2GroupBox1.Controls.Add(this.txt_Room);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.txt_Price);
            this.guna2GroupBox1.Controls.Add(this.txt_Bed);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.txt_RoomNo);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(1178, 68);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(674, 684);
            this.guna2GroupBox1.TabIndex = 26;
            this.guna2GroupBox1.Text = "Đặt Phòng";
            // 
            // gdvKS
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gdvKS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gdvKS.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvKS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gdvKS.ColumnHeadersHeight = 4;
            this.gdvKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvKS.DefaultCellStyle = dataGridViewCellStyle12;
            this.gdvKS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvKS.Location = new System.Drawing.Point(54, 658);
            this.gdvKS.Name = "gdvKS";
            this.gdvKS.RowHeadersVisible = false;
            this.gdvKS.RowHeadersWidth = 51;
            this.gdvKS.RowTemplate.Height = 24;
            this.gdvKS.Size = new System.Drawing.Size(1092, 181);
            this.gdvKS.TabIndex = 27;
            this.gdvKS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvKS.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdvKS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdvKS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdvKS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdvKS.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.gdvKS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvKS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdvKS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdvKS.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gdvKS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvKS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvKS.ThemeStyle.HeaderStyle.Height = 4;
            this.gdvKS.ThemeStyle.ReadOnly = false;
            this.gdvKS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvKS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvKS.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gdvKS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvKS.ThemeStyle.RowsStyle.Height = 24;
            this.gdvKS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvKS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvKS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvKS_CellContentClick);
            // 
            // lbl_FinalPrice
            // 
            this.lbl_FinalPrice.AutoSize = true;
            this.lbl_FinalPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_FinalPrice.Location = new System.Drawing.Point(25, 629);
            this.lbl_FinalPrice.Name = "lbl_FinalPrice";
            this.lbl_FinalPrice.Size = new System.Drawing.Size(92, 23);
            this.lbl_FinalPrice.TabIndex = 25;
            this.lbl_FinalPrice.Text = "Thành Tiền";
            this.lbl_FinalPrice.Click += new System.EventHandler(this.lbl_FinalPrice_Click);
            // 
            // cmb_Discount
            // 
            this.cmb_Discount.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Discount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Discount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Discount.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Discount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Discount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Discount.ForeColor = System.Drawing.Color.Black;
            this.cmb_Discount.ItemHeight = 30;
            this.cmb_Discount.Location = new System.Drawing.Point(17, 568);
            this.cmb_Discount.Name = "cmb_Discount";
            this.cmb_Discount.Size = new System.Drawing.Size(515, 36);
            this.cmb_Discount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_Discount.TabIndex = 26;
            this.cmb_Discount.SelectedIndexChanged += new System.EventHandler(this.cmb_Discount_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(25, 542);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 23);
            this.label14.TabIndex = 27;
            this.label14.Text = "Giảm Giá";
            // 
            // UC_CustomerRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gdvKS);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btn_AllotCustomer);
            this.Controls.Add(this.txt_Checkin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_IDProof);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Dob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Gender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Nationality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Contact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_CustomerRes";
            this.Size = new System.Drawing.Size(1882, 852);
            this.Load += new System.EventHandler(this.UC_CustomerRes_Load);
            this.Leave += new System.EventHandler(this.UC_CustomerRes_Leave);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvKS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private Guna.UI2.WinForms.Guna2TextBox txt_Contact;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_Nationality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox txt_Gender;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_Dob;
        private Guna.UI2.WinForms.Guna2TextBox txt_Address;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_IDProof;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_Checkin;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox txt_Bed;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox txt_Room;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox txt_RoomNo;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txt_Price;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button btn_AllotCustomer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView gdvKS;
        private System.Windows.Forms.Label lbl_FinalPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Discount;
        private System.Windows.Forms.Label label14;
    }
}
