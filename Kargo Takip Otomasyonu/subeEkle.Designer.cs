namespace WindowsFormsApplication1
{
    partial class subeEkle
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
            this.lblSubeAdres = new System.Windows.Forms.Label();
            this.tbSubeAdres = new System.Windows.Forms.TextBox();
            this.mtbSubeTel = new System.Windows.Forms.MaskedTextBox();
            this.lblSubeTel = new System.Windows.Forms.Label();
            this.lbl_subeAdi = new System.Windows.Forms.Label();
            this.tbsubeAdi = new System.Windows.Forms.TextBox();
            this.cbSubeSehir = new System.Windows.Forms.ComboBox();
            this.lblSubeSehir = new System.Windows.Forms.Label();
            this.cbIlceID = new System.Windows.Forms.ComboBox();
            this.lblSubeIlce = new System.Windows.Forms.Label();
            this.btn_subeEkle = new System.Windows.Forms.Button();
            this.pb_tick_SubeIlce = new System.Windows.Forms.PictureBox();
            this.pb_tick_subeSehir = new System.Windows.Forms.PictureBox();
            this.pb_tick_subeAdres = new System.Windows.Forms.PictureBox();
            this.pb_tick_subeTel = new System.Windows.Forms.PictureBox();
            this.pb_tick_subeAdi = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_SubeIlce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeSehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeAdi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubeAdres
            // 
            this.lblSubeAdres.AutoSize = true;
            this.lblSubeAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeAdres.Location = new System.Drawing.Point(114, 264);
            this.lblSubeAdres.Name = "lblSubeAdres";
            this.lblSubeAdres.Size = new System.Drawing.Size(61, 20);
            this.lblSubeAdres.TabIndex = 48;
            this.lblSubeAdres.Text = "Adres:";
            // 
            // tbSubeAdres
            // 
            this.tbSubeAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSubeAdres.Location = new System.Drawing.Point(194, 261);
            this.tbSubeAdres.Multiline = true;
            this.tbSubeAdres.Name = "tbSubeAdres";
            this.tbSubeAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSubeAdres.Size = new System.Drawing.Size(239, 78);
            this.tbSubeAdres.TabIndex = 47;
            this.tbSubeAdres.TextChanged += new System.EventHandler(this.tbSubeAdres_TextChanged);
            // 
            // mtbSubeTel
            // 
            this.mtbSubeTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbSubeTel.Location = new System.Drawing.Point(194, 159);
            this.mtbSubeTel.Mask = "000-000-0000";
            this.mtbSubeTel.Name = "mtbSubeTel";
            this.mtbSubeTel.Size = new System.Drawing.Size(239, 26);
            this.mtbSubeTel.TabIndex = 46;
            this.mtbSubeTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbSubeTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbSubeTel_MaskInputRejected);
            this.mtbSubeTel.TextChanged += new System.EventHandler(this.mtbSubeTel_TextChanged);
            // 
            // lblSubeTel
            // 
            this.lblSubeTel.AutoSize = true;
            this.lblSubeTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeTel.Location = new System.Drawing.Point(97, 162);
            this.lblSubeTel.Name = "lblSubeTel";
            this.lblSubeTel.Size = new System.Drawing.Size(85, 20);
            this.lblSubeTel.TabIndex = 45;
            this.lblSubeTel.Text = "Şube Tel:";
            // 
            // lbl_subeAdi
            // 
            this.lbl_subeAdi.AutoSize = true;
            this.lbl_subeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_subeAdi.Location = new System.Drawing.Point(97, 130);
            this.lbl_subeAdi.Name = "lbl_subeAdi";
            this.lbl_subeAdi.Size = new System.Drawing.Size(87, 20);
            this.lbl_subeAdi.TabIndex = 44;
            this.lbl_subeAdi.Text = "Şube Adı:";
            // 
            // tbsubeAdi
            // 
            this.tbsubeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsubeAdi.Location = new System.Drawing.Point(194, 127);
            this.tbsubeAdi.Name = "tbsubeAdi";
            this.tbsubeAdi.Size = new System.Drawing.Size(239, 26);
            this.tbsubeAdi.TabIndex = 43;
            this.tbsubeAdi.TextChanged += new System.EventHandler(this.tbsubeAdi_TextChanged);
            // 
            // cbSubeSehir
            // 
            this.cbSubeSehir.DropDownHeight = 150;
            this.cbSubeSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubeSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSubeSehir.FormattingEnabled = true;
            this.cbSubeSehir.IntegralHeight = false;
            this.cbSubeSehir.Location = new System.Drawing.Point(194, 193);
            this.cbSubeSehir.Name = "cbSubeSehir";
            this.cbSubeSehir.Size = new System.Drawing.Size(239, 26);
            this.cbSubeSehir.TabIndex = 64;
            this.cbSubeSehir.SelectedIndexChanged += new System.EventHandler(this.cbSubeSehir_SelectedIndexChanged);
            // 
            // lblSubeSehir
            // 
            this.lblSubeSehir.AutoSize = true;
            this.lblSubeSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeSehir.Location = new System.Drawing.Point(79, 193);
            this.lblSubeSehir.Name = "lblSubeSehir";
            this.lblSubeSehir.Size = new System.Drawing.Size(103, 20);
            this.lblSubeSehir.TabIndex = 63;
            this.lblSubeSehir.Text = "Şube Şehir:";
            // 
            // cbIlceID
            // 
            this.cbIlceID.DropDownHeight = 150;
            this.cbIlceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIlceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIlceID.FormattingEnabled = true;
            this.cbIlceID.IntegralHeight = false;
            this.cbIlceID.Location = new System.Drawing.Point(194, 229);
            this.cbIlceID.Name = "cbIlceID";
            this.cbIlceID.Size = new System.Drawing.Size(239, 26);
            this.cbIlceID.TabIndex = 67;
            // 
            // lblSubeIlce
            // 
            this.lblSubeIlce.AutoSize = true;
            this.lblSubeIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeIlce.Location = new System.Drawing.Point(92, 231);
            this.lblSubeIlce.Name = "lblSubeIlce";
            this.lblSubeIlce.Size = new System.Drawing.Size(90, 20);
            this.lblSubeIlce.TabIndex = 66;
            this.lblSubeIlce.Text = "Şube İlçe:";
            // 
            // btn_subeEkle
            // 
            this.btn_subeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_subeEkle.Location = new System.Drawing.Point(83, 363);
            this.btn_subeEkle.Name = "btn_subeEkle";
            this.btn_subeEkle.Size = new System.Drawing.Size(405, 33);
            this.btn_subeEkle.TabIndex = 69;
            this.btn_subeEkle.Text = "Şube Ekle";
            this.btn_subeEkle.UseVisualStyleBackColor = true;
            this.btn_subeEkle.Click += new System.EventHandler(this.btn_subeEkle_Click);
            // 
            // pb_tick_SubeIlce
            // 
            this.pb_tick_SubeIlce.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_SubeIlce.Location = new System.Drawing.Point(439, 230);
            this.pb_tick_SubeIlce.Name = "pb_tick_SubeIlce";
            this.pb_tick_SubeIlce.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_SubeIlce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_SubeIlce.TabIndex = 68;
            this.pb_tick_SubeIlce.TabStop = false;
            // 
            // pb_tick_subeSehir
            // 
            this.pb_tick_subeSehir.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_subeSehir.Location = new System.Drawing.Point(439, 192);
            this.pb_tick_subeSehir.Name = "pb_tick_subeSehir";
            this.pb_tick_subeSehir.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_subeSehir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_subeSehir.TabIndex = 65;
            this.pb_tick_subeSehir.TabStop = false;
            // 
            // pb_tick_subeAdres
            // 
            this.pb_tick_subeAdres.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_subeAdres.Location = new System.Drawing.Point(439, 261);
            this.pb_tick_subeAdres.Name = "pb_tick_subeAdres";
            this.pb_tick_subeAdres.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_subeAdres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_subeAdres.TabIndex = 53;
            this.pb_tick_subeAdres.TabStop = false;
            this.pb_tick_subeAdres.Visible = false;
            // 
            // pb_tick_subeTel
            // 
            this.pb_tick_subeTel.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_subeTel.Location = new System.Drawing.Point(439, 159);
            this.pb_tick_subeTel.Name = "pb_tick_subeTel";
            this.pb_tick_subeTel.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_subeTel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_subeTel.TabIndex = 52;
            this.pb_tick_subeTel.TabStop = false;
            this.pb_tick_subeTel.Visible = false;
            // 
            // pb_tick_subeAdi
            // 
            this.pb_tick_subeAdi.Image = global::WindowsFormsApplication1.Properties.Resources._1457310252_onebit_34;
            this.pb_tick_subeAdi.Location = new System.Drawing.Point(439, 123);
            this.pb_tick_subeAdi.Name = "pb_tick_subeAdi";
            this.pb_tick_subeAdi.Size = new System.Drawing.Size(33, 26);
            this.pb_tick_subeAdi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tick_subeAdi.TabIndex = 50;
            this.pb_tick_subeAdi.TabStop = false;
            this.pb_tick_subeAdi.Visible = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(203, 60);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(198, 31);
            this.lblBaslik.TabIndex = 70;
            this.lblBaslik.Text = "Yeni Şube Ekle";
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // subeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 430);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btn_subeEkle);
            this.Controls.Add(this.pb_tick_SubeIlce);
            this.Controls.Add(this.cbIlceID);
            this.Controls.Add(this.lblSubeIlce);
            this.Controls.Add(this.pb_tick_subeSehir);
            this.Controls.Add(this.cbSubeSehir);
            this.Controls.Add(this.lblSubeSehir);
            this.Controls.Add(this.pb_tick_subeAdres);
            this.Controls.Add(this.pb_tick_subeTel);
            this.Controls.Add(this.pb_tick_subeAdi);
            this.Controls.Add(this.lblSubeAdres);
            this.Controls.Add(this.tbSubeAdres);
            this.Controls.Add(this.mtbSubeTel);
            this.Controls.Add(this.lblSubeTel);
            this.Controls.Add(this.lbl_subeAdi);
            this.Controls.Add(this.tbsubeAdi);
            this.Name = "subeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şube Ekle";
            this.Load += new System.EventHandler(this.subeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_SubeIlce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeSehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tick_subeAdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_tick_subeAdres;
        private System.Windows.Forms.PictureBox pb_tick_subeTel;
        private System.Windows.Forms.PictureBox pb_tick_subeAdi;
        private System.Windows.Forms.Label lblSubeAdres;
        private System.Windows.Forms.TextBox tbSubeAdres;
        private System.Windows.Forms.MaskedTextBox mtbSubeTel;
        private System.Windows.Forms.Label lblSubeTel;
        private System.Windows.Forms.Label lbl_subeAdi;
        private System.Windows.Forms.TextBox tbsubeAdi;
        private System.Windows.Forms.PictureBox pb_tick_subeSehir;
        private System.Windows.Forms.ComboBox cbSubeSehir;
        private System.Windows.Forms.Label lblSubeSehir;
        private System.Windows.Forms.PictureBox pb_tick_SubeIlce;
        private System.Windows.Forms.ComboBox cbIlceID;
        private System.Windows.Forms.Label lblSubeIlce;
        private System.Windows.Forms.Button btn_subeEkle;
        private System.Windows.Forms.Label lblBaslik;
    }
}