using DersRehberi.BLL.Class;
using System;
using System.Windows.Forms;

namespace DersRehberi.UI.Windows.Forms
{
    public partial class OgrenciGirisFrm : Form
    {
        public OgrenciGirisFrm()
        {
            InitializeComponent();
        }

        public Form ParentFrm { get; set; }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            OgrenciManager manager = new OgrenciManager();
            manager.Get(o => o.OkulNo == okulNotxt.Text && o.Kisiler.Sifre == sifretxt.Text);
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            Close();
            ParentFrm.Show();
        }
    }
}
