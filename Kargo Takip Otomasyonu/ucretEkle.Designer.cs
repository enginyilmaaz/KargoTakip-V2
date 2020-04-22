namespace WindowsFormsApplication1
{
    partial class fiyatEkle
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
            this.cb_gonderiTuru = new System.Windows.Forms.ComboBox();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbl_telefon_no = new System.Windows.Forms.Label();
            this.lbl_ad_soyad = new System.Windows.Forms.Label();
            this.tbBirimFiyat = new System.Windows.Forms.TextBox();
            this.lbl_tc_no = new System.Windows.Forms.Label();
            this.lbl_subeAdi = new System.Windows.Forms.Label();
            this.lbl_subeNo = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.tbMusKimlikNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMusBilgi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_gonderiTuru
            // 
            this.cb_gonderiTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gonderiTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_gonderiTuru.FormattingEnabled = true;
            this.cb_gonderiTuru.Items.AddRange(new object[] {
            "Seçiniz...",
            "Paket",
            "Dosya"});
            this.cb_gonderiTuru.Location = new System.Drawing.Point(226, 175);
            this.cb_gonderiTuru.Name = "cb_gonderiTuru";
            this.cb_gonderiTuru.Size = new System.Drawing.Size(239, 26);
            this.cb_gonderiTuru.TabIndex = 86;
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(-91, 102);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(77, 20);
            this.lbl_cinsiyet.TabIndex = 85;
            this.lbl_cinsiyet.Text = "Cinsiyet:";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(68, 275);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(430, 35);
            this.btnEkle.TabIndex = 81;
            this.btnEkle.Text = "Ücret Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btn_yetkili_ekle_Click);
            // 
            // lbl_telefon_no
            // 
            this.lbl_telefon_no.AutoSize = true;
            this.lbl_telefon_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telefon_no.Location = new System.Drawing.Point(-115, 182);
            this.lbl_telefon_no.Name = "lbl_telefon_no";
            this.lbl_telefon_no.Size = new System.Drawing.Size(101, 20);
            this.lbl_telefon_no.TabIndex = 79;
            this.lbl_telefon_no.Text = "Telefon No:";
            // 
            // lbl_ad_soyad
            // 
            this.lbl_ad_soyad.AutoSize = true;
            this.lbl_ad_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad_soyad.Location = new System.Drawing.Point(-105, 140);
            this.lbl_ad_soyad.Name = "lbl_ad_soyad";
            this.lbl_ad_soyad.Size = new System.Drawing.Size(91, 20);
            this.lbl_ad_soyad.TabIndex = 78;
            this.lbl_ad_soyad.Text = "Ad Soyad:";
            // 
            // tbBirimFiyat
            // 
            this.tbBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBirimFiyat.Location = new System.Drawing.Point(226, 210);
            this.tbBirimFiyat.Name = "tbBirimFiyat";
            this.tbBirimFiyat.Size = new System.Drawing.Size(239, 26);
            this.tbBirimFiyat.TabIndex = 77;
            // 
            // lbl_tc_no
            // 
            this.lbl_tc_no.AutoSize = true;
            this.lbl_tc_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tc_no.Location = new System.Drawing.Point(-128, 67);
            this.lbl_tc_no.Name = "lbl_tc_no";
            this.lbl_tc_no.Size = new System.Drawing.Size(114, 20);
            this.lbl_tc_no.TabIndex = 76;
            this.lbl_tc_no.Text = "TC Kimlik No:";
            // 
            // lbl_subeAdi
            // 
            this.lbl_subeAdi.AutoSize = true;
            this.lbl_subeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_subeAdi.Location = new System.Drawing.Point(122, 213);
            this.lbl_subeAdi.Name = "lbl_subeAdi";
            this.lbl_subeAdi.Size = new System.Drawing.Size(98, 20);
            this.lbl_subeAdi.TabIndex = 90;
            this.lbl_subeAdi.Text = "Birim Fiyat:";
            // 
            // lbl_subeNo
            // 
            this.lbl_subeNo.AutoSize = true;
            this.lbl_subeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_subeNo.Location = new System.Drawing.Point(101, 175);
            this.lbl_subeNo.Name = "lbl_subeNo";
            this.lbl_subeNo.Size = new System.Drawing.Size(119, 20);
            this.lbl_subeNo.TabIndex = 89;
            this.lbl_subeNo.Text = "Gönderi Türü:";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(220, 39);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(140, 31);
            this.lblBaslik.TabIndex = 92;
            this.lblBaslik.Text = "Ücret Ekle";
            // 
            // tbMusKimlikNO
            // 
            this.tbMusKimlikNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMusKimlikNO.Location = new System.Drawing.Point(226, 107);
            this.tbMusKimlikNO.Name = "tbMusKimlikNO";
            this.tbMusKimlikNO.Size = new System.Drawing.Size(239, 26);
            this.tbMusKimlikNO.TabIndex = 93;
            this.tbMusKimlikNO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Müşteri Kimlik NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(84, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "Müşteri Bilgileri:";
            // 
            // tbMusBilgi
            // 
            this.tbMusBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMusBilgi.Location = new System.Drawing.Point(226, 141);
            this.tbMusBilgi.Name = "tbMusBilgi";
            this.tbMusBilgi.Size = new System.Drawing.Size(239, 26);
            this.tbMusBilgi.TabIndex = 95;
            // 
            // fiyatEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMusBilgi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMusKimlikNO);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lbl_subeAdi);
            this.Controls.Add(this.lbl_subeNo);
            this.Controls.Add(this.cb_gonderiTuru);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbl_telefon_no);
            this.Controls.Add(this.lbl_ad_soyad);
            this.Controls.Add(this.tbBirimFiyat);
            this.Controls.Add(this.lbl_tc_no);
            this.Name = "fiyatEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ücret Ekle";
            this.Load += new System.EventHandler(this.uucretEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_gonderiTuru;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lbl_telefon_no;
        private System.Windows.Forms.Label lbl_ad_soyad;
        private System.Windows.Forms.TextBox tbBirimFiyat;
        private System.Windows.Forms.Label lbl_tc_no;
        private System.Windows.Forms.Label lbl_subeAdi;
        private System.Windows.Forms.Label lbl_subeNo;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TextBox tbMusKimlikNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMusBilgi;
    }
}