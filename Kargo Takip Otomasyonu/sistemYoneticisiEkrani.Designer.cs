namespace WindowsFormsApplication1
{
    partial class sistemYoneticisiEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sistemYoneticisiEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_yetkili_adi = new System.Windows.Forms.Label();
            this.Main_Grid = new System.Windows.Forms.DataGridView();
            this.gbAra = new System.Windows.Forms.GroupBox();
            this.cbRaporlar = new System.Windows.Forms.ComboBox();
            this.lblRapor = new System.Windows.Forms.Label();
            this.lbl_ara = new System.Windows.Forms.Label();
            this.tb_ara = new System.Windows.Forms.TextBox();
            this.contextMenuStripSubeler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.şubeyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şubeyiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniŞubeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripUcretler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ücretGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ücretSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ücretEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRapolar = new System.Windows.Forms.Button();
            this.btnFaturaListele = new System.Windows.Forms.Button();
            this.ucretEkle = new System.Windows.Forms.Button();
            this.btnDurumEkle = new System.Windows.Forms.Button();
            this.btnYetkiEkle = new System.Windows.Forms.Button();
            this.btn_durumEkrani = new System.Windows.Forms.Button();
            this.btn_yetkileriYonet = new System.Windows.Forms.Button();
            this.btnKargolariListele = new System.Windows.Forms.Button();
            this.btnUcretlerListesi = new System.Windows.Forms.Button();
            this.btnYetkiliEkle = new System.Windows.Forms.Button();
            this.btnSubeEkle = new System.Windows.Forms.Button();
            this.btnYetkiliListesi = new System.Windows.Forms.Button();
            this.btnSubeListele = new System.Windows.Forms.Button();
            this.contextMenuStripDurumlar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniDurumEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliDurmuGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliDurumuSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripYetkiler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniYetkiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliYetkiyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuAdresler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adresiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.cMS_Guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_yetkiliEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripYetkililer = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid)).BeginInit();
            this.gbAra.SuspendLayout();
            this.contextMenuStripSubeler.SuspendLayout();
            this.contextMenuStripUcretler.SuspendLayout();
            this.contextMenuStripDurumlar.SuspendLayout();
            this.contextMenuStripYetkiler.SuspendLayout();
            this.contextMenuAdresler.SuspendLayout();
            this.contextMenuStripYetkililer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(336, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hoşgeldiniz, ";
            // 
            // lbl_yetkili_adi
            // 
            this.lbl_yetkili_adi.AutoSize = true;
            this.lbl_yetkili_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yetkili_adi.Location = new System.Drawing.Point(454, 32);
            this.lbl_yetkili_adi.Name = "lbl_yetkili_adi";
            this.lbl_yetkili_adi.Size = new System.Drawing.Size(78, 20);
            this.lbl_yetkili_adi.TabIndex = 4;
            this.lbl_yetkili_adi.Text = " kullanıcı";
            // 
            // Main_Grid
            // 
            this.Main_Grid.AllowDrop = true;
            this.Main_Grid.AllowUserToAddRows = false;
            this.Main_Grid.AllowUserToDeleteRows = false;
            this.Main_Grid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Main_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Main_Grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.Main_Grid.GridColor = System.Drawing.Color.MistyRose;
            this.Main_Grid.Location = new System.Drawing.Point(29, 285);
            this.Main_Grid.MultiSelect = false;
            this.Main_Grid.Name = "Main_Grid";
            this.Main_Grid.ReadOnly = true;
            this.Main_Grid.Size = new System.Drawing.Size(937, 293);
            this.Main_Grid.TabIndex = 6;
            this.Main_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Main_Grid_CellContentClick);
            // 
            // gbAra
            // 
            this.gbAra.Controls.Add(this.cbRaporlar);
            this.gbAra.Controls.Add(this.lblRapor);
            this.gbAra.Controls.Add(this.lbl_ara);
            this.gbAra.Controls.Add(this.tb_ara);
            this.gbAra.Location = new System.Drawing.Point(29, 221);
            this.gbAra.Name = "gbAra";
            this.gbAra.Size = new System.Drawing.Size(569, 58);
            this.gbAra.TabIndex = 13;
            this.gbAra.TabStop = false;
            // 
            // cbRaporlar
            // 
            this.cbRaporlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRaporlar.FormattingEnabled = true;
            this.cbRaporlar.Items.AddRange(new object[] {
            "Seçiniz...",
            "Çıkış şubesine göre kargo sayıları",
            "Şubelere göre personel sayıları",
            "Şubelere göre ortalama gönderi ücreti",
            "Şubelere göre toplam kazanç",
            "Genel toplam kazanç",
            "Toplam şube sayısı",
            "Toplam personel sayısı",
            "Toplam gönderi sayısı",
            "Teslim edilmiş toplam gönderi sayısı",
            "Teslim edilmemiş toplam gönderi sayısı"});
            this.cbRaporlar.Location = new System.Drawing.Point(79, 19);
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
            // contextMenuStripSubeler
            // 
            this.contextMenuStripSubeler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şubeyiSilToolStripMenuItem,
            this.şubeyiGüncelleToolStripMenuItem,
            this.yeniŞubeEkleToolStripMenuItem});
            this.contextMenuStripSubeler.Name = "contextMenuStripYetkililer";
            this.contextMenuStripSubeler.Size = new System.Drawing.Size(159, 70);
            // 
            // şubeyiSilToolStripMenuItem
            // 
            this.şubeyiSilToolStripMenuItem.Name = "şubeyiSilToolStripMenuItem";
            this.şubeyiSilToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.şubeyiSilToolStripMenuItem.Text = "Şubeyi Sil";
            this.şubeyiSilToolStripMenuItem.Click += new System.EventHandler(this.şubeyiSilToolStripMenuItem_Click);
            // 
            // şubeyiGüncelleToolStripMenuItem
            // 
            this.şubeyiGüncelleToolStripMenuItem.Name = "şubeyiGüncelleToolStripMenuItem";
            this.şubeyiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.şubeyiGüncelleToolStripMenuItem.Text = "Şubeyi Güncelle";
            this.şubeyiGüncelleToolStripMenuItem.Click += new System.EventHandler(this.şubeyiGüncelleToolStripMenuItem_Click);
            // 
            // yeniŞubeEkleToolStripMenuItem
            // 
            this.yeniŞubeEkleToolStripMenuItem.Name = "yeniŞubeEkleToolStripMenuItem";
            this.yeniŞubeEkleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yeniŞubeEkleToolStripMenuItem.Text = "Yeni Şube Ekle";
            this.yeniŞubeEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniŞubeEkleToolStripMenuItem_Click);
            // 
            // contextMenuStripUcretler
            // 
            this.contextMenuStripUcretler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ücretGuncelleToolStripMenuItem,
            this.ücretSilToolStripMenuItem,
            this.ücretEkleToolStripMenuItem});
            this.contextMenuStripUcretler.Name = "contextMenuStripUcretler";
            this.contextMenuStripUcretler.Size = new System.Drawing.Size(152, 70);
            // 
            // ücretGuncelleToolStripMenuItem
            // 
            this.ücretGuncelleToolStripMenuItem.Name = "ücretGuncelleToolStripMenuItem";
            this.ücretGuncelleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ücretGuncelleToolStripMenuItem.Text = "Ücret Guncelle";
            this.ücretGuncelleToolStripMenuItem.Click += new System.EventHandler(this.ücretGuncelleToolStripMenuItem_Click);
            // 
            // ücretSilToolStripMenuItem
            // 
            this.ücretSilToolStripMenuItem.Name = "ücretSilToolStripMenuItem";
            this.ücretSilToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ücretSilToolStripMenuItem.Text = "Ücret Sil";
            this.ücretSilToolStripMenuItem.Click += new System.EventHandler(this.ücretSilToolStripMenuItem_Click);
            // 
            // ücretEkleToolStripMenuItem
            // 
            this.ücretEkleToolStripMenuItem.Name = "ücretEkleToolStripMenuItem";
            this.ücretEkleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ücretEkleToolStripMenuItem.Text = "Ücret Ekle";
            this.ücretEkleToolStripMenuItem.Click += new System.EventHandler(this.ücretEkleToolStripMenuItem_Click);
            // 
            // btnRapolar
            // 
            this.btnRapolar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRapolar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRapolar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapolar.Image = global::WindowsFormsApplication1.Properties.Resources.thin_1075_analytics_report_32;
            this.btnRapolar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapolar.Location = new System.Drawing.Point(836, 151);
            this.btnRapolar.Name = "btnRapolar";
            this.btnRapolar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRapolar.Size = new System.Drawing.Size(130, 65);
            this.btnRapolar.TabIndex = 42;
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
            this.btnFaturaListele.Location = new System.Drawing.Point(708, 151);
            this.btnFaturaListele.Name = "btnFaturaListele";
            this.btnFaturaListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnFaturaListele.Size = new System.Drawing.Size(122, 65);
            this.btnFaturaListele.TabIndex = 41;
            this.btnFaturaListele.Text = "   Fatura\r\n   Listele";
            this.btnFaturaListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaturaListele.UseVisualStyleBackColor = false;
            this.btnFaturaListele.Click += new System.EventHandler(this.btnFaturaListele_Click);
            // 
            // ucretEkle
            // 
            this.ucretEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucretEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ucretEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucretEkle.Image = global::WindowsFormsApplication1.Properties.Resources.tag_add_32;
            this.ucretEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucretEkle.Location = new System.Drawing.Point(793, 80);
            this.ucretEkle.Name = "ucretEkle";
            this.ucretEkle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ucretEkle.Size = new System.Drawing.Size(173, 65);
            this.ucretEkle.TabIndex = 40;
            this.ucretEkle.Text = "    Birim Ücret\r\n    Ekle";
            this.ucretEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ucretEkle.UseVisualStyleBackColor = false;
            this.ucretEkle.Click += new System.EventHandler(this.ucretEkle_Click);
            // 
            // btnDurumEkle
            // 
            this.btnDurumEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDurumEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDurumEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDurumEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDurumEkle.Image")));
            this.btnDurumEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDurumEkle.Location = new System.Drawing.Point(441, 151);
            this.btnDurumEkle.Name = "btnDurumEkle";
            this.btnDurumEkle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDurumEkle.Size = new System.Drawing.Size(133, 64);
            this.btnDurumEkle.TabIndex = 39;
            this.btnDurumEkle.Text = "    Durum \r\n    Ekle";
            this.btnDurumEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDurumEkle.UseVisualStyleBackColor = false;
            this.btnDurumEkle.Click += new System.EventHandler(this.btnDurumEkle_Click);
            // 
            // btnYetkiEkle
            // 
            this.btnYetkiEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYetkiEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYetkiEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnYetkiEkle.Image")));
            this.btnYetkiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYetkiEkle.Location = new System.Drawing.Point(173, 151);
            this.btnYetkiEkle.Name = "btnYetkiEkle";
            this.btnYetkiEkle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnYetkiEkle.Size = new System.Drawing.Size(126, 64);
            this.btnYetkiEkle.TabIndex = 38;
            this.btnYetkiEkle.Text = "    Yetki \r\n    Ekle";
            this.btnYetkiEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYetkiEkle.UseVisualStyleBackColor = false;
            this.btnYetkiEkle.Click += new System.EventHandler(this.btnYetkiEkle_Click);
            // 
            // btn_durumEkrani
            // 
            this.btn_durumEkrani.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_durumEkrani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_durumEkrani.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_durumEkrani.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_durumEkrani.Image = ((System.Drawing.Image)(resources.GetObject("btn_durumEkrani.Image")));
            this.btn_durumEkrani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_durumEkrani.Location = new System.Drawing.Point(305, 151);
            this.btn_durumEkrani.Name = "btn_durumEkrani";
            this.btn_durumEkrani.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_durumEkrani.Size = new System.Drawing.Size(130, 64);
            this.btn_durumEkrani.TabIndex = 37;
            this.btn_durumEkrani.Text = "    Durum\r\n    Listele";
            this.btn_durumEkrani.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_durumEkrani.UseVisualStyleBackColor = false;
            this.btn_durumEkrani.Click += new System.EventHandler(this.btn_durumEkrani_Click);
            // 
            // btn_yetkileriYonet
            // 
            this.btn_yetkileriYonet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_yetkileriYonet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_yetkileriYonet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetkileriYonet.Image = ((System.Drawing.Image)(resources.GetObject("btn_yetkileriYonet.Image")));
            this.btn_yetkileriYonet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yetkileriYonet.Location = new System.Drawing.Point(29, 151);
            this.btn_yetkileriYonet.Name = "btn_yetkileriYonet";
            this.btn_yetkileriYonet.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_yetkileriYonet.Size = new System.Drawing.Size(138, 64);
            this.btn_yetkileriYonet.TabIndex = 36;
            this.btn_yetkileriYonet.Text = "    Yetkileri  \r\n    Listele  ";
            this.btn_yetkileriYonet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_yetkileriYonet.UseVisualStyleBackColor = false;
            this.btn_yetkileriYonet.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnKargolariListele
            // 
            this.btnKargolariListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKargolariListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKargolariListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKargolariListele.Image = global::WindowsFormsApplication1.Properties.Resources._1459296516_Untitled_2_40;
            this.btnKargolariListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKargolariListele.Location = new System.Drawing.Point(580, 151);
            this.btnKargolariListele.Name = "btnKargolariListele";
            this.btnKargolariListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnKargolariListele.Size = new System.Drawing.Size(122, 65);
            this.btnKargolariListele.TabIndex = 35;
            this.btnKargolariListele.Text = "   Kargo\r\n   Listele";
            this.btnKargolariListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKargolariListele.UseVisualStyleBackColor = false;
            this.btnKargolariListele.Click += new System.EventHandler(this.btnKargolariListele_Click);
            // 
            // btnUcretlerListesi
            // 
            this.btnUcretlerListesi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUcretlerListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUcretlerListesi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcretlerListesi.Image = global::WindowsFormsApplication1.Properties.Resources._1459312700_05_Tag;
            this.btnUcretlerListesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcretlerListesi.Location = new System.Drawing.Point(617, 80);
            this.btnUcretlerListesi.Name = "btnUcretlerListesi";
            this.btnUcretlerListesi.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnUcretlerListesi.Size = new System.Drawing.Size(170, 65);
            this.btnUcretlerListesi.TabIndex = 11;
            this.btnUcretlerListesi.Text = "    Birim Ücret\r\n    Listele";
            this.btnUcretlerListesi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUcretlerListesi.UseVisualStyleBackColor = false;
            this.btnUcretlerListesi.Click += new System.EventHandler(this.btnUcretlerListesi_Click);
            // 
            // btnYetkiliEkle
            // 
            this.btnYetkiliEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYetkiliEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYetkiliEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiliEkle.Image = global::WindowsFormsApplication1.Properties.Resources._1459297874_group_full_add;
            this.btnYetkiliEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYetkiliEkle.Location = new System.Drawing.Point(478, 80);
            this.btnYetkiliEkle.Name = "btnYetkiliEkle";
            this.btnYetkiliEkle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnYetkiliEkle.Size = new System.Drawing.Size(133, 65);
            this.btnYetkiliEkle.TabIndex = 10;
            this.btnYetkiliEkle.Text = "    Yetkili\r\n    Ekle";
            this.btnYetkiliEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYetkiliEkle.UseVisualStyleBackColor = false;
            this.btnYetkiliEkle.Click += new System.EventHandler(this.btnYetkiliEkle_Click);
            // 
            // btnSubeEkle
            // 
            this.btnSubeEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubeEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubeEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubeEkle.Image = global::WindowsFormsApplication1.Properties.Resources.branche_add_32;
            this.btnSubeEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubeEkle.Location = new System.Drawing.Point(186, 80);
            this.btnSubeEkle.Name = "btnSubeEkle";
            this.btnSubeEkle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSubeEkle.Size = new System.Drawing.Size(126, 65);
            this.btnSubeEkle.TabIndex = 9;
            this.btnSubeEkle.Text = "    Şube\r\n    Ekle";
            this.btnSubeEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubeEkle.UseVisualStyleBackColor = false;
            this.btnSubeEkle.Click += new System.EventHandler(this.btnSubeEkle_Click);
            // 
            // btnYetkiliListesi
            // 
            this.btnYetkiliListesi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYetkiliListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYetkiliListesi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiliListesi.Image = global::WindowsFormsApplication1.Properties.Resources._1459296516_Untitled_2_40;
            this.btnYetkiliListesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYetkiliListesi.Location = new System.Drawing.Point(318, 80);
            this.btnYetkiliListesi.Name = "btnYetkiliListesi";
            this.btnYetkiliListesi.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnYetkiliListesi.Size = new System.Drawing.Size(154, 65);
            this.btnYetkiliListesi.TabIndex = 8;
            this.btnYetkiliListesi.Text = "    Yetkilileri\r\n    Listele";
            this.btnYetkiliListesi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYetkiliListesi.UseVisualStyleBackColor = false;
            this.btnYetkiliListesi.Click += new System.EventHandler(this.btnYetkiliListesi_Click);
            // 
            // btnSubeListele
            // 
            this.btnSubeListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubeListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubeListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubeListele.Image = global::WindowsFormsApplication1.Properties.Resources.travel_agency_32;
            this.btnSubeListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubeListele.Location = new System.Drawing.Point(29, 80);
            this.btnSubeListele.Name = "btnSubeListele";
            this.btnSubeListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSubeListele.Size = new System.Drawing.Size(151, 65);
            this.btnSubeListele.TabIndex = 7;
            this.btnSubeListele.Text = "    Şubeleri\r\n    Listele";
            this.btnSubeListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubeListele.UseVisualStyleBackColor = false;
            this.btnSubeListele.Click += new System.EventHandler(this.btnSubeListele_Click);
            // 
            // contextMenuStripDurumlar
            // 
            this.contextMenuStripDurumlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniDurumEkleToolStripMenuItem,
            this.seçiliDurmuGüncelleToolStripMenuItem,
            this.seçiliDurumuSilToolStripMenuItem});
            this.contextMenuStripDurumlar.Name = "contextMenuStripDurumlar";
            this.contextMenuStripDurumlar.Size = new System.Drawing.Size(198, 70);
            // 
            // yeniDurumEkleToolStripMenuItem
            // 
            this.yeniDurumEkleToolStripMenuItem.Name = "yeniDurumEkleToolStripMenuItem";
            this.yeniDurumEkleToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.yeniDurumEkleToolStripMenuItem.Text = "Yeni Durum Ekle";
            this.yeniDurumEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniDurumEkleToolStripMenuItem_Click);
            // 
            // seçiliDurmuGüncelleToolStripMenuItem
            // 
            this.seçiliDurmuGüncelleToolStripMenuItem.Name = "seçiliDurmuGüncelleToolStripMenuItem";
            this.seçiliDurmuGüncelleToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.seçiliDurmuGüncelleToolStripMenuItem.Text = "Seçili Durumu Güncelle";
            this.seçiliDurmuGüncelleToolStripMenuItem.Click += new System.EventHandler(this.seçiliDurmuGüncelleToolStripMenuItem_Click);
            // 
            // seçiliDurumuSilToolStripMenuItem
            // 
            this.seçiliDurumuSilToolStripMenuItem.Name = "seçiliDurumuSilToolStripMenuItem";
            this.seçiliDurumuSilToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.seçiliDurumuSilToolStripMenuItem.Text = "Seçili Durumu Sil";
            this.seçiliDurumuSilToolStripMenuItem.Click += new System.EventHandler(this.seçiliDurumuSilToolStripMenuItem_Click);
            // 
            // contextMenuStripYetkiler
            // 
            this.contextMenuStripYetkiler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniYetkiEkleToolStripMenuItem,
            this.seçiliYetkiyiSilToolStripMenuItem});
            this.contextMenuStripYetkiler.Name = "contextMenuStripYetkiler";
            this.contextMenuStripYetkiler.Size = new System.Drawing.Size(154, 48);
            // 
            // yeniYetkiEkleToolStripMenuItem
            // 
            this.yeniYetkiEkleToolStripMenuItem.Name = "yeniYetkiEkleToolStripMenuItem";
            this.yeniYetkiEkleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.yeniYetkiEkleToolStripMenuItem.Text = "Yeni Yetki Ekle";
            this.yeniYetkiEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniYetkiEkleToolStripMenuItem_Click);
            // 
            // seçiliYetkiyiSilToolStripMenuItem
            // 
            this.seçiliYetkiyiSilToolStripMenuItem.Name = "seçiliYetkiyiSilToolStripMenuItem";
            this.seçiliYetkiyiSilToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.seçiliYetkiyiSilToolStripMenuItem.Text = "Seçili Yetkiyi Sil";
            this.seçiliYetkiyiSilToolStripMenuItem.Click += new System.EventHandler(this.seçiliYetkiyiSilToolStripMenuItem_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMusteriListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMusteriListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriListele.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriListele.Image")));
            this.btnMusteriListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriListele.Location = new System.Drawing.Point(614, 221);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMusteriListele.Size = new System.Drawing.Size(173, 57);
            this.btnMusteriListele.TabIndex = 43;
            this.btnMusteriListele.Text = "   Müşterileri\r\n   Listele";
            this.btnMusteriListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusteriListele.UseVisualStyleBackColor = false;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(793, 221);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button1.Size = new System.Drawing.Size(173, 57);
            this.button1.TabIndex = 44;
            this.button1.Text = "   Adresleri\r\n   Listele";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // contextMenuAdresler
            // 
            this.contextMenuAdresler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adresiSilToolStripMenuItem});
            this.contextMenuAdresler.Name = "contextMenuAdresler";
            this.contextMenuAdresler.Size = new System.Drawing.Size(156, 26);
            this.contextMenuAdresler.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // adresiSilToolStripMenuItem
            // 
            this.adresiSilToolStripMenuItem.Name = "adresiSilToolStripMenuItem";
            this.adresiSilToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.adresiSilToolStripMenuItem.Text = " Seçili Adresi Sil";
            this.adresiSilToolStripMenuItem.Click += new System.EventHandler(this.adresiSilToolStripMenuItem_Click);
            // 
            // cms_Sil
            // 
            this.cms_Sil.Name = "cms_Sil";
            this.cms_Sil.Size = new System.Drawing.Size(163, 22);
            this.cms_Sil.Text = "Yetkiliyi Sil";
            this.cms_Sil.Click += new System.EventHandler(this.cms_Sil_Click);
            // 
            // cMS_Guncelle
            // 
            this.cMS_Guncelle.Name = "cMS_Guncelle";
            this.cMS_Guncelle.Size = new System.Drawing.Size(163, 22);
            this.cMS_Guncelle.Text = "Yetkiliyi Güncelle";
            this.cMS_Guncelle.Click += new System.EventHandler(this.cMS_Guncelle_Click);
            // 
            // cms_yetkiliEkle
            // 
            this.cms_yetkiliEkle.Name = "cms_yetkiliEkle";
            this.cms_yetkiliEkle.Size = new System.Drawing.Size(163, 22);
            this.cms_yetkiliEkle.Text = "Yeni Yetkili Ekle";
            this.cms_yetkiliEkle.Click += new System.EventHandler(this.cms_yetkiliEkle_Click);
            // 
            // contextMenuStripYetkililer
            // 
            this.contextMenuStripYetkililer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_Sil,
            this.cMS_Guncelle,
            this.cms_yetkiliEkle});
            this.contextMenuStripYetkililer.Name = "contextMenuStripYetkililer";
            this.contextMenuStripYetkililer.Size = new System.Drawing.Size(164, 70);
            // 
            // sistemYoneticisiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMusteriListele);
            this.Controls.Add(this.btnRapolar);
            this.Controls.Add(this.btnFaturaListele);
            this.Controls.Add(this.ucretEkle);
            this.Controls.Add(this.btnDurumEkle);
            this.Controls.Add(this.btnYetkiEkle);
            this.Controls.Add(this.btn_durumEkrani);
            this.Controls.Add(this.btn_yetkileriYonet);
            this.Controls.Add(this.btnKargolariListele);
            this.Controls.Add(this.gbAra);
            this.Controls.Add(this.btnUcretlerListesi);
            this.Controls.Add(this.btnYetkiliEkle);
            this.Controls.Add(this.btnSubeEkle);
            this.Controls.Add(this.btnYetkiliListesi);
            this.Controls.Add(this.btnSubeListele);
            this.Controls.Add(this.Main_Grid);
            this.Controls.Add(this.lbl_yetkili_adi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sistemYoneticisiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Yöneticisi Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sistemYoneticisiEkrani_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid)).EndInit();
            this.gbAra.ResumeLayout(false);
            this.gbAra.PerformLayout();
            this.contextMenuStripSubeler.ResumeLayout(false);
            this.contextMenuStripUcretler.ResumeLayout(false);
            this.contextMenuStripDurumlar.ResumeLayout(false);
            this.contextMenuStripYetkiler.ResumeLayout(false);
            this.contextMenuAdresler.ResumeLayout(false);
            this.contextMenuStripYetkililer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_yetkili_adi;
        private System.Windows.Forms.Button btnYetkiliListesi;
        private System.Windows.Forms.Button btnSubeListele;
        private System.Windows.Forms.DataGridView Main_Grid;
        private System.Windows.Forms.Button btnSubeEkle;
        private System.Windows.Forms.Button btnYetkiliEkle;
        private System.Windows.Forms.Button btnUcretlerListesi;
        private System.Windows.Forms.GroupBox gbAra;
        private System.Windows.Forms.TextBox tb_ara;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSubeler;
        private System.Windows.Forms.ToolStripMenuItem şubeyiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şubeyiGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniŞubeEkleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripUcretler;
        private System.Windows.Forms.ToolStripMenuItem ücretGuncelleToolStripMenuItem;
        private System.Windows.Forms.Button btnKargolariListele;
        private System.Windows.Forms.Button btn_yetkileriYonet;
        private System.Windows.Forms.Button btn_durumEkrani;
        private System.Windows.Forms.Button btnYetkiEkle;
        private System.Windows.Forms.Button btnDurumEkle;
        private System.Windows.Forms.Label lbl_ara;
        private System.Windows.Forms.Button ucretEkle;
        private System.Windows.Forms.Button btnFaturaListele;
        private System.Windows.Forms.Button btnRapolar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDurumlar;
        private System.Windows.Forms.ToolStripMenuItem yeniDurumEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliDurmuGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliDurumuSilToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripYetkiler;
        private System.Windows.Forms.ToolStripMenuItem yeniYetkiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliYetkiyiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ücretSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ücretEkleToolStripMenuItem;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuAdresler;
        private System.Windows.Forms.ToolStripMenuItem adresiSilToolStripMenuItem;
        private System.Windows.Forms.Label lblRapor;
        private System.Windows.Forms.ComboBox cbRaporlar;
        private System.Windows.Forms.ToolStripMenuItem cms_Sil;
        private System.Windows.Forms.ToolStripMenuItem cMS_Guncelle;
        private System.Windows.Forms.ToolStripMenuItem cms_yetkiliEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripYetkililer;
    }
}