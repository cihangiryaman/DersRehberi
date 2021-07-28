
namespace DersRehberi.UI.Windows.UserControls
{
    partial class DuyuruUC
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
            this.duyurupctrbx = new XanderUI.XUICustomPictureBox();
            this.duyuruBasliklbl = new System.Windows.Forms.Label();
            this.duyuruIceriklbl = new System.Windows.Forms.Label();
            this.tarihlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // duyurupctrbx
            // 
            this.duyurupctrbx.Color1 = System.Drawing.Color.DodgerBlue;
            this.duyurupctrbx.Color2 = System.Drawing.Color.DodgerBlue;
            this.duyurupctrbx.FilterAlpha = 200;
            this.duyurupctrbx.FilterEnabled = false;
            this.duyurupctrbx.Image = global::DersRehberi.UI.Windows.Properties.Resources.Teknofest;
            this.duyurupctrbx.IsElipse = true;
            this.duyurupctrbx.IsParallax = false;
            this.duyurupctrbx.Location = new System.Drawing.Point(20, 17);
            this.duyurupctrbx.Name = "duyurupctrbx";
            this.duyurupctrbx.Size = new System.Drawing.Size(88, 86);
            this.duyurupctrbx.TabIndex = 0;
            this.duyurupctrbx.Text = "duyurupctrbx";
            // 
            // duyuruBasliklbl
            // 
            this.duyuruBasliklbl.AutoSize = true;
            this.duyuruBasliklbl.BackColor = System.Drawing.Color.Transparent;
            this.duyuruBasliklbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duyuruBasliklbl.ForeColor = System.Drawing.Color.Black;
            this.duyuruBasliklbl.Location = new System.Drawing.Point(143, 17);
            this.duyuruBasliklbl.Name = "duyuruBasliklbl";
            this.duyuruBasliklbl.Size = new System.Drawing.Size(177, 18);
            this.duyuruBasliklbl.TabIndex = 1;
            this.duyuruBasliklbl.Text = "Teknofest 2020 Başladı !";
            // 
            // duyuruIceriklbl
            // 
            this.duyuruIceriklbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.duyuruIceriklbl.BackColor = System.Drawing.Color.Transparent;
            this.duyuruIceriklbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duyuruIceriklbl.ForeColor = System.Drawing.Color.Black;
            this.duyuruIceriklbl.Location = new System.Drawing.Point(143, 57);
            this.duyuruIceriklbl.Name = "duyuruIceriklbl";
            this.duyuruIceriklbl.Size = new System.Drawing.Size(285, 46);
            this.duyuruIceriklbl.TabIndex = 2;
            this.duyuruIceriklbl.Text = "Teknofest 2020 Gaziantepte başladı";
            // 
            // tarihlbl
            // 
            this.tarihlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tarihlbl.AutoSize = true;
            this.tarihlbl.BackColor = System.Drawing.Color.Transparent;
            this.tarihlbl.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihlbl.ForeColor = System.Drawing.Color.Black;
            this.tarihlbl.Location = new System.Drawing.Point(374, 0);
            this.tarihlbl.Name = "tarihlbl";
            this.tarihlbl.Size = new System.Drawing.Size(70, 17);
            this.tarihlbl.TabIndex = 3;
            this.tarihlbl.Text = "15/05/2021";
            // 
            // DuyuruUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tarihlbl);
            this.Controls.Add(this.duyuruIceriklbl);
            this.Controls.Add(this.duyuruBasliklbl);
            this.Controls.Add(this.duyurupctrbx);
            this.Name = "DuyuruUC";
            this.Size = new System.Drawing.Size(443, 120);
            this.Load += new System.EventHandler(this.DuyuruUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public XanderUI.XUICustomPictureBox duyurupctrbx;
        public System.Windows.Forms.Label duyuruBasliklbl;
        public System.Windows.Forms.Label duyuruIceriklbl;
        public System.Windows.Forms.Label tarihlbl;
    }
}
