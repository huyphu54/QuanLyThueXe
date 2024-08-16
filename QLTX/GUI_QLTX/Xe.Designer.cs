namespace GUI_QLTX
{
    partial class Xe
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
            this.lbLoaiXe = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbThuongHieu = new System.Windows.Forms.Label();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.cbThuongHieu = new System.Windows.Forms.ComboBox();
            this.btThemXe = new System.Windows.Forms.Button();
            this.picXe = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbBienSo = new System.Windows.Forms.Label();
            this.lbTenXe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbAC = new System.Windows.Forms.ComboBox();
            this.cbCamBien = new System.Windows.Forms.ComboBox();
            this.cbMayLanh = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLoaiXe
            // 
            this.lbLoaiXe.AutoSize = true;
            this.lbLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiXe.Location = new System.Drawing.Point(3, 67);
            this.lbLoaiXe.Name = "lbLoaiXe";
            this.lbLoaiXe.Size = new System.Drawing.Size(63, 20);
            this.lbLoaiXe.TabIndex = 1;
            this.lbLoaiXe.Text = "Loại Xe";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbLoaiXe);
            this.panel3.Controls.Add(this.lbThuongHieu);
            this.panel3.Controls.Add(this.cbLoaiXe);
            this.panel3.Controls.Add(this.cbThuongHieu);
            this.panel3.Location = new System.Drawing.Point(229, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 126);
            this.panel3.TabIndex = 13;
            // 
            // lbThuongHieu
            // 
            this.lbThuongHieu.AutoSize = true;
            this.lbThuongHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuongHieu.Location = new System.Drawing.Point(3, 13);
            this.lbThuongHieu.Name = "lbThuongHieu";
            this.lbThuongHieu.Size = new System.Drawing.Size(104, 20);
            this.lbThuongHieu.TabIndex = 1;
            this.lbThuongHieu.Text = "Thương Hiệu ";
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cbLoaiXe.Location = new System.Drawing.Point(12, 87);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(95, 28);
            this.cbLoaiXe.TabIndex = 2;
            // 
            // cbThuongHieu
            // 
            this.cbThuongHieu.FormattingEnabled = true;
            this.cbThuongHieu.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cbThuongHieu.Location = new System.Drawing.Point(12, 36);
            this.cbThuongHieu.Name = "cbThuongHieu";
            this.cbThuongHieu.Size = new System.Drawing.Size(95, 28);
            this.cbThuongHieu.TabIndex = 2;
            // 
            // btThemXe
            // 
            this.btThemXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btThemXe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btThemXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemXe.Location = new System.Drawing.Point(0, 351);
            this.btThemXe.Name = "btThemXe";
            this.btThemXe.Size = new System.Drawing.Size(620, 40);
            this.btThemXe.TabIndex = 9;
            this.btThemXe.Text = "Thêm Xe";
            this.btThemXe.UseVisualStyleBackColor = false;
            this.btThemXe.Click += new System.EventHandler(this.btThemXe_Click);
            // 
            // picXe
            // 
            this.picXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picXe.Image = global::GUI_QLTX.Properties.Resources.upload;
            this.picXe.Location = new System.Drawing.Point(21, 88);
            this.picXe.Name = "picXe";
            this.picXe.Size = new System.Drawing.Size(187, 188);
            this.picXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXe.TabIndex = 7;
            this.picXe.TabStop = false;
            this.picXe.Click += new System.EventHandler(this.picXe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cảm biến lùi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "AC";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.txtBienSo);
            this.panel1.Controls.Add(this.txtTenXe);
            this.panel1.Controls.Add(this.lbGia);
            this.panel1.Controls.Add(this.lbBienSo);
            this.panel1.Controls.Add(this.lbTenXe);
            this.panel1.Location = new System.Drawing.Point(229, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 116);
            this.panel1.TabIndex = 11;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(109, 44);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(152, 26);
            this.txtGia.TabIndex = 2;
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(109, 74);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(152, 26);
            this.txtBienSo.TabIndex = 2;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(109, 12);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(231, 26);
            this.txtTenXe.TabIndex = 2;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(8, 48);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(47, 20);
            this.lbGia.TabIndex = 1;
            this.lbGia.Text = "Giá: ";
            // 
            // lbBienSo
            // 
            this.lbBienSo.AutoSize = true;
            this.lbBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienSo.Location = new System.Drawing.Point(8, 80);
            this.lbBienSo.Name = "lbBienSo";
            this.lbBienSo.Size = new System.Drawing.Size(69, 20);
            this.lbBienSo.TabIndex = 1;
            this.lbBienSo.Text = "Biển số";
            // 
            // lbTenXe
            // 
            this.lbTenXe.AutoSize = true;
            this.lbTenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenXe.Location = new System.Drawing.Point(8, 15);
            this.lbTenXe.Name = "lbTenXe";
            this.lbTenXe.Size = new System.Drawing.Size(76, 20);
            this.lbTenXe.TabIndex = 1;
            this.lbTenXe.Text = "Tên Xe: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Máy lạnh ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tính năng";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbAC);
            this.panel2.Controls.Add(this.cbCamBien);
            this.panel2.Controls.Add(this.cbMayLanh);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(373, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 126);
            this.panel2.TabIndex = 12;
            // 
            // cbAC
            // 
            this.cbAC.FormattingEnabled = true;
            this.cbAC.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cbAC.Location = new System.Drawing.Point(116, 93);
            this.cbAC.Name = "cbAC";
            this.cbAC.Size = new System.Drawing.Size(79, 28);
            this.cbAC.TabIndex = 2;
            // 
            // cbCamBien
            // 
            this.cbCamBien.FormattingEnabled = true;
            this.cbCamBien.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cbCamBien.Location = new System.Drawing.Point(116, 60);
            this.cbCamBien.Name = "cbCamBien";
            this.cbCamBien.Size = new System.Drawing.Size(79, 28);
            this.cbCamBien.TabIndex = 2;
            // 
            // cbMayLanh
            // 
            this.cbMayLanh.FormattingEnabled = true;
            this.cbMayLanh.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cbMayLanh.Location = new System.Drawing.Point(116, 26);
            this.cbMayLanh.Name = "cbMayLanh";
            this.cbMayLanh.Size = new System.Drawing.Size(79, 28);
            this.cbMayLanh.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(0, 311);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(620, 40);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(620, 37);
            this.lbTieuDe.TabIndex = 16;
            this.lbTieuDe.Text = "label1";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 391);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btThemXe);
            this.Controls.Add(this.picXe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Xe";
            this.Text = "Xe";
            this.Load += new System.EventHandler(this.Xe_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLoaiXe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbThuongHieu;
        private System.Windows.Forms.Button btThemXe;
        private System.Windows.Forms.PictureBox picXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbBienSo;
        private System.Windows.Forms.Label lbTenXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.ComboBox cbAC;
        private System.Windows.Forms.ComboBox cbCamBien;
        private System.Windows.Forms.ComboBox cbMayLanh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.ComboBox cbThuongHieu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lbTieuDe;
    }
}