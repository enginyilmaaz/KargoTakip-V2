namespace WindowsFormsApplication1
{
    partial class subeEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subeEkrani));
            this.Main_Grid = new System.Windows.Forms.DataGridView();
            this.lbl_yetkili_adi = new System.Windows.Forms.Label();
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.contextMenuStripPersoneller = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personelGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripKargolar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnKargolariListele = new System.Windows.Forms.Button();
            this.btnGonderiYap = new System.Windows.Forms.Button();
            this.btnMusterileriListele = new System.Windows.Forms.Button();
            this.btnPersonelListesi = new System.Windows.Forms.Button();
            this.btnSubeDegistir = new System.Windows.Forms.Button();
            this.btnAdresler = new System.Windows.Forms.Button();
            this.btnRapolar = new System.Windows.Forms.Button();
            this.btnFaturaListele = new System.Windows.Forms.Button();
            this.gbAra = new System.Windows.Forms.GroupBox();
            this.cbRaporlar = new System.Windows.Forms.ComboBox();
            this.lblRapor = new System.Windows.Forms.Label();
            this.lbl_ara = new System.Windows.Forms.Label();
            this.tb_ara = new System.Windows.Forms.TextBox();
            this.gönderiyiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid)).BeginInit();
            this.contextMenuStripPersoneller.SuspendLayout();
            this.contextMenuStripKargolar.SuspendLayout();
            this.gbAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Grid
            // 
            this.Main_Grid.AllowDrop = true;
            this.Main_Grid.AllowUserToAddRows = false;
            this.Main_Grid.AllowUserToDeleteRows = false;
            this.Main_Grid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Main_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Main_Grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.Main_Grid.GridColor = System.Drawing.Color.MistyRose;
            this.Main_Grid.Location = new System.Drawing.Point(25, 205);
            this.Main_Grid.MultiSelect = false;
            this.Main_Grid.Name = "Main_Grid";
            this.Main_Grid.ReadOnly = true;
            this.Main_Grid.Size = new System.Drawing.Size(959, 336);
            this.Main_Grid.TabIndex = 26;
            this.Main_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Main_Grid_CellContentClick);
            // 
            // lbl_yetkili_adi
            // 
            this.lbl_yetkili_adi.AutoSize = true;
            this.lbl_yetkili_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yetkili_adi.Location = new System.Drawing.Point(143, 32);
            this.lbl_yetkili_adi.Name = "lbl_yetkili_adi";
            this.lbl_yetkili_adi.Size = new System.Drawing.Size(78, 20);
            this.lbl_yetkili_adi.TabIndex = 25;
            this.lbl_yetkili_adi.Text = " kullanıcı";
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.AutoSize = true;
            this.lblHosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldiniz.Location = new System.Drawing.Point(34, 32);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(112, 20);
            this.lblHosgeldiniz.TabIndex = 24;
            this.lblHosgeldiniz.Text = "Hoşgeldiniz, ";
            // 
            // contextMenuStripPersoneller
            // 
            this.contextMenuStripPersoneller.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelGüncelleToolStripMenuItem,
            this.personelSilToolStripMenuItem});
            this.contextMenuStripPersoneller.Name = "contextMenuStripPersoneller";
            this.contextMenuStripPersoneller.Size = new System.Drawing.Size(169, 48);
            // 
            // personelGüncelleToolStripMenuItem
            // 
            this.personelGüncelleToolStripMenuItem.Name = "personelGüncelleToolStripMenuItem";
            this.personelGüncelleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.personelGüncelleToolStripMenuItem.Text = "Personel Güncelle";
            this.personelGüncelleToolStripMenuItem.Click += new System.EventHandler(this.personelGüncelleToolStripMenuItem_Click);
            // 
            // personelSilToolStripMenuItem
            // 
            this.personelSilToolStripMenuItem.Name = "personelSilToolStripMenuItem";
            this.personelSilToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.personelSilToolStripMenuItem.Text = "Personel Sil";
            this.personelSilToolStripMenuItem.Click += new System.EventHandler(this.personelSilToolStripMenuItem_Click);
            // 
            // contextMenuStripKargolar
            // 
            this.contextMenuStripKargolar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gönderiyiGüncelleToolStripMenuItem});
            this.contextMenuStripKargolar.Name = "contextMenuStripKargolar";
            this.contextMenuStripKargolar.Size = new System.Drawing.Size(175, 26);
            // 
            // btnKargolariListele
            // 
            this.btnKargolariListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKargolariListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKargolariListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKargolariListele.Image = ((System.Drawing.Image)(resources.GetObject("btnKargolariListele.Image")));
            this.btnKargolariListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKargolariListele.Location = new System.Drawing.Point(675, 73);
            this.btnKargolariListele.Name = "btnKargolariListele";
            this.btnKargolariListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnKargolariListele.Size = new System.Drawing.Size(159, 60);
            this.btnKargolariListele.TabIndex = 34;
            this.btnKargolariListele.Text = "   Kargoları\r\n   Listele";
            this.btnKargolariListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKargolariListele.UseVisualStyleBackColor = false;
            this.btnKargolariListele.Click += new System.EventHandler(this.btnKargolariListele_Click);
            // 
            // btnGonderiYap
            // 
            this.btnGonderiYap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGonderiYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGonderiYap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonderiYap.Image = global::WindowsFormsApplication1.Properties.Resources._1460067198_box;
            this.btnGonderiYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGonderiYap.Location = new System.Drawing.Point(206, 73);
            this.btnGonderiYap.Name = "btnGonderiYap";
            this.btnGonderiYap.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnGonderiYap.Size = new System.Drawing.Size(141, 60);
            this.btnGonderiYap.TabIndex = 33;
            this.btnGonderiYap.Text = "   Gönderi\r\n   Yap";
            this.btnGonderiYap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGonderiYap.UseVisualStyleBackColor = false;
            this.btnGonderiYap.Click += new System.EventHandler(this.btnGonderiYap_Click);
            // 
            // btnMusterileriListele
            // 
            this.btnMusterileriListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMusterileriListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMusterileriListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusterileriListele.Image = ((System.Drawing.Image)(resources.GetObject("btnMusterileriListele.Image")));
            this.btnMusterileriListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusterileriListele.Location = new System.Drawing.Point(630, 139);
            this.btnMusterileriListele.Name = "btnMusterileriListele";
            this.btnMusterileriListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMusterileriListele.Size = new System.Drawing.Size(176, 60);
            this.btnMusterileriListele.TabIndex = 31;
            this.btnMusterileriListele.Text = "   Müşteri\r\n   Listele";
            this.btnMusterileriListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusterileriListele.UseVisualStyleBackColor = false;
            this.btnMusterileriListele.Click += new System.EventHandler(this.btnMusterileriListele_Click);
            // 
            // btnPersonelListesi
            // 
            this.btnPersonelListesi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPersonelListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPersonelListesi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListesi.Image = global::WindowsFormsApplication1.Properties.Resources._1459296516_Untitled_2_40;
            this.btnPersonelListesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelListesi.Location = new System.Drawing.Point(353, 73);
            this.btnPersonelListesi.Name = "btnPersonelListesi";
            this.btnPersonelListesi.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnPersonelListesi.Size = new System.Drawing.Size(162, 60);
            this.btnPersonelListesi.TabIndex = 28;
            this.btnPersonelListesi.Text = "   Personelleri\r\n   Listele";
            this.btnPersonelListesi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelListesi.UseVisualStyleBackColor = false;
            this.btnPersonelListesi.Click += new System.EventHandler(this.btnPersonelListesi_Click);
            // 
            // btnSubeDegistir
            // 
            this.btnSubeDegistir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubeDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubeDegistir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubeDegistir.Image = global::WindowsFormsApplication1.Properties.Resources.travel_agency_32;
            this.btnSubeDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubeDegistir.Location = new System.Drawing.Point(25, 73);
            this.btnSubeDegistir.Name = "btnSubeDegistir";
            this.btnSubeDegistir.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSubeDegistir.Size = new System.Drawing.Size(175, 60);
            this.btnSubeDegistir.TabIndex = 27;
            this.btnSubeDegistir.Text = "   Şube Bilgisi \r\n   Değiştir";
            this.btnSubeDegistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubeDegistir.UseVisualStyleBackColor = false;
            this.btnSubeDegistir.Click += new System.EventHandler(this.btnSubeListele_Click);
            // 
            // btnAdresler
            // 
            this.btnAdresler.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdresler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdresler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdresler.Image = ((System.Drawing.Image)(resources.GetObject("btnAdresler.Image")));
            this.btnAdresler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdresler.Location = new System.Drawing.Point(521, 73);
            this.btnAdresler.Name = "btnAdresler";
            this.btnAdresler.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAdresler.Size = new System.Drawing.Size(148, 60);
            this.btnAdresler.TabIndex = 38;
            this.btnAdresler.Text = "   Adresleri\r\n   Listele";
            this.btnAdresler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdresler.UseVisualStyleBackColor = false;
            this.btnAdresler.Click += new System.EventHandler(this.btnAdresler_Click);
            // 
            // btnRapolar
            // 
            this.btnRapolar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRapolar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRapolar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapolar.Image = global::WindowsFormsApplication1.Properties.Resources.thin_1075_analytics_report_32;
            this.btnRapolar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapolar.Location = new System.Drawing.Point(840, 73);
            this.btnRapolar.Name = "btnRapolar";
            this.btnRapolar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRapolar.Size = new System.Drawing.Size(144, 60);
            this.btnRapolar.TabIndex = 44;
            this.btnRapolar.Text = "Raporlar";
            this.btnRapolar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRapolar.UseVisualStyleBackColor = false;
            this.btnRapolar.Click += new System.EventHandler(this.btnRapolar_Click);
            // 
            // btnFaturaListele
            // 
            this.btnFaturaListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFaturaListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFaturaListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaListele.Image = global::WindowsFormsApplication1.Properties.Resources.invoice_32;
            this.btnFaturaListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturaListele.Location = new System.Drawing.Point(812, 139);
            this.btnFaturaListele.Name = "btnFaturaListele";
            this.btnFaturaListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnFaturaListele.Size = new System.Drawing.Size(172, 60);
            this.btnFaturaListele.TabIndex = 43;
            this.btnFaturaListele.Text = "   Fatura\r\n   Listele";
            this.btnFaturaListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaturaListele.UseVisualStyleBackColor = false;
            this.btnFaturaListele.Click += new System.EventHandler(this.btnFaturaListele_Click);
            // 
            // gbAra
            // 
            this.gbAra.Controls.Add(this.cbRaporlar);
            this.gbAra.Controls.Add(this.lblRapor);
            this.gbAra.Controls.Add(this.lbl_ara);
            this.gbAra.Controls.Add(this.tb_ara);
            this.gbAra.Location = new System.Drawing.Point(25, 137);
            this.gbAra.Name = "gbAra";
            this.gbAra.Size = new System.Drawing.Size(599, 58);
            this.gbAra.TabIndex = 45;
            this.gbAra.TabStop = false;
            // 
            // cbRaporlar
            // 
            this.cbRaporlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRaporlar.FormattingEnabled = true;
            this.cbRaporlar.Items.AddRange(new object[] {
            "Seçiniz...",
            "Ortalama gönderi ücreti",
            "Genel toplam kazanç",
            "Toplam gönderi sayısı",
            "Teslim edilmiş gönderiler",
            "Teslim edilmemiş gönderiler"});
            this.cbRaporlar.Location = new System.Drawing.Point(79, 17);
            this.cbRaporlar.Name = "cbRaporlar";
            this.cbRaporlar.Size = new System.Drawing.Size(453, 28);
            this.cbRaporlar.TabIndex = 15;
            this.cbRaporlar.Visible = false;
            this.cbRaporlar.SelectedIndexChanged += new System.EventHandler(this.cbRaporlar_SelectedIndexChanged);
            // 
            // lblRapor
            // 
            this.lblRapor.AutoSize = true;
            this.lblRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRapor.Location = new System.Drawing.Point(6, 22);
            this.lblRapor.Name = "lblRapor";
            this.lblRapor.Size = new System.Drawing.Size(63, 20);
            this.lblRapor.TabIndex = 14;
            this.lblRapor.Text = "Rapor:";
            this.lblRapor.Visible = false;
            // 
            // lbl_ara
            // 
            this.lbl_ara.AutoSize = true;
            this.lbl_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ara.Location = new System.Drawing.Point(22, 22);
            this.lbl_ara.Name = "lbl_ara";
            this.lbl_ara.Size = new System.Drawing.Size(42, 20);
            this.lbl_ara.TabIndex = 13;
            this.lbl_ara.Text = "Ara:";
            // 
            // tb_ara
            // 
            this.tb_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_ara.Location = new System.Drawing.Point(79, 19);
            this.tb_ara.Name = "tb_ara";
            this.tb_ara.Size = new System.Drawing.Size(453, 26);
            this.tb_ara.TabIndex = 4;
            this.tb_ara.TextChanged += new System.EventHandler(this.tb_ara_TextChanged);
            // 
            // gönderiyiGüncelleToolStripMenuItem
            // 
            this.gönderiyiGüncelleToolStripMenuItem.Name = "gönderiyiGüncelleToolStripMenuItem";
            this.gönderiyiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gönderiyiGüncelleToolStripMenuItem.Text = "Gönderiyi Güncelle";
            this.gönderiyiGüncelleToolStripMenuItem.Click += new System.EventHandler(this.gönderiyiGüncelleToolStripMenuItem_Click);
            // 
            // subeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 607);
            this.Controls.Add(this.gbAra);
            this.Controls.Add(this.btnRapolar);
            this.Controls.Add(this.btnFaturaListele);
            this.Controls.Add(this.btnAdresler);
            this.Controls.Add(this.btnKargolariListele);
            this.Controls.Add(this.btnGonderiYap);
            this.Controls.Add(this.btnMusterileriListele);
            this.Controls.Add(this.btnPersonelListesi);
            this.Controls.Add(this.btnSubeDegistir);
            this.Controls.Add(this.Main_Grid);
            this.Controls.Add(this.lbl_yetkili_adi);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Name = "subeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şube Yöneticisi Ekranı";
            this.Load += new System.EventHandler(this.subeYoneticisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid)).EndInit();
            this.contextMenuStripPersoneller.ResumeLayout(false);
            this.contextMenuStripKargolar.ResumeLayout(false);
            this.gbAra.ResumeLayout(false);
            this.gbAra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusterileriListele;
        private System.Windows.Forms.Button btnPersonelListesi;
        private System.Windows.Forms.Button btnSubeDegistir;
        private System.Windows.Forms.DataGridView Main_Grid;
        private System.Windows.Forms.Label lbl_yetkili_adi;
        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPersoneller;
        private System.Windows.Forms.ToolStripMenuItem personelGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSilToolStripMenuItem;
        private System.Windows.Forms.Button btnGonderiYap;
        private System.Windows.Forms.Button btnKargolariListele;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripKargolar;
        private System.Windows.Forms.Button btnAdresler;
        private System.Windows.Forms.Button btnRapolar;
        private System.Windows.Forms.Button btnFaturaListele;
        private System.Windows.Forms.GroupBox gbAra;
        private System.Windows.Forms.ComboBox cbRaporlar;
        private System.Windows.Forms.Label lblRapor;
        private System.Windows.Forms.Label lbl_ara;
        private System.Windows.Forms.TextBox tb_ara;
        private System.Windows.Forms.ToolStripMenuItem gönderiyiGüncelleToolStripMenuItem;
    }
}