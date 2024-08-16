namespace GUI_QLTX
{
    partial class TimXe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btTimXe = new System.Windows.Forms.Button();
            this.txtGiaCuoi = new System.Windows.Forms.TextBox();
            this.txtGiaDau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbThuongHieu = new System.Windows.Forms.ComboBox();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fpDanhSachXe = new System.Windows.Forms.FlowLayoutPanel();
            this.btThemXe = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1040, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Xe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 159);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 162);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(607, 100);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.dtNgayKetThuc);
            this.panel4.Controls.Add(this.dtNgayBatDau);
            this.panel4.Controls.Add(this.dtNgayTra);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(704, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 156);
            this.panel4.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(3, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 33);
            this.label11.TabIndex = 33;
            this.label11.Text = "-Ngày thuê:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(116, 100);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(181, 26);
            this.dtNgayKetThuc.TabIndex = 34;
            this.dtNgayKetThuc.ValueChanged += new System.EventHandler(this.dtNgayKetThuc_ValueChanged);
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.Location = new System.Drawing.Point(116, 59);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(181, 26);
            this.dtNgayBatDau.TabIndex = 34;
            this.dtNgayBatDau.ValueChanged += new System.EventHandler(this.dtNgayBatDau_ValueChanged);
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTra.Location = new System.Drawing.Point(389, 61);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(181, 26);
            this.dtNgayTra.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(3, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 33);
            this.label12.TabIndex = 32;
            this.label12.Text = "-Ngày trả:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(360, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(246, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thông tin xe";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btTimXe);
            this.panel3.Controls.Add(this.txtGiaCuoi);
            this.panel3.Controls.Add(this.txtGiaDau);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(361, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 156);
            this.panel3.TabIndex = 0;
            // 
            // btTimXe
            // 
            this.btTimXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btTimXe.ForeColor = System.Drawing.Color.Black;
            this.btTimXe.Location = new System.Drawing.Point(104, 100);
            this.btTimXe.Name = "btTimXe";
            this.btTimXe.Size = new System.Drawing.Size(132, 42);
            this.btTimXe.TabIndex = 2;
            this.btTimXe.Text = "Tìm Xe";
            this.btTimXe.UseVisualStyleBackColor = false;
            this.btTimXe.Click += new System.EventHandler(this.btTimXe_Click);
            // 
            // txtGiaCuoi
            // 
            this.txtGiaCuoi.Location = new System.Drawing.Point(177, 66);
            this.txtGiaCuoi.Name = "txtGiaCuoi";
            this.txtGiaCuoi.Size = new System.Drawing.Size(120, 26);
            this.txtGiaCuoi.TabIndex = 1;
            // 
            // txtGiaDau
            // 
            this.txtGiaDau.Location = new System.Drawing.Point(32, 66);
            this.txtGiaDau.Name = "txtGiaDau";
            this.txtGiaDau.Size = new System.Drawing.Size(118, 26);
            this.txtGiaDau.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(333, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khoảng giá";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(191, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Đến khoảng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(156, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(28, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Từ khoảng";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbThuongHieu);
            this.panel2.Controls.Add(this.cbLoaiXe);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 156);
            this.panel2.TabIndex = 0;
            // 
            // cbThuongHieu
            // 
            this.cbThuongHieu.FormattingEnabled = true;
            this.cbThuongHieu.Location = new System.Drawing.Point(146, 97);
            this.cbThuongHieu.Name = "cbThuongHieu";
            this.cbThuongHieu.Size = new System.Drawing.Size(137, 28);
            this.cbThuongHieu.TabIndex = 2;
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Location = new System.Drawing.Point(146, 52);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(137, 28);
            this.cbLoaiXe.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thương Hiệu ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại Xe";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(351, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin xe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fpDanhSachXe
            // 
            this.fpDanhSachXe.AutoScroll = true;
            this.fpDanhSachXe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fpDanhSachXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpDanhSachXe.Location = new System.Drawing.Point(0, 202);
            this.fpDanhSachXe.Name = "fpDanhSachXe";
            this.fpDanhSachXe.Size = new System.Drawing.Size(1040, 415);
            this.fpDanhSachXe.TabIndex = 3;
            // 
            // btThemXe
            // 
            this.btThemXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemXe.ForeColor = System.Drawing.Color.Black;
            this.btThemXe.Location = new System.Drawing.Point(888, 6);
            this.btThemXe.Name = "btThemXe";
            this.btThemXe.Size = new System.Drawing.Size(114, 37);
            this.btThemXe.TabIndex = 4;
            this.btThemXe.Text = "Thêm Xe";
            this.btThemXe.UseVisualStyleBackColor = true;
            this.btThemXe.Click += new System.EventHandler(this.btThemXe_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btThemXe);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 617);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1040, 43);
            this.panel5.TabIndex = 5;
            // 
            // TimXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1040, 666);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.fpDanhSachXe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TimXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TimXe";
            this.Load += new System.EventHandler(this.TimXe_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbThuongHieu;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.TextBox txtGiaDau;
        private System.Windows.Forms.TextBox txtGiaCuoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btTimXe;
        private System.Windows.Forms.FlowLayoutPanel fpDanhSachXe;
        private System.Windows.Forms.Button btThemXe;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
    }
}