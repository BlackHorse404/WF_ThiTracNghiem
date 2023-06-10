namespace ThiTracNghiem.GUI
{
    partial class XemKetQua
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_ketqua = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_QuayVe = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ketqua)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.237817F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.76218F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_QuayVe, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1026, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.dgv_ketqua);
            this.panel1.Location = new System.Drawing.Point(3, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 465);
            this.panel1.TabIndex = 0;
            // 
            // dgv_ketqua
            // 
            this.dgv_ketqua.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ketqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ketqua.Location = new System.Drawing.Point(3, 3);
            this.dgv_ketqua.Name = "dgv_ketqua";
            this.dgv_ketqua.RowHeadersWidth = 51;
            this.dgv_ketqua.RowTemplate.Height = 24;
            this.dgv_ketqua.Size = new System.Drawing.Size(1014, 465);
            this.dgv_ketqua.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(67, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 63);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(266, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "KÊT QUẢ BÀI LÀM";
            // 
            // pnl_QuayVe
            // 
            this.pnl_QuayVe.BackgroundImage = global::ThiTracNghiem.Properties.Resources.back_arrow;
            this.pnl_QuayVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_QuayVe.Location = new System.Drawing.Point(3, 3);
            this.pnl_QuayVe.Name = "pnl_QuayVe";
            this.pnl_QuayVe.Size = new System.Drawing.Size(58, 63);
            this.pnl_QuayVe.TabIndex = 2;
            // 
            // XemKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "XemKetQua";
            this.Text = "XemKetQua";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ketqua)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_ketqua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_QuayVe;
    }
}