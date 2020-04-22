namespace WindowsFormsApplication1
{
    partial class subeGuncelle
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
            this.btn_subeEkle = new System.Windows.Forms.Button();
            this.cbSubeIlce = new System.Windows.Forms.ComboBox();
            this.lblSubeIlce = new System.Windows.Forms.Label();
            this.cbSubeSehir = new System.Windows.Forms.ComboBox();
            this.lblSubeSehir = new System.Windows.Forms.Label();
            this.mtbSubeNo = new System.Windows.Forms.MaskedTextBox();
            this.lblSubeAdres = new System.Windows.Forms.Label();
            this.tbSubeAdres = new System.Windows.Forms.TextBox();
            this.mtbSubeTel = new System.Windows.Forms.MaskedTextBox();
            this.lblSubeTel = new System.Windows.Forms.Label();
            this.lbl_subeAdi = new System.Windows.Forms.Label();
            this.tbsubeAdi = new System.Windows.Forms.TextBox();
            this.lbl_subeNo = new System.Windows.Forms.Label();
            this.pb_tick_SubeIlce = new System.Windows.Forms.PictureBox();
            this.pb_tick_subeSehir = new System.Windows.Forms.PictureBox();
            this.pb_tick_subeAdres = new System.Windows.Forms.PictureBox();
            this.pb_tick_subeTel = new System.Windows.Forms.PictureBox();
            this.pb_tick_subeNo = new System.Windows.Forms.PictureBox();
            this.pb_tick_subeAdi = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_SubeIlce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeSehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeAdi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_subeEkle
            // 
            this.btn_subeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_subeEkle.Location = new System.Drawing.Point(98, 394);
            this.btn_subeEkle.Name = "btn_subeEkle";
            this.btn_subeEkle.Size = new System.Drawing.Size(405, 33);
            this.btn_subeEkle.TabIndex = 91;
            this.btn_subeEkle.Text = "Şube Güncelle";
            this.btn_subeEkle.UseVisualStyleBackColor = true;
            this.btn_subeEkle.Click += new System.EventHandler(this.btn_subeEkle_Click);
            // 
            // cbSubeIlce
            // 
            this.cbSubeIlce.DropDownHeight = 150;
            this.cbSubeIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubeIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSubeIlce.FormattingEnabled = true;
            this.cbSubeIlce.IntegralHeight = false;
            this.cbSubeIlce.Location = new System.Drawing.Point(196, 238);
            this.cbSubeIlce.Name = "cbSubeIlce";
            this.cbSubeIlce.Size = new System.Drawing.Size(239, 26);
            this.cbSubeIlce.TabIndex = 89;
            this.cbSubeIlce.SelectedIndexChanged += new System.EventHandler(this.cbSubeIlce_SelectedIndexChanged);
            // 
            // lblSubeIlce
            // 
            this.lblSubeIlce.AutoSize = true;
            this.lblSubeIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeIlce.Location = new System.Drawing.Point(94, 240);
            this.lblSubeIlce.Name = "lblSubeIlce";
            this.lblSubeIlce.Size = new System.Drawing.Size(90, 20);
            this.lblSubeIlce.TabIndex = 88;
            this.lblSubeIlce.Text = "Şube İlçe:";
            // 
            // cbSubeSehir
            // 
            this.cbSubeSehir.DropDownHeight = 150;
            this.cbSubeSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubeSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSubeSehir.FormattingEnabled = true;
            this.cbSubeSehir.IntegralHeight = false;
            this.cbSubeSehir.Items.AddRange(new object[] {
            "Şehir Seçiniz...",
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cbSubeSehir.Location = new System.Drawing.Point(196, 200);
            this.cbSubeSehir.Name = "cbSubeSehir";
            this.cbSubeSehir.Size = new System.Drawing.Size(239, 26);
            this.cbSubeSehir.TabIndex = 86;
            this.cbSubeSehir.SelectedIndexChanged += new System.EventHandler(this.cbSubeSehir_SelectedIndexChanged);
            // 
            // lblSubeSehir
            // 
            this.lblSubeSehir.AutoSize = true;
            this.lblSubeSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeSehir.Location = new System.Drawing.Point(81, 202);
            this.lblSubeSehir.Name = "lblSubeSehir";
            this.lblSubeSehir.Size = new System.Drawing.Size(103, 20);
            this.lblSubeSehir.TabIndex = 85;
            this.lblSubeSehir.Text = "Şube Şehir:";
            // 
            // mtbSubeNo
            // 
            this.mtbSubeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbSubeNo.Location = new System.Drawing.Point(196, 100);
            this.mtbSubeNo.Mask = "00000";
            this.mtbSubeNo.Name = "mtbSubeNo";
            this.mtbSubeNo.ReadOnly = true;
            this.mtbSubeNo.Size = new System.Drawing.Size(239, 24);
            this.mtbSubeNo.TabIndex = 77;
            this.mtbSubeNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbSubeNo.ValidatingType = typeof(int);
            this.mtbSubeNo.TextChanged += new System.EventHandler(this.mtbSubeNo_TextChanged);
            // 
            // lblSubeAdres
            // 
            this.lblSubeAdres.AutoSize = true;
            this.lblSubeAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeAdres.Location = new System.Drawing.Point(116, 273);
            this.lblSubeAdres.Name = "lblSubeAdres";
            this.lblSubeAdres.Size = new System.Drawing.Size(61, 20);
            this.lblSubeAdres.TabIndex = 76;
            this.lblSubeAdres.Text = "Adres:";
            // 
            // tbSubeAdres
            // 
            this.tbSubeAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSubeAdres.Location = new System.Drawing.Point(196, 270);
            this.tbSubeAdres.Multiline = true;
            this.tbSubeAdres.Name = "tbSubeAdres";
            this.tbSubeAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSubeAdres.Size = new System.Drawing.Size(239, 78);
            this.tbSubeAdres.TabIndex = 75;
            this.tbSubeAdres.TextChanged += new System.EventHandler(this.tbSubeAdres_TextChanged);
            // 
            // mtbSubeTel
            // 
            this.mtbSubeTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbSubeTel.Location = new System.Drawing.Point(196, 168);
            this.mtbSubeTel.Mask = "000-000-0000";
            this.mtbSubeTel.Name = "mtbSubeTel";
            this.mtbSubeTel.Size = new System.Drawing.Size(239, 26);
            this.mtbSubeTel.TabIndex = 74;
            this.mtbSubeTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbSubeTel.TextChanged += new System.EventHandler(this.mtbSubeTel_TextChanged);
            // 
            // lblSubeTel
            // 
            this.lblSubeTel.AutoSize = true;
            this.lblSubeTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeTel.Location = new System.Drawing.Point(99, 171);
            this.lblSubeTel.Name = "lblSubeTel";
            this.lblSubeTel.Size = new System.Drawing.Size(85, 20);
            this.lblSubeTel.TabIndex = 73;
            this.lblSubeTel.Text = "Şube Tel:";
            // 
            // lbl_subeAdi
            // 
            this.lbl_subeAdi.AutoSize = true;
            this.lbl_subeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_subeAdi.Location = new System.Drawing.Point(99, 139);
            this.lbl_subeAdi.Name = "lbl_subeAdi";
            this.lbl_subeAdi.Size = new System.Drawing.Size(87, 20);
            this.lbl_subeAdi.TabIndex = 72;
            this.lbl_subeAdi.Text = "Şube Adı:";
            // 
            // tbsubeAdi
            // 
            this.tbsubeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsubeAdi.Location = new System.Drawing.Point(196, 136);
            this.tbsubeAdi.Name = "tbsubeAdi";
            this.tbsubeAdi.Size = new System.Drawing.Size(239, 26);
            this.tbsubeAdi.TabIndex = 71;
            this.tbsubeAdi.TextChanged += new System.EventHandler(this.tbsubeAdi_TextChanged);
            // 
            // lbl_subeNo
            // 
            this.lbl_subeNo.AutoSize = true;
            this.lbl_subeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_subeNo.Location = new System.Drawing.Point(103, 104);
            this.lbl_subeNo.Name = "lbl_subeNo";
            this.lbl_subeNo.Size = new System.Drawing.Size(83, 20);
            this.lbl_subeNo.TabIndex = 70;
            this.lbl_subeNo.Text = "Şube No:";
            // 
            // pb_tick_SubeIlce
            // 
            this.pb_tick_SubeIlce.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_SubeIlce.Location = new System.Drawing.Point(441, 239);
            this.pb_tick_SubeIlce.Name = "pb_tick_SubeIlce";
            this.pb_tick_SubeIlce.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_SubeIlce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_SubeIlce.TabIndex = 90;
            this.pb_tick_SubeIlce.TabStop = false;
            // 
            // pb_tick_subeSehir
            // 
            this.pb_tick_subeSehir.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_subeSehir.Location = new System.Drawing.Point(441, 201);
            this.pb_tick_subeSehir.Name = "pb_tick_subeSehir";
            this.pb_tick_subeSehir.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_subeSehir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_subeSehir.TabIndex = 87;
            this.pb_tick_subeSehir.TabStop = false;
            // 
            // pb_tick_subeAdres
            // 
            this.pb_tick_subeAdres.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_subeAdres.Location = new System.Drawing.Point(441, 270);
            this.pb_tick_subeAdres.Name = "pb_tick_subeAdres";
            this.pb_tick_subeAdres.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_subeAdres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_subeAdres.TabIndex = 81;
            this.pb_tick_subeAdres.TabStop = false;
            this.pb_tick_subeAdres.Visible = false;
            // 
            // pb_tick_subeTel
            // 
            this.pb_tick_subeTel.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_subeTel.Location = new System.Drawing.Point(441, 168);
            this.pb_tick_subeTel.Name = "pb_tick_subeTel";
            this.pb_tick_subeTel.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_subeTel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_subeTel.TabIndex = 80;
            this.pb_tick_subeTel.TabStop = false;
            this.pb_tick_subeTel.Visible = false;
            // 
            // pb_tick_subeNo
            // 
            this.pb_tick_subeNo.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_subeNo.Location = new System.Drawing.Point(441, 102);
            this.pb_tick_subeNo.Name = "pb_tick_subeNo";
            this.pb_tick_subeNo.Size = new System.Drawing.Size(33, 24);
            this.pb_tick_subeNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_subeNo.TabIndex = 79;
            this.pb_tick_subeNo.TabStop = false;
            this.pb_tick_subeNo.Visible = false;
            // 
            // pb_tick_subeAdi
            // 
            this.pb_tick_subeAdi.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_subeAdi.Location = new System.Drawing.Point(441, 136);
            this.pb_tick_subeAdi.Name = "pb_tick_subeAdi";
            this.pb_tick_subeAdi.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_subeAdi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_subeAdi.TabIndex = 78;
            this.pb_tick_subeAdi.TabStop = false;
            this.pb_tick_subeAdi.Visible = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(201, 45);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(191, 31);
            this.lblBaslik.TabIndex = 92;
            this.lblBaslik.Text = "Şube Güncelle";
            // 
            // subeGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 480);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btn_subeEkle);
            this.Controls.Add(this.pb_tick_SubeIlce);
            this.Controls.Add(this.cbSubeIlce);
            this.Controls.Add(this.lblSubeIlce);
            this.Controls.Add(this.pb_tick_subeSehir);
            this.Controls.Add(this.cbSubeSehir);
            this.Controls.Add(this.lblSubeSehir);
            this.Controls.Add(this.pb_tick_subeAdres);
            this.Controls.Add(this.pb_tick_subeTel);
            this.Controls.Add(this.pb_tick_subeNo);
            this.Controls.Add(this.pb_tick_subeAdi);
            this.Controls.Add(this.mtbSubeNo);
            this.Controls.Add(this.lblSubeAdres);
            this.Controls.Add(this.tbSubeAdres);
            this.Controls.Add(this.mtbSubeTel);
            this.Controls.Add(this.lblSubeTel);
            this.Controls.Add(this.lbl_subeAdi);
            this.Controls.Add(this.tbsubeAdi);
            this.Controls.Add(this.lbl_subeNo);
            this.Name = "subeGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şube Güncelle";
            this.Load += new System.EventHandler(this.subeGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_SubeIlce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeSehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeAdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_subeEkle;
        private System.Windows.Forms.PictureBox pb_tick_SubeIlce;
        private System.Windows.Forms.ComboBox cbSubeIlce;
        private System.Windows.Forms.Label lblSubeIlce;
        private System.Windows.Forms.PictureBox pb_tick_subeSehir;
        private System.Windows.Forms.ComboBox cbSubeSehir;
        private System.Windows.Forms.Label lblSubeSehir;
        private System.Windows.Forms.PictureBox pb_tick_subeAdres;
        private System.Windows.Forms.PictureBox pb_tick_subeTel;
        private System.Windows.Forms.PictureBox pb_tick_subeNo;
        private System.Windows.Forms.PictureBox pb_tick_subeAdi;
        private System.Windows.Forms.MaskedTextBox mtbSubeNo;
        private System.Windows.Forms.Label lblSubeAdres;
        private System.Windows.Forms.TextBox tbSubeAdres;
        private System.Windows.Forms.MaskedTextBox mtbSubeTel;
        private System.Windows.Forms.Label lblSubeTel;
        private System.Windows.Forms.Label lbl_subeAdi;
        private System.Windows.Forms.TextBox tbsubeAdi;
        private System.Windows.Forms.Label lbl_subeNo;
        private System.Windows.Forms.Label lblBaslik;
    }
}