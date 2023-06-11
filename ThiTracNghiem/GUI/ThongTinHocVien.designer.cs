namespace ThiTracNghiem.GUI
{
    partial class ThongTinHocVien
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
            this.lbl_thongtinsinhvien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMonThi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDeThi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLamBai = new System.Windows.Forms.Button();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_thongtinsinhvien
            // 
            this.lbl_thongtinsinhvien.AutoSize = true;
            this.lbl_thongtinsinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_thongtinsinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_thongtinsinhvien.Location = new System.Drawing.Point(3, 0);
            this.lbl_thongtinsinhvien.Name = "lbl_thongtinsinhvien";
            this.lbl_thongtinsinhvien.Size = new System.Drawing.Size(174, 58);
            this.lbl_thongtinsinhvien.TabIndex = 0;
            this.lbl_thongtinsinhvien.Text = "Mã số học viên";
            this.lbl_thongtinsinhvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 58);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbMonThi
            // 
            this.cbMonThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMonThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMonThi.FormattingEnabled = true;
            this.cbMonThi.Location = new System.Drawing.Point(183, 185);
            this.cbMonThi.Name = "cbMonThi";
            this.cbMonThi.Size = new System.Drawing.Size(313, 37);
            this.cbMonThi.TabIndex = 3;
            this.cbMonThi.SelectedIndexChanged += new System.EventHandler(this.cbMonThi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(502, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giới tính";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(502, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 58);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 60);
            this.label5.TabIndex = 6;
            this.label5.Text = "Môn thi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMaHV, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHoTen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDiaChi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_thongtinsinhvien, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSDT, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtGioiTinh, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbMonThi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbDeThi, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLop, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 124);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 234);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // txtMaHV
            // 
            this.txtMaHV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaHV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHV.Location = new System.Drawing.Point(183, 12);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.ReadOnly = true;
            this.txtMaHV.Size = new System.Drawing.Size(313, 34);
            this.txtMaHV.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTen.Location = new System.Drawing.Point(183, 70);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(313, 34);
            this.txtHoTen.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(183, 128);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(313, 34);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(682, 128);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(313, 34);
            this.txtSDT.TabIndex = 14;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGioiTinh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGioiTinh.Location = new System.Drawing.Point(682, 70);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(313, 34);
            this.txtGioiTinh.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(502, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 60);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đề";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbDeThi
            // 
            this.cbDeThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDeThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDeThi.FormattingEnabled = true;
            this.cbDeThi.Location = new System.Drawing.Point(682, 185);
            this.cbDeThi.Name = "cbDeThi";
            this.cbDeThi.Size = new System.Drawing.Size(313, 37);
            this.cbDeThi.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(502, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 58);
            this.label8.TabIndex = 1;
            this.label8.Text = "Lớp";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLop
            // 
            this.txtLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLop.Location = new System.Drawing.Point(682, 12);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(313, 34);
            this.txtLop.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(294, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(436, 44);
            this.label6.TabIndex = 10;
            this.label6.Text = "THÔNG TIN HỌC VIÊN";
            // 
            // btnLamBai
            // 
            this.btnLamBai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamBai.Location = new System.Drawing.Point(622, 376);
            this.btnLamBai.Name = "btnLamBai";
            this.btnLamBai.Size = new System.Drawing.Size(133, 51);
            this.btnLamBai.TabIndex = 11;
            this.btnLamBai.Text = "LÀM BÀI";
            this.btnLamBai.UseVisualStyleBackColor = true;
            this.btnLamBai.Click += new System.EventHandler(this.btnLamBai_Click);
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemKetQua.Location = new System.Drawing.Point(364, 376);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(123, 51);
            this.btnXemKetQua.TabIndex = 12;
            this.btnXemKetQua.Text = "XEM KẾT QUẢ";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ThiTracNghiem.Properties.Resources.exams;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(535, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 51);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ThiTracNghiem.Properties.Resources.exam_results;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(263, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 51);
            this.panel1.TabIndex = 13;
            // 
            // ThongTinHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.btnLamBai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ThongTinHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN SINH VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThongTinHocVien_FormClosing);
            this.Load += new System.EventHandler(this.ThongTinHocVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_thongtinsinhvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMonThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLamBai;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDeThi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLop;
    }
}