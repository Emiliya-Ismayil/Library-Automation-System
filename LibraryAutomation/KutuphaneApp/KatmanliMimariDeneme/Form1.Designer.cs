namespace KatmanliMimariDeneme
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblAdi = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.lblSayfaSayisi = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtSayfaS = new System.Windows.Forms.TextBox();
            this.btEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.btguncelle = new System.Windows.Forms.Button();
            this.btSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btYeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(544, 233);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(78, 322);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(22, 13);
            this.lblAdi.TabIndex = 1;
            this.lblAdi.Text = "Adi";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(125, 315);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(181, 20);
            this.txtAdi.TabIndex = 2;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // lblSayfaSayisi
            // 
            this.lblSayfaSayisi.AutoSize = true;
            this.lblSayfaSayisi.Location = new System.Drawing.Point(36, 370);
            this.lblSayfaSayisi.Name = "lblSayfaSayisi";
            this.lblSayfaSayisi.Size = new System.Drawing.Size(64, 13);
            this.lblSayfaSayisi.TabIndex = 3;
            this.lblSayfaSayisi.Text = "Sayfa Sayisi";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(54, 420);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 4;
            this.lblKategori.Text = "Kategori";
            // 
            // txtSayfaS
            // 
            this.txtSayfaS.Location = new System.Drawing.Point(125, 370);
            this.txtSayfaS.Name = "txtSayfaS";
            this.txtSayfaS.Size = new System.Drawing.Size(181, 20);
            this.txtSayfaS.TabIndex = 5;
            // 
            // btEkle
            // 
            this.btEkle.Location = new System.Drawing.Point(397, 340);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(104, 43);
            this.btEkle.TabIndex = 7;
            this.btEkle.Text = "EKLE";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Yazar";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(125, 475);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(181, 20);
            this.txtYazar.TabIndex = 9;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(125, 417);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(181, 21);
            this.cbKategori.TabIndex = 6;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // btguncelle
            // 
            this.btguncelle.Location = new System.Drawing.Point(397, 396);
            this.btguncelle.Name = "btguncelle";
            this.btguncelle.Size = new System.Drawing.Size(104, 37);
            this.btguncelle.TabIndex = 10;
            this.btguncelle.Text = "GUNCELLE";
            this.btguncelle.UseVisualStyleBackColor = true;
            this.btguncelle.Click += new System.EventHandler(this.btguncelle_Click);
            // 
            // btSil
            // 
            this.btSil.Location = new System.Drawing.Point(397, 454);
            this.btSil.Name = "btSil";
            this.btSil.Size = new System.Drawing.Size(104, 37);
            this.btSil.TabIndex = 11;
            this.btSil.Text = "SİL";
            this.btSil.UseVisualStyleBackColor = true;
            this.btSil.Click += new System.EventHandler(this.btSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 260);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(181, 20);
            this.txtID.TabIndex = 13;
            // 
            // btYeni
            // 
            this.btYeni.Location = new System.Drawing.Point(397, 267);
            this.btYeni.Name = "btYeni";
            this.btYeni.Size = new System.Drawing.Size(104, 43);
            this.btYeni.TabIndex = 14;
            this.btYeni.Text = "YENİ";
            this.btYeni.UseVisualStyleBackColor = true;
            this.btYeni.Click += new System.EventHandler(this.btYeni_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(556, 518);
            this.Controls.Add(this.btYeni);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSil);
            this.Controls.Add(this.btguncelle);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEkle);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.txtSayfaS);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblSayfaSayisi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Adi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntEkle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label lblSayfaSayisi;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txtSayfaS;
        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Button btguncelle;
        private System.Windows.Forms.Button btSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btYeni;
    }
}

