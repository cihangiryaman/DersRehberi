using DersRehberi.BLL.Class;
using System;
using System.Windows.Forms;

namespace DersRehberi.UI.Windows.UserControls
{
    public partial class OgrenciGirisUC : UserControl
    {
        public OgrenciGirisUC()
        {
            InitializeComponent();
        }

        private void OgrenciGirisUC_Load(object sender, EventArgs e)
        {
            OgrenciManager manager = new OgrenciManager();
            manager.Get(o => o.OkulNo == okulNotxt.Text && o.Kisiler.Sifre == sifretxt.Text);
        }
    }
}
