using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        public FormChinh(string loai)
        {
            try
            {
                if (loai == "DG")
                {
                    //mnuSach.Visible = mnuHoatdong.Visible = true;
                }
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            

        }
        private void FormChinh_Load(object sender, EventArgs e)
        {
            tabs.Controls.Remove(tabPage2);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuenMatKhau fr = new QuenMatKhau();
            tabpage.Text = "Quen Mat Khau";
            fr.TopLevel = false;
            fr.Visible = true;
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            tabs.TabPages[0].Controls.Add(fr);
        }

        private void FormChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mniThongtin_Click(object sender, EventArgs e)
        {

        }
    }
}
