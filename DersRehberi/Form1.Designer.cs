namespace DersRehberi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dersRehberiDataSet = new DersRehberi.DersRehberiDataSet();
            this.testlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testlerTableAdapter = new DersRehberi.DersRehberiDataSetTableAdapters.TestlerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testtekiSoruSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doğruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yanlışDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boşDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.üniteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayıneviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dersRehberiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dersRehberiDataSet
            // 
            this.dersRehberiDataSet.DataSetName = "DersRehberiDataSet";
            this.dersRehberiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testlerBindingSource
            // 
            this.testlerBindingSource.DataMember = "Testler";
            this.testlerBindingSource.DataSource = this.dersRehberiDataSet;
            // 
            // testlerTableAdapter
            // 
            this.testlerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.testtekiSoruSayısıDataGridViewTextBoxColumn,
            this.doğruDataGridViewTextBoxColumn,
            this.yanlışDataGridViewTextBoxColumn,
            this.boşDataGridViewTextBoxColumn,
            this.netDataGridViewTextBoxColumn,
            this.dersDataGridViewTextBoxColumn,
            this.üniteDataGridViewTextBoxColumn,
            this.konuDataGridViewTextBoxColumn,
            this.yayıneviDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.testlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1346, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 70;
            // 
            // testtekiSoruSayısıDataGridViewTextBoxColumn
            // 
            this.testtekiSoruSayısıDataGridViewTextBoxColumn.DataPropertyName = "TesttekiSoruSayısı";
            this.testtekiSoruSayısıDataGridViewTextBoxColumn.HeaderText = "Testteki Soru Sayısı";
            this.testtekiSoruSayısıDataGridViewTextBoxColumn.Name = "testtekiSoruSayısıDataGridViewTextBoxColumn";
            this.testtekiSoruSayısıDataGridViewTextBoxColumn.Width = 130;
            // 
            // doğruDataGridViewTextBoxColumn
            // 
            this.doğruDataGridViewTextBoxColumn.DataPropertyName = "Doğru";
            this.doğruDataGridViewTextBoxColumn.HeaderText = "Doğru";
            this.doğruDataGridViewTextBoxColumn.Name = "doğruDataGridViewTextBoxColumn";
            this.doğruDataGridViewTextBoxColumn.Width = 70;
            // 
            // yanlışDataGridViewTextBoxColumn
            // 
            this.yanlışDataGridViewTextBoxColumn.DataPropertyName = "Yanlış";
            this.yanlışDataGridViewTextBoxColumn.HeaderText = "Yanlış";
            this.yanlışDataGridViewTextBoxColumn.Name = "yanlışDataGridViewTextBoxColumn";
            this.yanlışDataGridViewTextBoxColumn.Width = 70;
            // 
            // boşDataGridViewTextBoxColumn
            // 
            this.boşDataGridViewTextBoxColumn.DataPropertyName = "Boş";
            this.boşDataGridViewTextBoxColumn.HeaderText = "Boş";
            this.boşDataGridViewTextBoxColumn.Name = "boşDataGridViewTextBoxColumn";
            this.boşDataGridViewTextBoxColumn.Width = 70;
            // 
            // netDataGridViewTextBoxColumn
            // 
            this.netDataGridViewTextBoxColumn.DataPropertyName = "Net";
            this.netDataGridViewTextBoxColumn.HeaderText = "Net";
            this.netDataGridViewTextBoxColumn.Name = "netDataGridViewTextBoxColumn";
            this.netDataGridViewTextBoxColumn.Width = 70;
            // 
            // dersDataGridViewTextBoxColumn
            // 
            this.dersDataGridViewTextBoxColumn.DataPropertyName = "Ders";
            this.dersDataGridViewTextBoxColumn.HeaderText = "Ders";
            this.dersDataGridViewTextBoxColumn.Name = "dersDataGridViewTextBoxColumn";
            this.dersDataGridViewTextBoxColumn.Width = 160;
            // 
            // üniteDataGridViewTextBoxColumn
            // 
            this.üniteDataGridViewTextBoxColumn.DataPropertyName = "Ünite";
            this.üniteDataGridViewTextBoxColumn.HeaderText = "Ünite";
            this.üniteDataGridViewTextBoxColumn.Name = "üniteDataGridViewTextBoxColumn";
            this.üniteDataGridViewTextBoxColumn.Width = 160;
            // 
            // konuDataGridViewTextBoxColumn
            // 
            this.konuDataGridViewTextBoxColumn.DataPropertyName = "Konu";
            this.konuDataGridViewTextBoxColumn.HeaderText = "Konu";
            this.konuDataGridViewTextBoxColumn.Name = "konuDataGridViewTextBoxColumn";
            this.konuDataGridViewTextBoxColumn.Width = 200;
            // 
            // yayıneviDataGridViewTextBoxColumn
            // 
            this.yayıneviDataGridViewTextBoxColumn.DataPropertyName = "Yayınevi";
            this.yayıneviDataGridViewTextBoxColumn.HeaderText = "Yayınevi";
            this.yayıneviDataGridViewTextBoxColumn.Name = "yayıneviDataGridViewTextBoxColumn";
            this.yayıneviDataGridViewTextBoxColumn.Width = 150;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 153;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dersRehberiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DersRehberiDataSet dersRehberiDataSet;
        private System.Windows.Forms.BindingSource testlerBindingSource;
        private DersRehberiDataSetTableAdapters.TestlerTableAdapter testlerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testtekiSoruSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doğruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yanlışDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boşDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn üniteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayıneviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}

