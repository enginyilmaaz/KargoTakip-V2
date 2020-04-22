namespace WindowsFormsApplication1
{
    partial class yetkiliGuncelle
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.mtb_tc_no = new System.Windows.Forms.MaskedTextBox();
            this.lbl_gizli_soru_cevabi = new System.Windows.Forms.Label();
            this.tb_gizli_soru_cevabi = new System.Windows.Forms.TextBox();
            this.lbl_sifre_tekrar = new System.Windows.Forms.Label();
            this.tb_sifre_tekrar = new System.Windows.Forms.TextBox();
            this.lbl_gizli_soru = new System.Windows.Forms.Label();
            this.cb_gizli_soru = new System.Windows.Forms.ComboBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.tb_eposta = new System.Windows.Forms.TextBox();
            this.btn_yetkili_ekle = new System.Windows.Forms.Button();
            this.mtb_telefon_no = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telefon_no = new System.Windows.Forms.Label();
            this.lbl_yetki_turu = new System.Windows.Forms.Label();
            this.lbl_ad_soyad = new System.Windows.Forms.Label();
            this.lbl_tc_no = new System.Windows.Forms.Label();
            this.pb_tick_gizlisorucevabi = new System.Windows.Forms.PictureBox();
            this.pb_tick_gizlisoru = new System.Windows.Forms.PictureBox();
            this.pb_tick_sifretekrar = new System.Windows.Forms.PictureBox();
            this.pb_tick_sifre = new System.Windows.Forms.PictureBox();
            this.pb_tick_yetkituru = new System.Windows.Forms.PictureBox();
            this.pb_tick_eposta = new System.Windows.Forms.PictureBox();
            this.pb_tick_telefonno = new System.Windows.Forms.PictureBox();
            this.pb_tick_tcno = new System.Windows.Forms.PictureBox();
            this.pb_tick_adsoyad = new System.Windows.Forms.PictureBox();
            this.pb_gizli_soru_cevabi = new System.Windows.Forms.PictureBox();
            this.pb_sifre_tekrar = new System.Windows.Forms.PictureBox();
            this.pb_sifreyi_goster = new System.Windows.Forms.PictureBox();
            this.pb_tick_cinsiyet = new System.Windows.Forms.PictureBox();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.pb_tick_susbe = new System.Windows.Forms.PictureBox();
            this.lblSube = new System.Windows.Forms.Label();
            this.tb_ad_soyad = new System.Windows.Forms.TextBox();
            this.tbCinsiyet = new System.Windows.Forms.TextBox();
            this.cb_yetki_turu = new System.Windows.Forms.ComboBox();
            this.cbSube = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_gizlisorucevabi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_gizlisoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_sifretekrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_sifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_yetkituru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_eposta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_telefonno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_tcno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_adsoyad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gizli_soru_cevabi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sifre_tekrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sifreyi_goster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_cinsiyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_susbe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(390, 42);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(201, 31);
            this.lblBaslik.TabIndex = 73;
            this.lblBaslik.Text = "Yetkili Güncelle";
            // 
            // mtb_tc_no
            // 
            this.mtb_tc_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtb_tc_no.Location = new System.Drawing.Point(172, 115);
            this.mtb_tc_no.Mask = "00000000000";
            this.mtb_tc_no.Name = "mtb_tc_no";
            this.mtb_tc_no.ReadOnly = true;
            this.mtb_tc_no.Size = new System.Drawing.Size(239, 24);
            this.mtb_tc_no.TabIndex = 59;
            this.mtb_tc_no.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtb_tc_no_MaskInputRejected);
            this.mtb_tc_no.TextChanged += new System.EventHandler(this.mtb_tc_no_TextChanged);
            // 
            // lbl_gizli_soru_cevabi
            // 
            this.lbl_gizli_soru_cevabi.AutoSize = true;
            this.lbl_gizli_soru_cevabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gizli_soru_cevabi.Location = new System.Drawing.Point(473, 295);
            this.lbl_gizli_soru_cevabi.Name = "lbl_gizli_soru_cevabi";
            this.lbl_gizli_soru_cevabi.Size = new System.Drawing.Size(151, 20);
            this.lbl_gizli_soru_cevabi.TabIndex = 58;
            this.lbl_gizli_soru_cevabi.Text = "Gizli Soru Cevabı:";
            // 
            // tb_gizli_soru_cevabi
            // 
            this.tb_gizli_soru_cevabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_gizli_soru_cevabi.Location = new System.Drawing.Point(643, 291);
            this.tb_gizli_soru_cevabi.Name = "tb_gizli_soru_cevabi";
            this.tb_gizli_soru_cevabi.PasswordChar = '●';
            this.tb_gizli_soru_cevabi.Size = new System.Drawing.Size(239, 26);
            this.tb_gizli_soru_cevabi.TabIndex = 57;
            this.tb_gizli_soru_cevabi.TextChanged += new System.EventHandler(this.tb_gizli_soru_cevabi_TextChanged);
            // 
            // lbl_sifre_tekrar
            // 
            this.lbl_sifre_tekrar.AutoSize = true;
            this.lbl_sifre_tekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre_tekrar.Location = new System.Drawing.Point(511, 261);
            this.lbl_sifre_tekrar.Name = "lbl_sifre_tekrar";
            this.lbl_sifre_tekrar.Size = new System.Drawing.Size(113, 20);
            this.lbl_sifre_tekrar.TabIndex = 56;
            this.lbl_sifre_tekrar.Text = " Şifre Tekrar:";
            // 
            // tb_sifre_tekrar
            // 
            this.tb_sifre_tekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sifre_tekrar.Location = new System.Drawing.Point(643, 259);
            this.tb_sifre_tekrar.Name = "tb_sifre_tekrar";
            this.tb_sifre_tekrar.PasswordChar = '●';
            this.tb_sifre_tekrar.Size = new System.Drawing.Size(239, 26);
            this.tb_sifre_tekrar.TabIndex = 55;
            this.tb_sifre_tekrar.TextChanged += new System.EventHandler(this.tb_sifre_tekrar_TextChanged);
            // 
            // lbl_gizli_soru
            // 
            this.lbl_gizli_soru.AutoSize = true;
            this.lbl_gizli_soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gizli_soru.Location = new System.Drawing.Point(62, 291);
            this.lbl_gizli_soru.Name = "lbl_gizli_soru";
            this.lbl_gizli_soru.Size = new System.Drawing.Size(92, 20);
            this.lbl_gizli_soru.TabIndex = 54;
            this.lbl_gizli_soru.Text = "Gizli Soru:";
            // 
            // cb_gizli_soru
            // 
            this.cb_gizli_soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_gizli_soru.FormattingEnabled = true;
            this.cb_gizli_soru.Items.AddRange(new object[] {
            "Seçiniz...",
            "En sevdiğiniz öğretmen kim",
            "Annenizin doğum yeri neresi",
            "En sevdiğiniz çocukluk arkadaşınız kim",
            "Hangi lisede okudunuz",
            "Favori tv kanalınız nedir",
            "İlkokuldaki sınıf öğtetmeniniz kimdi",
            "Tarihteki en sevdiğiniz kişi kim",
            "En çok izlediğiniz program türü nedir",
            "Taraftarı olduğunuz takım hangisi",
            "En sevdiğiniz dizinin adı nedir",
            "En sevdiğiniz oyun hangisi",
            "Sizin doğum yeriniz neresi",
            "İlk aşkınızın adı neydi",
            "Hangi ilkokula gittiniz",
            "Hangi üniversitede okudunuz",
            "En sevdiğiniz öğretmeninizin adı nedir",
            "En sevdiğiniz filmin adı nedir"});
            this.cb_gizli_soru.Location = new System.Drawing.Point(172, 289);
            this.cb_gizli_soru.Name = "cb_gizli_soru";
            this.cb_gizli_soru.Size = new System.Drawing.Size(239, 26);
            this.cb_gizli_soru.TabIndex = 53;
            this.cb_gizli_soru.TextChanged += new System.EventHandler(this.cb_gizli_soru_TextChanged);
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(572, 225);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(52, 20);
            this.lbl_sifre.TabIndex = 52;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // tb_sifre
            // 
            this.tb_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sifre.Location = new System.Drawing.Point(643, 223);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.PasswordChar = '●';
            this.tb_sifre.Size = new System.Drawing.Size(239, 26);
            this.tb_sifre.TabIndex = 51;
            this.tb_sifre.TextChanged += new System.EventHandler(this.tb_sifre_TextChanged);
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_eposta.Location = new System.Drawing.Point(553, 189);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(71, 20);
            this.lbl_eposta.TabIndex = 50;
            this.lbl_eposta.Text = "Eposta:";
            // 
            // tb_eposta
            // 
            this.tb_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_eposta.Location = new System.Drawing.Point(643, 187);
            this.tb_eposta.Name = "tb_eposta";
            this.tb_eposta.Size = new System.Drawing.Size(239, 26);
            this.tb_eposta.TabIndex = 49;
            this.tb_eposta.TextChanged += new System.EventHandler(this.tb_eposta_TextChanged);
            // 
            // btn_yetkili_ekle
            // 
            this.btn_yetkili_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetkili_ekle.Location = new System.Drawing.Point(146, 387);
            this.btn_yetkili_ekle.Name = "btn_yetkili_ekle";
            this.btn_yetkili_ekle.Size = new System.Drawing.Size(681, 35);
            this.btn_yetkili_ekle.TabIndex = 46;
            this.btn_yetkili_ekle.Text = "Güncelleştir";
            this.btn_yetkili_ekle.UseVisualStyleBackColor = true;
            this.btn_yetkili_ekle.Click += new System.EventHandler(this.btn_yetkili_ekle_Click);
            // 
            // mtb_telefon_no
            // 
            this.mtb_telefon_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtb_telefon_no.Location = new System.Drawing.Point(172, 243);
            this.mtb_telefon_no.Mask = "000-000-0000";
            this.mtb_telefon_no.Name = "mtb_telefon_no";
            this.mtb_telefon_no.Size = new System.Drawing.Size(239, 26);
            this.mtb_telefon_no.TabIndex = 45;
            this.mtb_telefon_no.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtb_telefon_no.TextChanged += new System.EventHandler(this.mtb_telefon_no_TextChanged);
            // 
            // lbl_telefon_no
            // 
            this.lbl_telefon_no.AutoSize = true;
            this.lbl_telefon_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telefon_no.Location = new System.Drawing.Point(52, 234);
            this.lbl_telefon_no.Name = "lbl_telefon_no";
            this.lbl_telefon_no.Size = new System.Drawing.Size(101, 20);
            this.lbl_telefon_no.TabIndex = 43;
            this.lbl_telefon_no.Text = "Telefon No:";
            // 
            // lbl_yetki_turu
            // 
            this.lbl_yetki_turu.AutoSize = true;
            this.lbl_yetki_turu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yetki_turu.Location = new System.Drawing.Point(528, 117);
            this.lbl_yetki_turu.Name = "lbl_yetki_turu";
            this.lbl_yetki_turu.Size = new System.Drawing.Size(96, 20);
            this.lbl_yetki_turu.TabIndex = 42;
            this.lbl_yetki_turu.Text = "Yetki Türü:";
            // 
            // lbl_ad_soyad
            // 
            this.lbl_ad_soyad.AutoSize = true;
            this.lbl_ad_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad_soyad.Location = new System.Drawing.Point(62, 200);
            this.lbl_ad_soyad.Name = "lbl_ad_soyad";
            this.lbl_ad_soyad.Size = new System.Drawing.Size(91, 20);
            this.lbl_ad_soyad.TabIndex = 41;
            this.lbl_ad_soyad.Text = "Ad Soyad:";
            // 
            // lbl_tc_no
            // 
            this.lbl_tc_no.AutoSize = true;
            this.lbl_tc_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tc_no.Location = new System.Drawing.Point(39, 117);
            this.lbl_tc_no.Name = "lbl_tc_no";
            this.lbl_tc_no.Size = new System.Drawing.Size(114, 20);
            this.lbl_tc_no.TabIndex = 39;
            this.lbl_tc_no.Text = "TC Kimlik No:";
            // 
            // pb_tick_gizlisorucevabi
            // 
            this.pb_tick_gizlisorucevabi.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_gizlisorucevabi.Location = new System.Drawing.Point(921, 291);
            this.pb_tick_gizlisorucevabi.Name = "pb_tick_gizlisorucevabi";
            this.pb_tick_gizlisorucevabi.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_gizlisorucevabi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_gizlisorucevabi.TabIndex = 72;
            this.pb_tick_gizlisorucevabi.TabStop = false;
            this.pb_tick_gizlisorucevabi.Visible = false;
            // 
            // pb_tick_gizlisoru
            // 
            this.pb_tick_gizlisoru.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_gizlisoru.Location = new System.Drawing.Point(417, 289);
            this.pb_tick_gizlisoru.Name = "pb_tick_gizlisoru";
            this.pb_tick_gizlisoru.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_gizlisoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_gizlisoru.TabIndex = 71;
            this.pb_tick_gizlisoru.TabStop = false;
            this.pb_tick_gizlisoru.Visible = false;
            // 
            // pb_tick_sifretekrar
            // 
            this.pb_tick_sifretekrar.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_sifretekrar.Location = new System.Drawing.Point(921, 259);
            this.pb_tick_sifretekrar.Name = "pb_tick_sifretekrar";
            this.pb_tick_sifretekrar.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_sifretekrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_sifretekrar.TabIndex = 70;
            this.pb_tick_sifretekrar.TabStop = false;
            this.pb_tick_sifretekrar.Visible = false;
            // 
            // pb_tick_sifre
            // 
            this.pb_tick_sifre.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_sifre.Location = new System.Drawing.Point(921, 223);
            this.pb_tick_sifre.Name = "pb_tick_sifre";
            this.pb_tick_sifre.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_sifre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_sifre.TabIndex = 69;
            this.pb_tick_sifre.TabStop = false;
            this.pb_tick_sifre.Visible = false;
            // 
            // pb_tick_yetkituru
            // 
            this.pb_tick_yetkituru.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_yetkituru.Location = new System.Drawing.Point(888, 115);
            this.pb_tick_yetkituru.Name = "pb_tick_yetkituru";
            this.pb_tick_yetkituru.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_yetkituru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_yetkituru.TabIndex = 68;
            this.pb_tick_yetkituru.TabStop = false;
            // 
            // pb_tick_eposta
            // 
            this.pb_tick_eposta.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_eposta.Location = new System.Drawing.Point(888, 187);
            this.pb_tick_eposta.Name = "pb_tick_eposta";
            this.pb_tick_eposta.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_eposta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_eposta.TabIndex = 67;
            this.pb_tick_eposta.TabStop = false;
            this.pb_tick_eposta.Visible = false;
            // 
            // pb_tick_telefonno
            // 
            this.pb_tick_telefonno.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_telefonno.Location = new System.Drawing.Point(417, 243);
            this.pb_tick_telefonno.Name = "pb_tick_telefonno";
            this.pb_tick_telefonno.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_telefonno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_telefonno.TabIndex = 65;
            this.pb_tick_telefonno.TabStop = false;
            this.pb_tick_telefonno.Visible = false;
            // 
            // pb_tick_tcno
            // 
            this.pb_tick_tcno.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_tcno.Location = new System.Drawing.Point(417, 117);
            this.pb_tick_tcno.Name = "pb_tick_tcno";
            this.pb_tick_tcno.Size = new System.Drawing.Size(33, 24);
            this.pb_tick_tcno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_tcno.TabIndex = 64;
            this.pb_tick_tcno.TabStop = false;
            // 
            // pb_tick_adsoyad
            // 
            this.pb_tick_adsoyad.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_adsoyad.Location = new System.Drawing.Point(417, 200);
            this.pb_tick_adsoyad.Name = "pb_tick_adsoyad";
            this.pb_tick_adsoyad.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_adsoyad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_adsoyad.TabIndex = 63;
            this.pb_tick_adsoyad.TabStop = false;
            // 
            // pb_gizli_soru_cevabi
            // 
            this.pb_gizli_soru_cevabi.Image = global::WindowsFormsApplication1.Properties.Resources.unlock;
            this.pb_gizli_soru_cevabi.Location = new System.Drawing.Point(888, 291);
            this.pb_gizli_soru_cevabi.Name = "pb_gizli_soru_cevabi";
            this.pb_gizli_soru_cevabi.Size = new System.Drawing.Size(27, 26);
            this.pb_gizli_soru_cevabi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_gizli_soru_cevabi.TabIndex = 62;
            this.pb_gizli_soru_cevabi.TabStop = false;
            this.pb_gizli_soru_cevabi.MouseLeave += new System.EventHandler(this.pb_gizli_soru_cevabi_MouseLeave);
            this.pb_gizli_soru_cevabi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_gizli_soru_cevabi_MouseMove);
            // 
            // pb_sifre_tekrar
            // 
            this.pb_sifre_tekrar.Image = global::WindowsFormsApplication1.Properties.Resources.unlock;
            this.pb_sifre_tekrar.Location = new System.Drawing.Point(888, 259);
            this.pb_sifre_tekrar.Name = "pb_sifre_tekrar";
            this.pb_sifre_tekrar.Size = new System.Drawing.Size(27, 26);
            this.pb_sifre_tekrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_sifre_tekrar.TabIndex = 61;
            this.pb_sifre_tekrar.TabStop = false;
            this.pb_sifre_tekrar.MouseLeave += new System.EventHandler(this.pb_sifre_tekrar_MouseLeave);
            this.pb_sifre_tekrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_sifre_tekrar_MouseMove);
            // 
            // pb_sifreyi_goster
            // 
            this.pb_sifreyi_goster.Image = global::WindowsFormsApplication1.Properties.Resources.unlock;
            this.pb_sifreyi_goster.Location = new System.Drawing.Point(888, 223);
            this.pb_sifreyi_goster.Name = "pb_sifreyi_goster";
            this.pb_sifreyi_goster.Size = new System.Drawing.Size(27, 26);
            this.pb_sifreyi_goster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_sifreyi_goster.TabIndex = 60;
            this.pb_sifreyi_goster.TabStop = false;
            this.pb_sifreyi_goster.MouseLeave += new System.EventHandler(this.pb_sifreyi_goster_MouseLeave);
            this.pb_sifreyi_goster.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_sifreyi_goster_MouseMove);
            // 
            // pb_tick_cinsiyet
            // 
            this.pb_tick_cinsiyet.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_cinsiyet.Location = new System.Drawing.Point(417, 154);
            this.pb_tick_cinsiyet.Name = "pb_tick_cinsiyet";
            this.pb_tick_cinsiyet.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_cinsiyet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_cinsiyet.TabIndex = 76;
            this.pb_tick_cinsiyet.TabStop = false;
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(76, 157);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(77, 20);
            this.lbl_cinsiyet.TabIndex = 74;
            this.lbl_cinsiyet.Text = "Cinsiyet:";
            // 
            // pb_tick_susbe
            // 
            this.pb_tick_susbe.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_susbe.Location = new System.Drawing.Point(888, 151);
            this.pb_tick_susbe.Name = "pb_tick_susbe";
            this.pb_tick_susbe.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_susbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_susbe.TabIndex = 79;
            this.pb_tick_susbe.TabStop = false;
            // 
            // lblSube
            // 
            this.lblSube.AutoSize = true;
            this.lblSube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSube.Location = new System.Drawing.Point(568, 153);
            this.lblSube.Name = "lblSube";
            this.lblSube.Size = new System.Drawing.Size(56, 20);
            this.lblSube.TabIndex = 77;
            this.lblSube.Text = "Şube:";
            // 
            // tb_ad_soyad
            // 
            this.tb_ad_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_ad_soyad.Location = new System.Drawing.Point(172, 200);
            this.tb_ad_soyad.Name = "tb_ad_soyad";
            this.tb_ad_soyad.Size = new System.Drawing.Size(239, 26);
            this.tb_ad_soyad.TabIndex = 40;
            this.tb_ad_soyad.TextChanged += new System.EventHandler(this.tb_ad_soyad_TextChanged);
            this.tb_ad_soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ad_soyad_KeyPress);
            // 
            // tbCinsiyet
            // 
            this.tbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCinsiyet.Location = new System.Drawing.Point(172, 154);
            this.tbCinsiyet.Name = "tbCinsiyet";
            this.tbCinsiyet.ReadOnly = true;
            this.tbCinsiyet.Size = new System.Drawing.Size(239, 26);
            this.tbCinsiyet.TabIndex = 82;
            this.tbCinsiyet.TextChanged += new System.EventHandler(this.tbCinsiyet_TextChanged);
            // 
            // cb_yetki_turu
            // 
            this.cb_yetki_turu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_yetki_turu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_yetki_turu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_yetki_turu.FormattingEnabled = true;
            this.cb_yetki_turu.Items.AddRange(new object[] {
            "Seçiniz...",
            "En sevdiğiniz öğretmen kim",
            "Annenizin doğum yeri neresi",
            "En sevdiğiniz çocukluk arkadaşınız kim",
            "Hangi lisede okudunuz",
            "Favori tv kanalınız nedir",
            "İlkokuldaki sınıf öğtetmeniniz kimdi",
            "Tarihteki en sevdiğiniz kişi kim",
            "En çok izlediğiniz program türü nedir",
            "Taraftarı olduğunuz takım hangisi",
            "En sevdiğiniz dizinin adı nedir",
            "En sevdiğiniz oyun hangisi",
            "Sizin doğum yeriniz neresi",
            "İlk aşkınızın adı neydi",
            "Hangi ilkokula gittiniz",
            "Hangi üniversitede okudunuz",
            "En sevdiğiniz öğretmeninizin adı nedir",
            "En sevdiğiniz filmin adı nedir"});
            this.cb_yetki_turu.Location = new System.Drawing.Point(643, 115);
            this.cb_yetki_turu.Name = "cb_yetki_turu";
            this.cb_yetki_turu.Size = new System.Drawing.Size(239, 26);
            this.cb_yetki_turu.TabIndex = 83;
            // 
            // cbSube
            // 
            this.cbSube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSube.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSube.FormattingEnabled = true;
            this.cbSube.Items.AddRange(new object[] {
            "Seçiniz...",
            "En sevdiğiniz öğretmen kim",
            "Annenizin doğum yeri neresi",
            "En sevdiğiniz çocukluk arkadaşınız kim",
            "Hangi lisede okudunuz",
            "Favori tv kanalınız nedir",
            "İlkokuldaki sınıf öğtetmeniniz kimdi",
            "Tarihteki en sevdiğiniz kişi kim",
            "En çok izlediğiniz program türü nedir",
            "Taraftarı olduğunuz takım hangisi",
            "En sevdiğiniz dizinin adı nedir",
            "En sevdiğiniz oyun hangisi",
            "Sizin doğum yeriniz neresi",
            "İlk aşkınızın adı neydi",
            "Hangi ilkokula gittiniz",
            "Hangi üniversitede okudunuz",
            "En sevdiğiniz öğretmeninizin adı nedir",
            "En sevdiğiniz filmin adı nedir"});
            this.cbSube.Location = new System.Drawing.Point(643, 151);
            this.cbSube.Name = "cbSube";
            this.cbSube.Size = new System.Drawing.Size(239, 26);
            this.cbSube.TabIndex = 84;
            // 
            // yetkiliGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 451);
            this.Controls.Add(this.cbSube);
            this.Controls.Add(this.cb_yetki_turu);
            this.Controls.Add(this.tbCinsiyet);
            this.Controls.Add(this.pb_tick_susbe);
            this.Controls.Add(this.lblSube);
            this.Controls.Add(this.pb_tick_cinsiyet);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.pb_tick_gizlisorucevabi);
            this.Controls.Add(this.pb_tick_gizlisoru);
            this.Controls.Add(this.pb_tick_sifretekrar);
            this.Controls.Add(this.pb_tick_sifre);
            this.Controls.Add(this.pb_tick_yetkituru);
            this.Controls.Add(this.pb_tick_eposta);
            this.Controls.Add(this.pb_tick_telefonno);
            this.Controls.Add(this.pb_tick_tcno);
            this.Controls.Add(this.pb_tick_adsoyad);
            this.Controls.Add(this.pb_gizli_soru_cevabi);
            this.Controls.Add(this.pb_sifre_tekrar);
            this.Controls.Add(this.pb_sifreyi_goster);
            this.Controls.Add(this.mtb_tc_no);
            this.Controls.Add(this.lbl_gizli_soru_cevabi);
            this.Controls.Add(this.tb_gizli_soru_cevabi);
            this.Controls.Add(this.lbl_sifre_tekrar);
            this.Controls.Add(this.tb_sifre_tekrar);
            this.Controls.Add(this.lbl_gizli_soru);
            this.Controls.Add(this.cb_gizli_soru);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.lbl_eposta);
            this.Controls.Add(this.tb_eposta);
            this.Controls.Add(this.btn_yetkili_ekle);
            this.Controls.Add(this.mtb_telefon_no);
            this.Controls.Add(this.lbl_telefon_no);
            this.Controls.Add(this.lbl_yetki_turu);
            this.Controls.Add(this.lbl_ad_soyad);
            this.Controls.Add(this.tb_ad_soyad);
            this.Controls.Add(this.lbl_tc_no);
            this.Name = "yetkiliGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yetkiliGuncelle";
            this.Load += new System.EventHandler(this.yetkiliGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_gizlisorucevabi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_gizlisoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_sifretekrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_sifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_yetkituru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_eposta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_telefonno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_tcno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_adsoyad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gizli_soru_cevabi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sifre_tekrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sifreyi_goster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_cinsiyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_susbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.PictureBox pb_tick_gizlisorucevabi;
        private System.Windows.Forms.PictureBox pb_tick_gizlisoru;
        private System.Windows.Forms.PictureBox pb_tick_sifretekrar;
        private System.Windows.Forms.PictureBox pb_tick_sifre;
        private System.Windows.Forms.PictureBox pb_tick_yetkituru;
        private System.Windows.Forms.PictureBox pb_tick_eposta;
        private System.Windows.Forms.PictureBox pb_tick_telefonno;
        private System.Windows.Forms.PictureBox pb_tick_tcno;
        private System.Windows.Forms.PictureBox pb_tick_adsoyad;
        private System.Windows.Forms.PictureBox pb_gizli_soru_cevabi;
        private System.Windows.Forms.PictureBox pb_sifre_tekrar;
        private System.Windows.Forms.PictureBox pb_sifreyi_goster;
        private System.Windows.Forms.MaskedTextBox mtb_tc_no;
        private System.Windows.Forms.Label lbl_gizli_soru_cevabi;
        private System.Windows.Forms.TextBox tb_gizli_soru_cevabi;
        private System.Windows.Forms.Label lbl_sifre_tekrar;
        private System.Windows.Forms.TextBox tb_sifre_tekrar;
        private System.Windows.Forms.Label lbl_gizli_soru;
        private System.Windows.Forms.ComboBox cb_gizli_soru;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.TextBox tb_eposta;
        private System.Windows.Forms.Button btn_yetkili_ekle;
        private System.Windows.Forms.MaskedTextBox mtb_telefon_no;
        private System.Windows.Forms.Label lbl_telefon_no;
        private System.Windows.Forms.Label lbl_yetki_turu;
        private System.Windows.Forms.Label lbl_ad_soyad;
        private System.Windows.Forms.Label lbl_tc_no;
        private System.Windows.Forms.PictureBox pb_tick_cinsiyet;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.PictureBox pb_tick_susbe;
        private System.Windows.Forms.Label lblSube;
        private System.Windows.Forms.TextBox tb_ad_soyad;
        private System.Windows.Forms.TextBox tbCinsiyet;
        private System.Windows.Forms.ComboBox cb_yetki_turu;
        private System.Windows.Forms.ComboBox cbSube;
    }
}