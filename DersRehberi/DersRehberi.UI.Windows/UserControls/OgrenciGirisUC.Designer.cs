
namespace DersRehberi.UI.Windows.UserControls
{
    partial class OgrenciGirisUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciGirisUC));
            this.okulNotxt = new ns1.BunifuMaterialTextbox();
            this.kayitbtn = new ns1.BunifuThinButton2();
            this.sifretxt = new ns1.BunifuMaterialTextbox();
            this.sifremiUnuttumlnklbl = new System.Windows.Forms.LinkLabel();
            this.girisbtn = new ns1.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // okulNotxt
            // 
            this.okulNotxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okulNotxt.BackColor = System.Drawing.Color.White;
            this.okulNotxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.okulNotxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.okulNotxt.ForeColor = System.Drawing.Color.Gray;
            this.okulNotxt.HintForeColor = System.Drawing.Color.Empty;
            this.okulNotxt.HintText = "";
            this.okulNotxt.isPassword = false;
            this.okulNotxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.okulNotxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.okulNotxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.okulNotxt.LineThickness = 3;
            this.okulNotxt.Location = new System.Drawing.Point(194, 98);
            this.okulNotxt.Margin = new System.Windows.Forms.Padding(4);
            this.okulNotxt.Name = "okulNotxt";
            this.okulNotxt.Size = new System.Drawing.Size(357, 44);
            this.okulNotxt.TabIndex = 12;
            this.okulNotxt.Text = "Okul Numarası";
            this.okulNotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kayitbtn
            // 
            this.kayitbtn.ActiveBorderThickness = 1;
            this.kayitbtn.ActiveCornerRadius = 20;
            this.kayitbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.kayitbtn.ActiveForecolor = System.Drawing.Color.White;
            this.kayitbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.kayitbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kayitbtn.BackColor = System.Drawing.Color.Transparent;
            this.kayitbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kayitbtn.BackgroundImage")));
            this.kayitbtn.ButtonText = "Kayıt Ol";
            this.kayitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayitbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.kayitbtn.IdleBorderThickness = 1;
            this.kayitbtn.IdleCornerRadius = 20;
            this.kayitbtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.kayitbtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.kayitbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.kayitbtn.Location = new System.Drawing.Point(194, 290);
            this.kayitbtn.Margin = new System.Windows.Forms.Padding(5);
            this.kayitbtn.Name = "kayitbtn";
            this.kayitbtn.Size = new System.Drawing.Size(166, 49);
            this.kayitbtn.TabIndex = 11;
            this.kayitbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sifretxt
            // 
            this.sifretxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifretxt.BackColor = System.Drawing.Color.White;
            this.sifretxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifretxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sifretxt.ForeColor = System.Drawing.Color.Gray;
            this.sifretxt.HintForeColor = System.Drawing.Color.Empty;
            this.sifretxt.HintText = "";
            this.sifretxt.isPassword = false;
            this.sifretxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sifretxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.sifretxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sifretxt.LineThickness = 3;
            this.sifretxt.Location = new System.Drawing.Point(194, 191);
            this.sifretxt.Margin = new System.Windows.Forms.Padding(4);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(357, 44);
            this.sifretxt.TabIndex = 10;
            this.sifretxt.Text = "Şifre";
            this.sifretxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sifremiUnuttumlnklbl
            // 
            this.sifremiUnuttumlnklbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifremiUnuttumlnklbl.AutoSize = true;
            this.sifremiUnuttumlnklbl.BackColor = System.Drawing.Color.Transparent;
            this.sifremiUnuttumlnklbl.LinkColor = System.Drawing.Color.Firebrick;
            this.sifremiUnuttumlnklbl.Location = new System.Drawing.Point(470, 248);
            this.sifremiUnuttumlnklbl.Name = "sifremiUnuttumlnklbl";
            this.sifremiUnuttumlnklbl.Size = new System.Drawing.Size(81, 13);
            this.sifremiUnuttumlnklbl.TabIndex = 9;
            this.sifremiUnuttumlnklbl.TabStop = true;
            this.sifremiUnuttumlnklbl.Text = "Şifremi Unuttum";
            // 
            // girisbtn
            // 
            this.girisbtn.ActiveBorderThickness = 1;
            this.girisbtn.ActiveCornerRadius = 20;
            this.girisbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.girisbtn.ActiveForecolor = System.Drawing.Color.White;
            this.girisbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.girisbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.girisbtn.BackColor = System.Drawing.SystemColors.Control;
            this.girisbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("girisbtn.BackgroundImage")));
            this.girisbtn.ButtonText = "Giriş Yap";
            this.girisbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.girisbtn.IdleBorderThickness = 1;
            this.girisbtn.IdleCornerRadius = 20;
            this.girisbtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.girisbtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.girisbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.girisbtn.Location = new System.Drawing.Point(381, 290);
            this.girisbtn.Margin = new System.Windows.Forms.Padding(5);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(170, 49);
            this.girisbtn.TabIndex = 8;
            this.girisbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciGirisUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.okulNotxt);
            this.Controls.Add(this.kayitbtn);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.sifremiUnuttumlnklbl);
            this.Controls.Add(this.girisbtn);
            this.Name = "OgrenciGirisUC";
            this.Size = new System.Drawing.Size(744, 437);
            this.Load += new System.EventHandler(this.OgrenciGirisUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuMaterialTextbox okulNotxt;
        private ns1.BunifuThinButton2 kayitbtn;
        private ns1.BunifuMaterialTextbox sifretxt;
        private System.Windows.Forms.LinkLabel sifremiUnuttumlnklbl;
        private ns1.BunifuThinButton2 girisbtn;
    }
}
