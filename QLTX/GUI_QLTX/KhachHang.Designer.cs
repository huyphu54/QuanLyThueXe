namespace GUI_QLTX
{
    partial class KhachHang
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgKhachHang = new System.Windows.Forms.DataGridView();
            this.btTimKH = new System.Windows.Forms.Button();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtSoDienThoaiKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btThemKH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgDonHang = new System.Windows.Forms.DataGridView();
            this.lbNameUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKhachHang
            // 
            this.dgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKhachHang.Location = new System.Drawing.Point(12, 202);
            this.dgKhachHang.Name = "dgKhachHang";
            this.dgKhachHang.RowHeadersWidth = 62;
            this.dgKhachHang.RowTemplate.Height = 28;
            this.dgKhachHang.Size = new System.Drawing.Size(776, 258);
            this.dgKhachHang.TabIndex = 0;
            this.dgKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKhachHang_CellContentClick);
            this.dgKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKhachHang_CellContentClick);
            // 
            // btTimKH
            // 
            this.btTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKH.Location = new System.Drawing.Point(537, 12);
            this.btTimKH.Name = "btTimKH";
            this.btTimKH.Size = new System.Drawing.Size(181, 37);
            this.btTimKH.TabIndex = 37;
            this.btTimKH.Text = "Tìm khách hàng";
            this.btTimKH.UseVisualStyleBackColor = true;
            this.btTimKH.Click += new System.EventHandler(this.btTimKH_Click);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(537, 85);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(181, 30);
            this.txtCCCD.TabIndex = 34;
            // 
            // txtSoDienThoaiKH
            // 
            this.txtSoDienThoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoaiKH.Location = new System.Drawing.Point(179, 83);
            this.txtSoDienThoaiKH.Name = "txtSoDienThoaiKH";
            this.txtSoDienThoaiKH.Size = new System.Drawing.Size(181, 30);
            this.txtSoDienThoaiKH.TabIndex = 35;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(179, 43);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(181, 30);
            this.txtTenKH.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(33, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 33);
            this.label2.TabIndex = 31;
            this.label2.Text = "-Họ Tên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(33, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 33);
            this.label5.TabIndex = 32;
            this.label5.Text = "-Số điện thoại:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(404, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 33);
            this.label6.TabIndex = 33;
            this.label6.Text = "-CCCD:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btThemKH
            // 
            this.btThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemKH.Location = new System.Drawing.Point(596, 138);
            this.btThemKH.Name = "btThemKH";
            this.btThemKH.Size = new System.Drawing.Size(181, 37);
            this.btThemKH.TabIndex = 37;
            this.btThemKH.Text = "Thêm Khách Hàng";
            this.btThemKH.UseVisualStyleBackColor = true;
            this.btThemKH.Click += new System.EventHandler(this.btThemKH_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(392, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 37);
            this.button1.TabIndex = 37;
            this.button1.Text = "Sửa Khách Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btThemKH_Click);
            // 
            // dgDonHang
            // 
            this.dgDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDonHang.Location = new System.Drawing.Point(821, 52);
            this.dgDonHang.Name = "dgDonHang";
            this.dgDonHang.RowHeadersWidth = 62;
            this.dgDonHang.RowTemplate.Height = 28;
            this.dgDonHang.Size = new System.Drawing.Size(396, 408);
            this.dgDonHang.TabIndex = 38;
            // 
            // lbNameUser
            // 
            this.lbNameUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNameUser.AutoSize = true;
            this.lbNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameUser.Location = new System.Drawing.Point(937, 24);
            this.lbNameUser.Name = "lbNameUser";
            this.lbNameUser.Size = new System.Drawing.Size(221, 25);
            this.lbNameUser.TabIndex = 39;
            this.lbNameUser.Text = "Danh Sách Đơn Hàng";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 472);
            this.Controls.Add(this.lbNameUser);
            this.Controls.Add(this.dgDonHang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btThemKH);
            this.Controls.Add(this.btTimKH);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtSoDienThoaiKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgKhachHang);
            this.Name = "KhachHang";
            this.Text = "Khách_Hàng";
            this.Load += new System.EventHandler(this.Khách_Hàng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgKhachHang;
        private System.Windows.Forms.Button btTimKH;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtSoDienThoaiKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btThemKH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgDonHang;
        private System.Windows.Forms.Label lbNameUser;
    }
}