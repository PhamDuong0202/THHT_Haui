namespace vd1
{
    partial class Form_NV
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Tim = new System.Windows.Forms.Button();
            this.bt_Preview = new System.Windows.Forms.Button();
            this.datanhanvien = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datanhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(275, 44);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(90, 20);
            this.txt_manv.TabIndex = 3;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(276, 208);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(243, 20);
            this.txt_diachi.TabIndex = 4;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(275, 117);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(174, 20);
            this.txt_hoten.TabIndex = 5;
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(676, 46);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(89, 29);
            this.bt_Them.TabIndex = 6;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(676, 118);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(89, 29);
            this.bt_Sua.TabIndex = 7;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(676, 188);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(89, 29);
            this.bt_Xoa.TabIndex = 8;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Tim
            // 
            this.bt_Tim.Location = new System.Drawing.Point(676, 267);
            this.bt_Tim.Name = "bt_Tim";
            this.bt_Tim.Size = new System.Drawing.Size(89, 29);
            this.bt_Tim.TabIndex = 9;
            this.bt_Tim.Text = "Tìm";
            this.bt_Tim.UseVisualStyleBackColor = true;
            this.bt_Tim.Click += new System.EventHandler(this.bt_Tim_Click);
            // 
            // bt_Preview
            // 
            this.bt_Preview.Location = new System.Drawing.Point(676, 327);
            this.bt_Preview.Name = "bt_Preview";
            this.bt_Preview.Size = new System.Drawing.Size(89, 29);
            this.bt_Preview.TabIndex = 10;
            this.bt_Preview.Text = "Preview";
            this.bt_Preview.UseVisualStyleBackColor = true;
            // 
            // datanhanvien
            // 
            this.datanhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datanhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.hoten,
            this.diachi});
            this.datanhanvien.Location = new System.Drawing.Point(54, 327);
            this.datanhanvien.Name = "datanhanvien";
            this.datanhanvien.Size = new System.Drawing.Size(593, 200);
            this.datanhanvien.TabIndex = 11;
            this.datanhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datanhanvien_CellClick);
            // 
            // manv
            // 
            this.manv.HeaderText = "Mã NV";
            this.manv.Name = "manv";
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            this.hoten.Width = 200;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.Width = 250;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(276, 276);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(384, 20);
            this.txt_timkiem.TabIndex = 12;
            // 
            // Form_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 580);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.datanhanvien);
            this.Controls.Add(this.bt_Preview);
            this.Controls.Add(this.bt_Tim);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_NV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datanhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Tim;
        private System.Windows.Forms.Button bt_Preview;
        private System.Windows.Forms.DataGridView datanhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.TextBox txt_timkiem;
    }
}

