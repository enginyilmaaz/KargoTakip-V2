namespace WindowsFormsApplication1
{
    partial class sifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifremiUnuttum));
            this.lbl_Eposta = new System.Windows.Forms.Label();
            this.tb_yetkili_Mail = new System.Windows.Forms.TextBox();
            this.tb_Gizli_Soru_Yanit = new System.Windows.Forms.TextBox();
            this.btn_Cevapla = new System.Windows.Forms.Button();
            this.btn_Gizli_Soruyu_Goster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Adim1 = new System.Windows.Forms.GroupBox();
            this.pb_hata_resim = new System.Windows.Forms.PictureBox();
            this.lbl_Yanlis_Eposta = new System.Windows.Forms.Label();
            this.gb_Adim2 = new System.Windows.Forms.GroupBox();
            this.pb_hata_gizli_soru = new System.Windows.Forms.PictureBox();
            this.lbl_Gizli_Soru_Hatasi = new System.Windows.Forms.Label();
            this.lbl_Gizli_Soru_Text = new System.Windows.Forms.Label();
            this.lbl_Gizli_Soru = new System.Windows.Forms.Label();
            this.gb_Adim3 = new System.Windows.Forms.GroupBox();
            this.pb_tekrar_sifreyi_goster = new System.Windows.Forms.PictureBox();
            this.pb_sifreyi_goster = new System.Windows.Forms.PictureBox();
            this.tb_Yeni_Sifre_Tekrar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Yeni_Sifre = new System.Windows.Forms.Label();
            this.tb_Yeni_Sifre = new System.Windows.Forms.TextBox();
            this.btn_Degistir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblBaslik = new System.Windows.Forms.Label();
            this.gb_Adim1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hata_resim)).BeginInit();
            this.gb_Adim2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hata_gizli_soru)).BeginInit();
            this.gb_Adim3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tekrar_sifreyi_goster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sifreyi_goster)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Eposta
            // 
            this.lbl_Eposta.AutoSize = true;
            this.lbl_Eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Eposta.Location = new System.Drawing.Point(77, 44);
            this.lbl_Eposta.Name = "lbl_Eposta";
            this.lbl_Eposta.Size = new System.Drawing.Size(71, 20);
            this.lbl_Eposta.TabIndex = 3;
            this.lbl_Eposta.Text = "Eposta:";
            // 
            // tb_yetkili_Mail
            // 
            this.tb_yetkili_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_yetkili_Mail.Location = new System.Drawing.Point(174, 44);
            this.tb_yetkili_Mail.Name = "tb_yetkili_Mail";
            this.tb_yetkili_Mail.Size = new System.Drawing.Size(306, 26);
            this.tb_yetkili_Mail.TabIndex = 2;
            this.tb_yetkili_Mail.TextChanged += new System.EventHandler(this.tb_yetkili_Mail_TextChanged);
            this.tb_yetkili_Mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_yetkili_Mail_KeyPress);
            // 
            // tb_Gizli_Soru_Yanit
            // 
            this.tb_Gizli_Soru_Yanit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Gizli_Soru_Yanit.Location = new System.Drawing.Point(174, 69);
            this.tb_Gizli_Soru_Yanit.Name = "tb_Gizli_Soru_Yanit";
            this.tb_Gizli_Soru_Yanit.Size = new System.Drawing.Size(306, 26);
            this.tb_Gizli_Soru_Yanit.TabIndex = 4;
            this.tb_Gizli_Soru_Yanit.TextChanged += new System.EventHandler(this.tb_Gizli_Soru_Yanit_TextChanged);
            this.tb_Gizli_Soru_Yanit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Gizli_Soru_Yanit_KeyPress);
            // 
            // btn_Cevapla
            // 
            this.btn_Cevapla.Enabled = false;
            this.btn_Cevapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cevapla.Location = new System.Drawing.Point(174, 101);
            this.btn_Cevapla.Name = "btn_Cevapla";
            this.btn_Cevapla.Size = new System.Drawing.Size(306, 35);
            this.btn_Cevapla.TabIndex = 5;
            this.btn_Cevapla.Text = "Cevapla";
            this.btn_Cevapla.UseVisualStyleBackColor = true;
            this.btn_Cevapla.Click += new System.EventHandler(this.btn_Cevapla_Click);
            // 
            // btn_Gizli_Soruyu_Goster
            // 
            this.btn_Gizli_Soruyu_Goster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gizli_Soruyu_Goster.Location = new System.Drawing.Point(174, 76);
            this.btn_Gizli_Soruyu_Goster.Name = "btn_Gizli_Soruyu_Goster";
            this.btn_Gizli_Soruyu_Goster.Size = new System.Drawing.Size(306, 35);
            this.btn_Gizli_Soruyu_Goster.TabIndex = 6;
            this.btn_Gizli_Soruyu_Goster.Text = "Gizli Soruyu Göster";
            this.btn_Gizli_Soruyu_Goster.UseVisualStyleBackColor = true;
            this.btn_Gizli_Soruyu_Goster.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(108, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yanıt:";
            // 
            // gb_Adim1
            // 
            this.gb_Adim1.Controls.Add(this.pb_hata_resim);
            this.gb_Adim1.Controls.Add(this.lbl_Yanlis_Eposta);
            this.gb_Adim1.Controls.Add(this.btn_Gizli_Soruyu_Goster);
            this.gb_Adim1.Controls.Add(this.tb_yetkili_Mail);
            this.gb_Adim1.Controls.Add(this.lbl_Eposta);
            this.gb_Adim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_Adim1.Location = new System.Drawing.Point(42, 74);
            this.gb_Adim1.Name = "gb_Adim1";
            this.gb_Adim1.Size = new System.Drawing.Size(543, 201);
            this.gb_Adim1.TabIndex = 10;
            this.gb_Adim1.TabStop = false;
            this.gb_Adim1.Text = "Adım 1:";
            // 
            // pb_hata_resim
            // 
            this.pb_hata_resim.Image = global::WindowsFormsApplication1.Properties.Resources._1456506709_Error;
            this.pb_hata_resim.Location = new System.Drawing.Point(211, 137);
            this.pb_hata_resim.Name = "pb_hata_resim";
            this.pb_hata_resim.Size = new System.Drawing.Size(30, 22);
            this.pb_hata_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_hata_resim.TabIndex = 8;
            this.pb_hata_resim.TabStop = false;
            this.pb_hata_resim.Visible = false;
            // 
            // lbl_Yanlis_Eposta
            // 
            this.lbl_Yanlis_Eposta.AutoSize = true;
            this.lbl_Yanlis_Eposta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Yanlis_Eposta.Location = new System.Drawing.Point(238, 137);
            this.lbl_Yanlis_Eposta.Name = "lbl_Yanlis_Eposta";
            this.lbl_Yanlis_Eposta.Size = new System.Drawing.Size(186, 20);
            this.lbl_Yanlis_Eposta.TabIndex = 7;
            this.lbl_Yanlis_Eposta.Text = "Yanlış Eposta Girdiniz";
            this.lbl_Yanlis_Eposta.Visible = false;
            // 
            // gb_Adim2
            // 
            this.gb_Adim2.Controls.Add(this.pb_hata_gizli_soru);
            this.gb_Adim2.Controls.Add(this.lbl_Gizli_Soru_Hatasi);
            this.gb_Adim2.Controls.Add(this.lbl_Gizli_Soru_Text);
            this.gb_Adim2.Controls.Add(this.label1);
            this.gb_Adim2.Controls.Add(this.lbl_Gizli_Soru);
            this.gb_Adim2.Controls.Add(this.tb_Gizli_Soru_Yanit);
            this.gb_Adim2.Controls.Add(this.btn_Cevapla);
            this.gb_Adim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_Adim2.Location = new System.Drawing.Point(42, 74);
            this.gb_Adim2.Name = "gb_Adim2";
            this.gb_Adim2.Size = new System.Drawing.Size(543, 201);
            this.gb_Adim2.TabIndex = 11;
            this.gb_Adim2.TabStop = false;
            this.gb_Adim2.Text = "Adım 2:";
            this.gb_Adim2.Visible = false;
            this.gb_Adim2.Enter += new System.EventHandler(this.gb_Adim2_Enter);
            // 
            // pb_hata_gizli_soru
            // 
            this.pb_hata_gizli_soru.Image = global::WindowsFormsApplication1.Properties.Resources._1456506709_Error;
            this.pb_hata_gizli_soru.Location = new System.Drawing.Point(172, 144);
            this.pb_hata_gizli_soru.Name = "pb_hata_gizli_soru";
            this.pb_hata_gizli_soru.Size = new System.Drawing.Size(30, 22);
            this.pb_hata_gizli_soru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_hata_gizli_soru.TabIndex = 14;
            this.pb_hata_gizli_soru.TabStop = false;
            this.pb_hata_gizli_soru.Visible = false;
            // 
            // lbl_Gizli_Soru_Hatasi
            // 
            this.lbl_Gizli_Soru_Hatasi.AutoSize = true;
            this.lbl_Gizli_Soru_Hatasi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Gizli_Soru_Hatasi.Location = new System.Drawing.Point(199, 144);
            this.lbl_Gizli_Soru_Hatasi.Name = "lbl_Gizli_Soru_Hatasi";
            this.lbl_Gizli_Soru_Hatasi.Size = new System.Drawing.Size(281, 20);
            this.lbl_Gizli_Soru_Hatasi.TabIndex = 13;
            this.lbl_Gizli_Soru_Hatasi.Text = "Gizli Soruya Yanlış Yanıt Verdiniz!";
            this.lbl_Gizli_Soru_Hatasi.Visible = false;
            // 
            // lbl_Gizli_Soru_Text
            // 
            this.lbl_Gizli_Soru_Text.AutoSize = true;
            this.lbl_Gizli_Soru_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Gizli_Soru_Text.Location = new System.Drawing.Point(72, 34);
            this.lbl_Gizli_Soru_Text.Name = "lbl_Gizli_Soru_Text";
            this.lbl_Gizli_Soru_Text.Size = new System.Drawing.Size(92, 20);
            this.lbl_Gizli_Soru_Text.TabIndex = 12;
            this.lbl_Gizli_Soru_Text.Text = "Gizli Soru:";
            // 
            // lbl_Gizli_Soru
            // 
            this.lbl_Gizli_Soru.AutoSize = true;
            this.lbl_Gizli_Soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Gizli_Soru.Location = new System.Drawing.Point(170, 34);
            this.lbl_Gizli_Soru.Name = "lbl_Gizli_Soru";
            this.lbl_Gizli_Soru.Size = new System.Drawing.Size(87, 20);
            this.lbl_Gizli_Soru.TabIndex = 11;
            this.lbl_Gizli_Soru.Text = "Gizli Soru";
            this.lbl_Gizli_Soru.Visible = false;
            // 
            // gb_Adim3
            // 
            this.gb_Adim3.Controls.Add(this.pb_tekrar_sifreyi_goster);
            this.gb_Adim3.Controls.Add(this.pb_sifreyi_goster);
            this.gb_Adim3.Controls.Add(this.tb_Yeni_Sifre_Tekrar);
            this.gb_Adim3.Controls.Add(this.label2);
            this.gb_Adim3.Controls.Add(this.lbl_Yeni_Sifre);
            this.gb_Adim3.Controls.Add(this.tb_Yeni_Sifre);
            this.gb_Adim3.Controls.Add(this.btn_Degistir);
            this.gb_Adim3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_Adim3.Location = new System.Drawing.Point(42, 74);
            this.gb_Adim3.Name = "gb_Adim3";
            this.gb_Adim3.Size = new System.Drawing.Size(543, 201);
            this.gb_Adim3.TabIndex = 13;
            this.gb_Adim3.TabStop = false;
            this.gb_Adim3.Text = "Adım 3:";
            this.gb_Adim3.Visible = false;
            this.gb_Adim3.Enter += new System.EventHandler(this.gb_Adim3_Enter);
            // 
            // pb_tekrar_sifreyi_goster
            // 
            this.pb_tekrar_sifreyi_goster.Image = global::WindowsFormsApplication1.Properties.Resources.unlock;
            this.pb_tekrar_sifreyi_goster.Location = new System.Drawing.Point(481, 73);
            this.pb_tekrar_sifreyi_goster.Name = "pb_tekrar_sifreyi_goster";
            this.pb_tekrar_sifreyi_goster.Size = new System.Drawing.Size(33, 26);
            this.pb_tekrar_sifreyi_goster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tekrar_sifreyi_goster.TabIndex = 16;
            this.pb_tekrar_sifreyi_goster.TabStop = false;
            this.pb_tekrar_sifreyi_goster.MouseLeave += new System.EventHandler(this.pb_tekrar_sifreyi_goster_MouseLeave);
            this.pb_tekrar_sifreyi_goster.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_tekrar_sifreyi_goster_MouseMove);
            // 
            // pb_sifreyi_goster
            // 
            this.pb_sifreyi_goster.Image = global::WindowsFormsApplication1.Properties.Resources.unlock;
            this.pb_sifreyi_goster.Location = new System.Drawing.Point(481, 31);
            this.pb_sifreyi_goster.Name = "pb_sifreyi_goster";
            this.pb_sifreyi_goster.Size = new System.Drawing.Size(33, 26);
            this.pb_sifreyi_goster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_sifreyi_goster.TabIndex = 15;
            this.pb_sifreyi_goster.TabStop = false;
            this.pb_sifreyi_goster.MouseLeave += new System.EventHandler(this.pb_sifreyi_goster_MouseLeave);
            this.pb_sifreyi_goster.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_sifreyi_goster_MouseMove);
            // 
            // tb_Yeni_Sifre_Tekrar
            // 
            this.tb_Yeni_Sifre_Tekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Yeni_Sifre_Tekrar.Location = new System.Drawing.Point(174, 73);
            this.tb_Yeni_Sifre_Tekrar.MaxLength = 14;
            this.tb_Yeni_Sifre_Tekrar.Name = "tb_Yeni_Sifre_Tekrar";
            this.tb_Yeni_Sifre_Tekrar.PasswordChar = '●';
            this.tb_Yeni_Sifre_Tekrar.Size = new System.Drawing.Size(306, 26);
            this.tb_Yeni_Sifre_Tekrar.TabIndex = 14;
            this.toolTip1.SetToolTip(this.tb_Yeni_Sifre_Tekrar, "Şifre en az 6 haneli olmalıdır.");
            this.tb_Yeni_Sifre_Tekrar.Click += new System.EventHandler(this.tb_Yeni_Sifre_Tekrar_Click);
            this.tb_Yeni_Sifre_Tekrar.TextChanged += new System.EventHandler(this.tb_Yeni_Sifre_TextChanged);
            this.tb_Yeni_Sifre_Tekrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Yeni_Sifre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(100, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tekrar:";
            // 
            // lbl_Yeni_Sifre
            // 
            this.lbl_Yeni_Sifre.AutoSize = true;
            this.lbl_Yeni_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yeni_Sifre.Location = new System.Drawing.Point(72, 34);
            this.lbl_Yeni_Sifre.Name = "lbl_Yeni_Sifre";
            this.lbl_Yeni_Sifre.Size = new System.Drawing.Size(93, 20);
            this.lbl_Yeni_Sifre.TabIndex = 12;
            this.lbl_Yeni_Sifre.Text = "Yeni Şifre:";
            // 
            // tb_Yeni_Sifre
            // 
            this.tb_Yeni_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Yeni_Sifre.Location = new System.Drawing.Point(174, 31);
            this.tb_Yeni_Sifre.MaxLength = 14;
            this.tb_Yeni_Sifre.Name = "tb_Yeni_Sifre";
            this.tb_Yeni_Sifre.PasswordChar = '●';
            this.tb_Yeni_Sifre.Size = new System.Drawing.Size(306, 26);
            this.tb_Yeni_Sifre.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tb_Yeni_Sifre, "Şifre en az 6 haneli olmalıdır.");
            this.tb_Yeni_Sifre.Click += new System.EventHandler(this.tb_Yeni_Sifre_Click);
            this.tb_Yeni_Sifre.TextChanged += new System.EventHandler(this.tb_Yeni_Sifre_TextChanged);
            this.tb_Yeni_Sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Yeni_Sifre_KeyPress);
            // 
            // btn_Degistir
            // 
            this.btn_Degistir.Enabled = false;
            this.btn_Degistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Degistir.Location = new System.Drawing.Point(174, 117);
            this.btn_Degistir.Name = "btn_Degistir";
            this.btn_Degistir.Size = new System.Drawing.Size(306, 35);
            this.btn_Degistir.TabIndex = 5;
            this.btn_Degistir.Text = "Değiştir";
            this.btn_Degistir.UseVisualStyleBackColor = true;
            this.btn_Degistir.Click += new System.EventHandler(this.btn_Degistir_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(209, 23);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(221, 31);
            this.lblBaslik.TabIndex = 14;
            this.lblBaslik.Text = "Şifre Güncelleme";
            // 
            // sifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 326);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.gb_Adim3);
            this.Controls.Add(this.gb_Adim2);
            this.Controls.Add(this.gb_Adim1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum?";
            this.Load += new System.EventHandler(this.sifremiUnuttum_Load);
            this.gb_Adim1.ResumeLayout(false);
            this.gb_Adim1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hata_resim)).EndInit();
            this.gb_Adim2.ResumeLayout(false);
            this.gb_Adim2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hata_gizli_soru)).EndInit();
            this.gb_Adim3.ResumeLayout(false);
            this.gb_Adim3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tekrar_sifreyi_goster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sifreyi_goster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Eposta;
        private System.Windows.Forms.TextBox tb_yetkili_Mail;
        private System.Windows.Forms.TextBox tb_Gizli_Soru_Yanit;
        private System.Windows.Forms.Button btn_Cevapla;
        private System.Windows.Forms.Button btn_Gizli_Soruyu_Goster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Adim1;
        private System.Windows.Forms.GroupBox gb_Adim2;
        private System.Windows.Forms.Label lbl_Gizli_Soru_Text;
        private System.Windows.Forms.Label lbl_Gizli_Soru;
        private System.Windows.Forms.GroupBox gb_Adim3;
        private System.Windows.Forms.TextBox tb_Yeni_Sifre_Tekrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Yeni_Sifre;
        private System.Windows.Forms.TextBox tb_Yeni_Sifre;
        private System.Windows.Forms.Button btn_Degistir;
        private System.Windows.Forms.PictureBox pb_hata_resim;
        private System.Windows.Forms.Label lbl_Yanlis_Eposta;
        private System.Windows.Forms.PictureBox pb_hata_gizli_soru;
        private System.Windows.Forms.Label lbl_Gizli_Soru_Hatasi;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pb_sifreyi_goster;
        private System.Windows.Forms.PictureBox pb_tekrar_sifreyi_goster;
        private System.Windows.Forms.Label lblBaslik;
    }
}