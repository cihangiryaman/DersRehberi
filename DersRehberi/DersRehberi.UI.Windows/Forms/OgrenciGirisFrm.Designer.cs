
namespace DersRehberi.UI.Windows.Forms
{
    partial class OgrenciGirisFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciGirisFrm));
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.xuıCustomToolstrip1 = new XanderUI.XUICustomToolstrip();
            this.kapatbtn = new System.Windows.Forms.ToolStripButton();
            this.maximizebtn = new System.Windows.Forms.ToolStripButton();
            this.minimizebtn = new System.Windows.Forms.ToolStripButton();
            this.geribtn = new System.Windows.Forms.ToolStripButton();
            this.okulNotxt = new ns1.BunifuMaterialTextbox();
            this.kayitbtn = new ns1.BunifuThinButton2();
            this.sifretxt = new ns1.BunifuMaterialTextbox();
            this.sifremiUnuttumlnklbl = new System.Windows.Forms.LinkLabel();
            this.girisbtn = new ns1.BunifuThinButton2();
            this.bunifuGradientPanel1.SuspendLayout();
            this.xuıCustomToolstrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.xuıCustomToolstrip1);
            this.bunifuGradientPanel1.Controls.Add(this.okulNotxt);
            this.bunifuGradientPanel1.Controls.Add(this.kayitbtn);
            this.bunifuGradientPanel1.Controls.Add(this.sifretxt);
            this.bunifuGradientPanel1.Controls.Add(this.sifremiUnuttumlnklbl);
            this.bunifuGradientPanel1.Controls.Add(this.girisbtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(777, 445);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // xuıCustomToolstrip1
            // 
            this.xuıCustomToolstrip1.BackColor = System.Drawing.Color.Transparent;
            this.xuıCustomToolstrip1.BorderColor = System.Drawing.Color.Transparent;
            this.xuıCustomToolstrip1.ForeColor = System.Drawing.Color.Black;
            this.xuıCustomToolstrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.xuıCustomToolstrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatbtn,
            this.maximizebtn,
            this.minimizebtn,
            this.geribtn});
            this.xuıCustomToolstrip1.Location = new System.Drawing.Point(0, 0);
            this.xuıCustomToolstrip1.Name = "xuıCustomToolstrip1";
            this.xuıCustomToolstrip1.Size = new System.Drawing.Size(777, 25);
            this.xuıCustomToolstrip1.TabIndex = 8;
            this.xuıCustomToolstrip1.Text = "xuıCustomToolstrip1";
            // 
            // kapatbtn
            // 
            this.kapatbtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.kapatbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kapatbtn.Image = global::DersRehberi.UI.Windows.Properties.Resources.icons8_close_window_48px;
            this.kapatbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kapatbtn.Name = "kapatbtn";
            this.kapatbtn.Size = new System.Drawing.Size(23, 22);
            this.kapatbtn.Text = "toolStripButton1";
            // 
            // maximizebtn
            // 
            this.maximizebtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maximizebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maximizebtn.Image = global::DersRehberi.UI.Windows.Properties.Resources.maximize_window_30px;
            this.maximizebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maximizebtn.Name = "maximizebtn";
            this.maximizebtn.Size = new System.Drawing.Size(23, 22);
            this.maximizebtn.Text = "toolStripButton1";
            // 
            // minimizebtn
            // 
            this.minimizebtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.minimizebtn.Image = global::DersRehberi.UI.Windows.Properties.Resources.minimize_window_30px;
            this.minimizebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(23, 22);
            this.minimizebtn.Text = "toolStripButton1";
            // 
            // geribtn
            // 
            this.geribtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.geribtn.Image = global::DersRehberi.UI.Windows.Properties.Resources.back_64px;
            this.geribtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.geribtn.Name = "geribtn";
            this.geribtn.Size = new System.Drawing.Size(23, 22);
            this.geribtn.Text = "toolStripButton4";
            this.geribtn.Click += new System.EventHandler(this.geribtn_Click);
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
            this.okulNotxt.Location = new System.Drawing.Point(203, 102);
            this.okulNotxt.Margin = new System.Windows.Forms.Padding(4);
            this.okulNotxt.Name = "okulNotxt";
            this.okulNotxt.Size = new System.Drawing.Size(357, 44);
            this.okulNotxt.TabIndex = 7;
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
            this.kayitbtn.Location = new System.Drawing.Point(203, 294);
            this.kayitbtn.Margin = new System.Windows.Forms.Padding(5);
            this.kayitbtn.Name = "kayitbtn";
            this.kayitbtn.Size = new System.Drawing.Size(166, 49);
            this.kayitbtn.TabIndex = 6;
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
            this.sifretxt.Location = new System.Drawing.Point(203, 195);
            this.sifretxt.Margin = new System.Windows.Forms.Padding(4);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(357, 44);
            this.sifretxt.TabIndex = 5;
            this.sifretxt.Text = "Şifre";
            this.sifretxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sifremiUnuttumlnklbl
            // 
            this.sifremiUnuttumlnklbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifremiUnuttumlnklbl.AutoSize = true;
            this.sifremiUnuttumlnklbl.BackColor = System.Drawing.Color.Transparent;
            this.sifremiUnuttumlnklbl.LinkColor = System.Drawing.Color.Firebrick;
            this.sifremiUnuttumlnklbl.Location = new System.Drawing.Point(479, 252);
            this.sifremiUnuttumlnklbl.Name = "sifremiUnuttumlnklbl";
            this.sifremiUnuttumlnklbl.Size = new System.Drawing.Size(81, 13);
            this.sifremiUnuttumlnklbl.TabIndex = 3;
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
            this.girisbtn.BackColor = System.Drawing.Color.Transparent;
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
            this.girisbtn.Location = new System.Drawing.Point(390, 294);
            this.girisbtn.Margin = new System.Windows.Forms.Padding(5);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(170, 49);
            this.girisbtn.TabIndex = 2;
            this.girisbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // OgrenciGirisFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 445);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciGirisFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisFrm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.xuıCustomToolstrip1.ResumeLayout(false);
            this.xuıCustomToolstrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.LinkLabel sifremiUnuttumlnklbl;
        private ns1.BunifuThinButton2 girisbtn;
        private ns1.BunifuMaterialTextbox okulNotxt;
        private ns1.BunifuThinButton2 kayitbtn;
        private ns1.BunifuMaterialTextbox sifretxt;
        private XanderUI.XUICustomToolstrip xuıCustomToolstrip1;
        private System.Windows.Forms.ToolStripButton kapatbtn;
        private System.Windows.Forms.ToolStripButton maximizebtn;
        private System.Windows.Forms.ToolStripButton minimizebtn;
        private System.Windows.Forms.ToolStripButton geribtn;
    }
}