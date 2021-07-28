
namespace DersRehberi.UI.Windows.Forms
{
    partial class AnaEkranFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkranFrm));
            this.solslidingpnl = new XanderUI.XUISlidingPanel();
            this.kapatAccstmpctrbx = new XanderUI.XUICustomPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butonTutucuflwpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.ogrenciGirisbtn = new XanderUI.XUIButton();
            this.ogretmenGirisbtn = new XanderUI.XUIButton();
            this.veliGiribtn = new XanderUI.XUIButton();
            this.ortagradientpnl = new ns1.BunifuGradientPanel();
            this.duyurularflwpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.xuıCustomPictureBox1 = new XanderUI.XUICustomPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xuıCustomToolstrip1 = new XanderUI.XUICustomToolstrip();
            this.kapatbtn = new System.Windows.Forms.ToolStripButton();
            this.maximizebtn = new System.Windows.Forms.ToolStripButton();
            this.minimizebtn = new System.Windows.Forms.ToolStripButton();
            this.solslidingpnl.SuspendLayout();
            this.butonTutucuflwpnl.SuspendLayout();
            this.ortagradientpnl.SuspendLayout();
            this.xuıCustomToolstrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // solslidingpnl
            // 
            this.solslidingpnl.BottomLeft = System.Drawing.Color.DarkGray;
            this.solslidingpnl.BottomRight = System.Drawing.Color.DarkGray;
            this.solslidingpnl.CollapseControl = this.kapatAccstmpctrbx;
            this.solslidingpnl.Collapsed = false;
            this.solslidingpnl.Controls.Add(this.panel1);
            this.solslidingpnl.Controls.Add(this.kapatAccstmpctrbx);
            this.solslidingpnl.Controls.Add(this.butonTutucuflwpnl);
            this.solslidingpnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.solslidingpnl.HideControls = false;
            this.solslidingpnl.Location = new System.Drawing.Point(0, 0);
            this.solslidingpnl.Name = "solslidingpnl";
            this.solslidingpnl.PanelWidthCollapsed = 56;
            this.solslidingpnl.PanelWidthExpanded = 200;
            this.solslidingpnl.PrimerColor = System.Drawing.Color.White;
            this.solslidingpnl.Size = new System.Drawing.Size(218, 510);
            this.solslidingpnl.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.solslidingpnl.TabIndex = 2;
            this.solslidingpnl.TopLeft = System.Drawing.Color.Black;
            this.solslidingpnl.TopRight = System.Drawing.Color.Black;
            // 
            // kapatAccstmpctrbx
            // 
            this.kapatAccstmpctrbx.BackColor = System.Drawing.Color.Transparent;
            this.kapatAccstmpctrbx.Color1 = System.Drawing.Color.DodgerBlue;
            this.kapatAccstmpctrbx.Color2 = System.Drawing.Color.DodgerBlue;
            this.kapatAccstmpctrbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kapatAccstmpctrbx.FilterAlpha = 200;
            this.kapatAccstmpctrbx.FilterEnabled = false;
            this.kapatAccstmpctrbx.Image = global::DersRehberi.UI.Windows.Properties.Resources.menu_rounded_32px;
            this.kapatAccstmpctrbx.IsElipse = false;
            this.kapatAccstmpctrbx.IsParallax = false;
            this.kapatAccstmpctrbx.Location = new System.Drawing.Point(8, 11);
            this.kapatAccstmpctrbx.Name = "kapatAccstmpctrbx";
            this.kapatAccstmpctrbx.Size = new System.Drawing.Size(40, 33);
            this.kapatAccstmpctrbx.TabIndex = 9;
            this.kapatAccstmpctrbx.Text = "xuıCustomPictureBox2";
            this.kapatAccstmpctrbx.Visible = false;
            this.kapatAccstmpctrbx.Click += new System.EventHandler(this.kapatAccstmpctrbx_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 44);
            this.panel1.TabIndex = 10;
            // 
            // butonTutucuflwpnl
            // 
            this.butonTutucuflwpnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butonTutucuflwpnl.BackColor = System.Drawing.Color.Transparent;
            this.butonTutucuflwpnl.Controls.Add(this.ogrenciGirisbtn);
            this.butonTutucuflwpnl.Controls.Add(this.ogretmenGirisbtn);
            this.butonTutucuflwpnl.Controls.Add(this.veliGiribtn);
            this.butonTutucuflwpnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.butonTutucuflwpnl.Location = new System.Drawing.Point(0, 99);
            this.butonTutucuflwpnl.Name = "butonTutucuflwpnl";
            this.butonTutucuflwpnl.Size = new System.Drawing.Size(218, 361);
            this.butonTutucuflwpnl.TabIndex = 1;
            // 
            // ogrenciGirisbtn
            // 
            this.ogrenciGirisbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ogrenciGirisbtn.ButtonImage = global::DersRehberi.UI.Windows.Properties.Resources.student_male_52px;
            this.ogrenciGirisbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.ogrenciGirisbtn.ButtonText = "Öğrenci";
            this.ogrenciGirisbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ogrenciGirisbtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.ogrenciGirisbtn.CornerRadius = 5;
            this.ogrenciGirisbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrenciGirisbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciGirisbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.ogrenciGirisbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ogrenciGirisbtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.ogrenciGirisbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.ogrenciGirisbtn.Location = new System.Drawing.Point(3, 3);
            this.ogrenciGirisbtn.Name = "ogrenciGirisbtn";
            this.ogrenciGirisbtn.Size = new System.Drawing.Size(212, 50);
            this.ogrenciGirisbtn.TabIndex = 1;
            this.ogrenciGirisbtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.ogrenciGirisbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.ogrenciGirisbtn.Click += new System.EventHandler(this.ogrenciGirisbtn_Click);
            // 
            // ogretmenGirisbtn
            // 
            this.ogretmenGirisbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ogretmenGirisbtn.ButtonImage = global::DersRehberi.UI.Windows.Properties.Resources.school_director_52px;
            this.ogretmenGirisbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.ogretmenGirisbtn.ButtonText = "Öğretmen";
            this.ogretmenGirisbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ogretmenGirisbtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.ogretmenGirisbtn.CornerRadius = 5;
            this.ogretmenGirisbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogretmenGirisbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogretmenGirisbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.ogretmenGirisbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ogretmenGirisbtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.ogretmenGirisbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.ogretmenGirisbtn.Location = new System.Drawing.Point(3, 59);
            this.ogretmenGirisbtn.Name = "ogretmenGirisbtn";
            this.ogretmenGirisbtn.Size = new System.Drawing.Size(212, 50);
            this.ogretmenGirisbtn.TabIndex = 2;
            this.ogretmenGirisbtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.ogretmenGirisbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // veliGiribtn
            // 
            this.veliGiribtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.veliGiribtn.ButtonImage = global::DersRehberi.UI.Windows.Properties.Resources.user_male_48px;
            this.veliGiribtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.veliGiribtn.ButtonText = "Veli";
            this.veliGiribtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.veliGiribtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.veliGiribtn.CornerRadius = 5;
            this.veliGiribtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.veliGiribtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.veliGiribtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.veliGiribtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.veliGiribtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.veliGiribtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.veliGiribtn.Location = new System.Drawing.Point(3, 115);
            this.veliGiribtn.Name = "veliGiribtn";
            this.veliGiribtn.Size = new System.Drawing.Size(212, 50);
            this.veliGiribtn.TabIndex = 4;
            this.veliGiribtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.veliGiribtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // ortagradientpnl
            // 
            this.ortagradientpnl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ortagradientpnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ortagradientpnl.BackgroundImage")));
            this.ortagradientpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ortagradientpnl.Controls.Add(this.duyurularflwpnl);
            this.ortagradientpnl.Controls.Add(this.xuıCustomPictureBox1);
            this.ortagradientpnl.Controls.Add(this.label1);
            this.ortagradientpnl.Controls.Add(this.xuıCustomToolstrip1);
            this.ortagradientpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ortagradientpnl.GradientBottomLeft = System.Drawing.Color.DimGray;
            this.ortagradientpnl.GradientBottomRight = System.Drawing.Color.White;
            this.ortagradientpnl.GradientTopLeft = System.Drawing.Color.White;
            this.ortagradientpnl.GradientTopRight = System.Drawing.Color.White;
            this.ortagradientpnl.Location = new System.Drawing.Point(218, 0);
            this.ortagradientpnl.Name = "ortagradientpnl";
            this.ortagradientpnl.Quality = 10;
            this.ortagradientpnl.Size = new System.Drawing.Size(711, 510);
            this.ortagradientpnl.TabIndex = 3;
            // 
            // duyurularflwpnl
            // 
            this.duyurularflwpnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.duyurularflwpnl.AutoScroll = true;
            this.duyurularflwpnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.duyurularflwpnl.BackColor = System.Drawing.Color.Transparent;
            this.duyurularflwpnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.duyurularflwpnl.Location = new System.Drawing.Point(44, 99);
            this.duyurularflwpnl.Name = "duyurularflwpnl";
            this.duyurularflwpnl.Size = new System.Drawing.Size(638, 386);
            this.duyurularflwpnl.TabIndex = 11;
            this.duyurularflwpnl.SizeChanged += new System.EventHandler(this.duyurularflwpnl_SizeChanged);
            // 
            // xuıCustomPictureBox1
            // 
            this.xuıCustomPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.xuıCustomPictureBox1.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuıCustomPictureBox1.Color2 = System.Drawing.Color.DodgerBlue;
            this.xuıCustomPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuıCustomPictureBox1.FilterAlpha = 200;
            this.xuıCustomPictureBox1.FilterEnabled = false;
            this.xuıCustomPictureBox1.Image = global::DersRehberi.UI.Windows.Properties.Resources.bullhorn_megaphone_64px;
            this.xuıCustomPictureBox1.IsElipse = false;
            this.xuıCustomPictureBox1.IsParallax = false;
            this.xuıCustomPictureBox1.Location = new System.Drawing.Point(44, 35);
            this.xuıCustomPictureBox1.Name = "xuıCustomPictureBox1";
            this.xuıCustomPictureBox1.Size = new System.Drawing.Size(40, 42);
            this.xuıCustomPictureBox1.TabIndex = 10;
            this.xuıCustomPictureBox1.Text = "xuıCustomPictureBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(90, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Duyurular";
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
            this.minimizebtn});
            this.xuıCustomToolstrip1.Location = new System.Drawing.Point(0, 0);
            this.xuıCustomToolstrip1.Name = "xuıCustomToolstrip1";
            this.xuıCustomToolstrip1.Size = new System.Drawing.Size(711, 25);
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
            this.kapatbtn.Click += new System.EventHandler(this.kapatbtn_Click);
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
            this.maximizebtn.Click += new System.EventHandler(this.maximizebtn_Click);
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
            // AnaEkranFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 510);
            this.Controls.Add(this.ortagradientpnl);
            this.Controls.Add(this.solslidingpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaEkranFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkranFrm";
            this.Load += new System.EventHandler(this.AnaEkranFrm_Load);
            this.solslidingpnl.ResumeLayout(false);
            this.butonTutucuflwpnl.ResumeLayout(false);
            this.ortagradientpnl.ResumeLayout(false);
            this.ortagradientpnl.PerformLayout();
            this.xuıCustomToolstrip1.ResumeLayout(false);
            this.xuıCustomToolstrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUISlidingPanel solslidingpnl;
        private ns1.BunifuGradientPanel ortagradientpnl;
        private XanderUI.XUICustomToolstrip xuıCustomToolstrip1;
        private System.Windows.Forms.ToolStripButton kapatbtn;
        private System.Windows.Forms.ToolStripButton maximizebtn;
        private System.Windows.Forms.ToolStripButton minimizebtn;
        private System.Windows.Forms.FlowLayoutPanel butonTutucuflwpnl;
        private XanderUI.XUICustomPictureBox kapatAccstmpctrbx;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUICustomPictureBox xuıCustomPictureBox1;
        private System.Windows.Forms.FlowLayoutPanel duyurularflwpnl;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton ogrenciGirisbtn;
        private XanderUI.XUIButton ogretmenGirisbtn;
        private XanderUI.XUIButton veliGiribtn;
    }
}