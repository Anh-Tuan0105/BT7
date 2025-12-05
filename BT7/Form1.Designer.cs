namespace BT7
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_De = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.cmb_khoa = new System.Windows.Forms.ComboBox();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_students = new System.Windows.Forms.DataGridView();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_numNam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_numNu = new System.Windows.Forms.TextBox();
            this.cmb_LocKhoa = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thông Tin Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_De);
            this.groupBox1.Controls.Add(this.btn_Up);
            this.groupBox1.Controls.Add(this.cmb_khoa);
            this.groupBox1.Controls.Add(this.txt_diem);
            this.groupBox1.Controls.Add(this.rb_nu);
            this.groupBox1.Controls.Add(this.rb_nam);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 431);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btn_De
            // 
            this.btn_De.Location = new System.Drawing.Point(232, 380);
            this.btn_De.Name = "btn_De";
            this.btn_De.Size = new System.Drawing.Size(85, 23);
            this.btn_De.TabIndex = 12;
            this.btn_De.Text = "Xóa";
            this.btn_De.UseVisualStyleBackColor = true;
            this.btn_De.Click += new System.EventHandler(this.btn_De_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Location = new System.Drawing.Point(121, 380);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(85, 23);
            this.btn_Up.TabIndex = 11;
            this.btn_Up.Text = "Thêm/Sửa";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // cmb_khoa
            // 
            this.cmb_khoa.FormattingEnabled = true;
            this.cmb_khoa.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmb_khoa.Location = new System.Drawing.Point(121, 322);
            this.cmb_khoa.Name = "cmb_khoa";
            this.cmb_khoa.Size = new System.Drawing.Size(214, 24);
            this.cmb_khoa.TabIndex = 10;
            // 
            // txt_diem
            // 
            this.txt_diem.Location = new System.Drawing.Point(121, 228);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(116, 22);
            this.txt_diem.TabIndex = 9;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(294, 151);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(42, 20);
            this.rb_nu.TabIndex = 8;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(121, 151);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(54, 20);
            this.rb_nam.TabIndex = 7;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(121, 82);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(322, 22);
            this.txt_hoten.TabIndex = 6;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(121, 29);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(231, 22);
            this.txt_ma.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chuyên Ngành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điểm TB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // dgv_students
            // 
            this.dgv_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv,
            this.hoten,
            this.gt,
            this.dtb,
            this.khoa});
            this.dgv_students.Location = new System.Drawing.Point(510, 66);
            this.dgv_students.MultiSelect = false;
            this.dgv_students.Name = "dgv_students";
            this.dgv_students.ReadOnly = true;
            this.dgv_students.RowHeadersWidth = 62;
            this.dgv_students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_students.Size = new System.Drawing.Size(542, 431);
            this.dgv_students.TabIndex = 2;
            this.dgv_students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_students_CellClick);
            this.dgv_students.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_students_CellContentClick);
            // 
            // mssv
            // 
            this.mssv.HeaderText = "MSSV";
            this.mssv.MinimumWidth = 8;
            this.mssv.Name = "mssv";
            this.mssv.ReadOnly = true;
            this.mssv.Width = 150;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.MinimumWidth = 8;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 150;
            // 
            // gt
            // 
            this.gt.HeaderText = "Giới Tính";
            this.gt.MinimumWidth = 8;
            this.gt.Name = "gt";
            this.gt.ReadOnly = true;
            this.gt.Width = 150;
            // 
            // dtb
            // 
            this.dtb.HeaderText = "ĐTB";
            this.dtb.MinimumWidth = 8;
            this.dtb.Name = "dtb";
            this.dtb.ReadOnly = true;
            this.dtb.Width = 150;
            // 
            // khoa
            // 
            this.khoa.HeaderText = "Khoa";
            this.khoa.MinimumWidth = 8;
            this.khoa.Name = "khoa";
            this.khoa.ReadOnly = true;
            this.khoa.Width = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(705, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tổng SV Nam";
            // 
            // txt_numNam
            // 
            this.txt_numNam.Location = new System.Drawing.Point(781, 518);
            this.txt_numNam.Name = "txt_numNam";
            this.txt_numNam.Size = new System.Drawing.Size(55, 20);
            this.txt_numNam.TabIndex = 6;
            this.txt_numNam.TextChanged += new System.EventHandler(this.txt_numNam_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(870, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nữ";
            // 
            // txt_numNu
            // 
            this.txt_numNu.Location = new System.Drawing.Point(907, 518);
            this.txt_numNu.Name = "txt_numNu";
            this.txt_numNu.Size = new System.Drawing.Size(55, 20);
            this.txt_numNu.TabIndex = 8;
            // 
            // cmb_LocKhoa
            // 
            this.cmb_LocKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_LocKhoa.FormattingEnabled = true;
            this.cmb_LocKhoa.Location = new System.Drawing.Point(510, 517);
            this.cmb_LocKhoa.Name = "cmb_LocKhoa";
            this.cmb_LocKhoa.Size = new System.Drawing.Size(157, 21);
            this.cmb_LocKhoa.TabIndex = 9;
            this.cmb_LocKhoa.SelectedIndexChanged += new System.EventHandler(this.cmb_LocKhoa_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 563);
            this.Controls.Add(this.cmb_LocKhoa);
            this.Controls.Add(this.txt_numNu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_numNam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_students);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_diem;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_khoa;
        private System.Windows.Forms.DataGridView dgv_students;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_numNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_numNu;
        private System.Windows.Forms.Button btn_De;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.ComboBox cmb_LocKhoa;
    }
}

