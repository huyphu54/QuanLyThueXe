namespace GUI_QLTX
{
    partial class XeUI
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
            this.lbTenXe = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbBienSo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAC = new System.Windows.Forms.Label();
            this.lbCamBien = new System.Windows.Forms.Label();
            this.lbMayLanh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThueXe = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbLoaiXe = new System.Windows.Forms.Label();
            this.lbThuongHieu = new System.Windows.Forms.Label();
            this.picXe = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXe)).BeginInit();
            this.SuspendLayout();
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
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(750, 100);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(117, 40);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lbGia);
            this.panel1.Controls.Add(this.lbBienSo);
            this.panel1.Controls.Add(this.lbTenXe);
            this.panel1.Location = new System.Drawing.Point(174, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 116);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbAC);
            this.panel2.Controls.Add(this.lbCamBien);
            this.panel2.Controls.Add(this.lbMayLanh);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(535, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 116);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cảm biến lùi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "AC";
            // 
            // lbAC
            // 
            this.lbAC.AutoSize = true;
            this.lbAC.Location = new System.Drawing.Point(140, 84);
            this.lbAC.Name = "lbAC";
            this.lbAC.Size = new System.Drawing.Size(29, 20);
            this.lbAC.TabIndex = 1;
            this.lbAC.Text = "Có";
            // 
            // lbCamBien
            // 
            this.lbCamBien.AutoSize = true;
            this.lbCamBien.Location = new System.Drawing.Point(140, 57);
            this.lbCamBien.Name = "lbCamBien";
            this.lbCamBien.Size = new System.Drawing.Size(29, 20);
            this.lbCamBien.TabIndex = 1;
            this.lbCamBien.Text = "Có";
            // 
            // lbMayLanh
            // 
            this.lbMayLanh.AutoSize = true;
            this.lbMayLanh.Location = new System.Drawing.Point(140, 31);
            this.lbMayLanh.Name = "lbMayLanh";
            this.lbMayLanh.Size = new System.Drawing.Size(29, 20);
            this.lbMayLanh.TabIndex = 1;
            this.lbMayLanh.Text = "Có";
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
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tính năng";
            // 
            // btThueXe
            // 
            this.btThueXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btThueXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThueXe.Location = new System.Drawing.Point(750, 17);
            this.btThueXe.Name = "btThueXe";
            this.btThueXe.Size = new System.Drawing.Size(117, 40);
            this.btThueXe.TabIndex = 3;
            this.btThueXe.Text = "Thuê xe";
            this.btThueXe.UseVisualStyleBackColor = false;
            this.btThueXe.Click += new System.EventHandler(this.btThueXe_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.Location = new System.Drawing.Point(750, 57);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(117, 40);
            this.btCapNhat.TabIndex = 3;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.UseVisualStyleBackColor = false;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbLoaiXe);
            this.panel3.Controls.Add(this.lbThuongHieu);
            this.panel3.Location = new System.Drawing.Point(401, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 115);
            this.panel3.TabIndex = 6;
            // 
            // lbLoaiXe
            // 
            this.lbLoaiXe.AutoSize = true;
            this.lbLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiXe.Location = new System.Drawing.Point(3, 58);
            this.lbLoaiXe.Name = "lbLoaiXe";
            this.lbLoaiXe.Size = new System.Drawing.Size(104, 20);
            this.lbLoaiXe.TabIndex = 1;
            this.lbLoaiXe.Text = "Thương Hiệu ";
            // 
            // lbThuongHieu
            // 
            this.lbThuongHieu.AutoSize = true;
            this.lbThuongHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuongHieu.Location = new System.Drawing.Point(3, 28);
            this.lbThuongHieu.Name = "lbThuongHieu";
            this.lbThuongHieu.Size = new System.Drawing.Size(104, 20);
            this.lbThuongHieu.TabIndex = 1;
            this.lbThuongHieu.Text = "Thương Hiệu ";
            // 
            // picXe
            // 
            this.picXe.Location = new System.Drawing.Point(19, 19);
            this.picXe.Name = "picXe";
            this.picXe.Size = new System.Drawing.Size(135, 116);
            this.picXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXe.TabIndex = 0;
            this.picXe.TabStop = false;
            // 
            // XeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btThueXe);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.picXe);
            this.Controls.Add(this.panel1);
            this.Name = "XeUI";
            this.Size = new System.Drawing.Size(887, 149);
            this.Load += new System.EventHandler(this.XeUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picXe;
        private System.Windows.Forms.Label lbTenXe;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbBienSo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAC;
        private System.Windows.Forms.Label lbCamBien;
        private System.Windows.Forms.Label lbMayLanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btThueXe;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbLoaiXe;
        private System.Windows.Forms.Label lbThuongHieu;
    }
}
