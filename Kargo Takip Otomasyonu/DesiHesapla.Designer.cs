namespace WindowsFormsApplication1
{
    partial class DesiHesapla
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbEn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBoy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAgirlik = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Enabled = false;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(26, 219);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(279, 37);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(72, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 87;
            this.label14.Text = "En (cm):";
            // 
            // tbEn
            // 
            this.tbEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbEn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbEn.Location = new System.Drawing.Point(153, 90);
            this.tbEn.Name = "tbEn";
            this.tbEn.Size = new System.Drawing.Size(152, 22);
            this.tbEn.TabIndex = 86;
            this.tbEn.TextChanged += new System.EventHandler(this.tbEn_TextChanged);
            this.tbEn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEn_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Boy (cm):";
            // 
            // tbBoy
            // 
            this.tbBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBoy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbBoy.Location = new System.Drawing.Point(153, 118);
            this.tbBoy.Name = "tbBoy";
            this.tbBoy.Size = new System.Drawing.Size(152, 22);
            this.tbBoy.TabIndex = 88;
            this.tbBoy.TextChanged += new System.EventHandler(this.tbEn_TextChanged);
            this.tbBoy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEn_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 91;
            this.label2.Text = "Yükseklik (cm):";
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbYukseklik.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbYukseklik.Location = new System.Drawing.Point(153, 146);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(152, 22);
            this.tbYukseklik.TabIndex = 90;
            this.tbYukseklik.TextChanged += new System.EventHandler(this.tbEn_TextChanged);
            this.tbYukseklik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEn_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 93;
            this.label3.Text = "Ağırlık (gr):";
            // 
            // tbAgirlik
            // 
            this.tbAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAgirlik.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbAgirlik.Location = new System.Drawing.Point(153, 174);
            this.tbAgirlik.Name = "tbAgirlik";
            this.tbAgirlik.Size = new System.Drawing.Size(152, 22);
            this.tbAgirlik.TabIndex = 92;
            this.tbAgirlik.TextChanged += new System.EventHandler(this.tbEn_TextChanged);
            this.tbAgirlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEn_KeyPress);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(84, 28);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(176, 31);
            this.lblBaslik.TabIndex = 94;
            this.lblBaslik.Text = "Desi Hesapla";
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // DesiHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 321);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAgirlik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbYukseklik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBoy);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbEn);
            this.Controls.Add(this.btnHesapla);
            this.Name = "DesiHesapla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DesiHesapla";
            this.Load += new System.EventHandler(this.DesiHesapla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox tbEn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbBoy;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbYukseklik;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbAgirlik;
        private System.Windows.Forms.Label lblBaslik;
    }
}