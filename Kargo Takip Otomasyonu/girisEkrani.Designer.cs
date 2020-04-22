namespace WindowsFormsApplication1
{
    partial class girisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisEkrani));
            this.tb_yetkili_TC = new System.Windows.Forms.TextBox();
            this.lbl_Eposta = new System.Windows.Forms.Label();
            this.btn_Giris_Yap = new System.Windows.Forms.Button();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.tb_yetkili_Sifre = new System.Windows.Forms.TextBox();
            this.linkSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lbl_Giris_Hata = new System.Windows.Forms.Label();
            this.pb_hata_resim = new System.Windows.Forms.PictureBox();
            this.pb_sifreyi_goster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hata_resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sifreyi_goster)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_yetkili_TC
            // 
            this.tb_yetkili_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_yetkili_TC.Location = new System.Drawing.Point(206, 107);
            this.tb_yetkili_TC.MaxLength = 11;
            this.tb_yetkili_TC.Name = "tb_yetkili_TC";
            this.tb_yetkili_TC.Size = new System.Drawing.Size(250, 26);
            this.tb_yetkili_TC.TabIndex = 0;
            this.tb_yetkili_TC.TextChanged += new System.EventHandler(this.tb_yetkili_Mail_TextChanged);
            this.tb_yetkili_TC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_yetkili_Mail_KeyPress);
            // 
            // lbl_Eposta
            // 
            this.lbl_Eposta.AutoSize = true;
            this.lbl_Eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Eposta.Location = new System.Drawing.Point(109, 110);
            this.lbl_Eposta.Name = "lbl_Eposta";
            this.lbl_Eposta.Size = new System.Drawing.Size(87, 20);
            this.lbl_Eposta.TabIndex = 1;
            this.lbl_Eposta.Text = "Kimlik No:";
            // 
            // btn_Giris_Yap
            // 
            this.btn_Giris_Yap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris_Yap.Location = new System.Drawing.Point(113, 231);
            this.btn_Giris_Yap.Name = "btn_Giris_Yap";
            this.btn_Giris_Yap.Size = new System.Drawing.Size(343, 33);
            this.btn_Giris_Yap.TabIndex = 2;
            this.btn_Giris_Yap.Text = "Sisteme Giriş Yap";
            this.btn_Giris_Yap.UseVisualStyleBackColor = true;
            this.btn_Giris_Yap.Click += new System.EventHandler(this.btn_Giris_Yap_Click);
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.Location = new System.Drawing.Point(109, 150);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(52, 20);
            this.lbl_Sifre.TabIndex = 4;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // tb_yetkili_Sifre
            // 
            this.tb_yetkili_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_yetkili_Sifre.Location = new System.Drawing.Point(206, 147);
            this.tb_yetkili_Sifre.Name = "tb_yetkili_Sifre";
            this.tb_yetkili_Sifre.PasswordChar = '●';
            this.tb_yetkili_Sifre.Size = new System.Drawing.Size(250, 26);
            this.tb_yetkili_Sifre.TabIndex = 3;
            this.tb_yetkili_Sifre.TextChanged += new System.EventHandler(this.tb_yetkili_Mail_TextChanged);
            this.tb_yetkili_Sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_yetkili_Sifre_KeyPress);
            // 
            // linkSifremiUnuttum
            // 
            this.linkSifremiUnuttum.AutoSize = true;
            this.linkSifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkSifremiUnuttum.Location = new System.Drawing.Point(307, 188);
            this.linkSifremiUnuttum.Name = "linkSifremiUnuttum";
            this.linkSifremiUnuttum.Size = new System.Drawing.Size(149, 20);
            this.linkSifremiUnuttum.TabIndex = 5;
            this.linkSifremiUnuttum.TabStop = true;
            this.linkSifremiUnuttum.Text = "Şifremi Unuttum?";
            this.linkSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(125, 45);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(321, 31);
            this.lblBaslik.TabIndex = 7;
            this.lblBaslik.Text = "Kargo Takip Otomasyonu";
            // 
            // lbl_Giris_Hata
            // 
            this.lbl_Giris_Hata.AutoSize = true;
            this.lbl_Giris_Hata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Giris_Hata.Location = new System.Drawing.Point(148, 283);
            this.lbl_Giris_Hata.Name = "lbl_Giris_Hata";
            this.lbl_Giris_Hata.Size = new System.Drawing.Size(308, 20);
            this.lbl_Giris_Hata.TabIndex = 8;
            this.lbl_Giris_Hata.Text = "Hatalı / boş eposta veya şifre girdiniz!";
            this.lbl_Giris_Hata.Visible = false;
            // 
            // pb_hata_resim
            // 
            this.pb_hata_resim.Image = global::WindowsFormsApplication1.Properties.Resources._1456506709_Error;
            this.pb_hata_resim.Location = new System.Drawing.Point(116, 283);
            this.pb_hata_resim.Name = "pb_hata_resim";
            this.pb_hata_resim.Size = new System.Drawing.Size(30, 22);
            this.pb_hata_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_hata_resim.TabIndex = 10;
            this.pb_hata_resim.TabStop = false;
            this.pb_hata_resim.Visible = false;
            // 
            // pb_sifreyi_goster
            // 
            this.pb_sifreyi_goster.Image = global::WindowsFormsApplication1.Properties.Resources.unlock;
            this.pb_sifreyi_goster.Location = new System.Drawing.Point(457, 147);
            this.pb_sifreyi_goster.Name = "pb_sifreyi_goster";
            this.pb_sifreyi_goster.Size = new System.Drawing.Size(27, 26);
            this.pb_sifreyi_goster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_sifreyi_goster.TabIndex = 17;
            this.pb_sifreyi_goster.TabStop = false;
            this.pb_sifreyi_goster.MouseLeave += new System.EventHandler(this.pb_sifreyi_goster_MouseLeave);
            this.pb_sifreyi_goster.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_sifreyi_goster_MouseMove);
            // 
            // girisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 339);
            this.Controls.Add(this.pb_sifreyi_goster);
            this.Controls.Add(this.pb_hata_resim);
            this.Controls.Add(this.lbl_Giris_Hata);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.linkSifremiUnuttum);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.tb_yetkili_Sifre);
            this.Controls.Add(this.btn_Giris_Yap);
            this.Controls.Add(this.lbl_Eposta);
            this.Controls.Add(this.tb_yetkili_TC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "girisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Takip Otomasyonu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.girisEkrani_FormClosing);
            this.Load += new System.EventHandler(this.girisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hata_resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sifreyi_goster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_yetkili_TC;
        private System.Windows.Forms.Label lbl_Eposta;
        private System.Windows.Forms.Button btn_Giris_Yap;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox tb_yetkili_Sifre;
        private System.Windows.Forms.LinkLabel linkSifremiUnuttum;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lbl_Giris_Hata;
        private System.Windows.Forms.PictureBox pb_hata_resim;
        private System.Windows.Forms.PictureBox pb_sifreyi_goster;
    }
}

