using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using BUS_QLTX;

namespace QLThuXe
{
    public partial class TimXe : UserControl
    {
        BUS_LoaiXe busqltx = new BUS_LoaiXe();
        ThueXe tx;
        public TimXe()
        {
            InitializeComponent();
        }

        private void TimXe_Load(object sender, EventArgs e)
        {
            DataTable dsloaixe = busqltx.layLoaiXe();
            cbLoaiXe.Items.Clear();
            foreach (var item in dsloaixe.Rows)
            {
        
            }
        }


        private void btDatXe_Click(object sender, EventArgs e)
        {
            tx = new ThueXe();
            tx.ShowDialog();
        }

        private void cbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fTrangChu1_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void itemXe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
