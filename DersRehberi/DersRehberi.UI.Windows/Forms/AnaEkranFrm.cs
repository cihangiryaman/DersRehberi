using DersRehberi.UI.Windows.UserControls;
using System;
using System.Windows.Forms;

namespace DersRehberi.UI.Windows.Forms
{
    public partial class AnaEkranFrm : Form
    {
        public AnaEkranFrm()
        {
            InitializeComponent();
        }


        private void DuyuruBoyutAyarlama()
        {
            foreach (Control control in duyurularflwpnl.Controls)
            {
                control.Width = duyurularflwpnl.Width - 20;
            }
        }

        private void kapatbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizebtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void AnaEkranFrm_Load(object sender, EventArgs e)
        {
            DuyuruUC duyuruUC = new DuyuruUC();
            duyurularflwpnl.Controls.Add(duyuruUC);
            DuyuruBoyutAyarlama();
        }

        private void duyurularflwpnl_SizeChanged(object sender, EventArgs e)
        {
            DuyuruBoyutAyarlama();
        }

        private void kapatAccstmpctrbx_Click(object sender, EventArgs e)
        {

        }

        private void ogrenciGirisbtn_Click(object sender, EventArgs e)
        {
            OgrenciGirisFrm frm = new OgrenciGirisFrm();
            frm.ParentFrm = this;
            Hide();
            frm.Show();
        }
    }
}
