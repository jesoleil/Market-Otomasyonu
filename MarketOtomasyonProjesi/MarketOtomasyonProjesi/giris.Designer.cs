namespace MarketOtomasyonProjesi
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.Cikis_btn = new System.Windows.Forms.Button();
            this.Giris_btn = new System.Windows.Forms.Button();
            this.Sifre_tbx = new System.Windows.Forms.TextBox();
            this.Ad_tbx = new System.Windows.Forms.TextBox();
            this.Sifre_lb = new System.Windows.Forms.Label();
            this.Ad_lb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cikis_btn
            // 
            this.Cikis_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.Cikis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cikis_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.Cikis_btn.Location = new System.Drawing.Point(788, 338);
            this.Cikis_btn.Name = "Cikis_btn";
            this.Cikis_btn.Size = new System.Drawing.Size(171, 82);
            this.Cikis_btn.TabIndex = 11;
            this.Cikis_btn.Text = "ÇIKIŞ";
            this.Cikis_btn.UseVisualStyleBackColor = false;
            this.Cikis_btn.Click += new System.EventHandler(this.Cikis_btn_Click);
            // 
            // Giris_btn
            // 
            this.Giris_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.Giris_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giris_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.Giris_btn.Location = new System.Drawing.Point(488, 339);
            this.Giris_btn.Name = "Giris_btn";
            this.Giris_btn.Size = new System.Drawing.Size(171, 81);
            this.Giris_btn.TabIndex = 10;
            this.Giris_btn.Text = "GİRİŞ";
            this.Giris_btn.UseVisualStyleBackColor = false;
            this.Giris_btn.Click += new System.EventHandler(this.Giris_btn_Click);
            // 
            // Sifre_tbx
            // 
            this.Sifre_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifre_tbx.Location = new System.Drawing.Point(664, 236);
            this.Sifre_tbx.Name = "Sifre_tbx";
            this.Sifre_tbx.Size = new System.Drawing.Size(295, 30);
            this.Sifre_tbx.TabIndex = 9;
            this.Sifre_tbx.TextChanged += new System.EventHandler(this.Sifre_tbx_TextChanged);
            // 
            // Ad_tbx
            // 
            this.Ad_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad_tbx.Location = new System.Drawing.Point(664, 180);
            this.Ad_tbx.Name = "Ad_tbx";
            this.Ad_tbx.Size = new System.Drawing.Size(295, 30);
            this.Ad_tbx.TabIndex = 8;
            // 
            // Sifre_lb
            // 
            this.Sifre_lb.AutoSize = true;
            this.Sifre_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifre_lb.Location = new System.Drawing.Point(483, 241);
            this.Sifre_lb.Name = "Sifre_lb";
            this.Sifre_lb.Size = new System.Drawing.Size(87, 25);
            this.Sifre_lb.TabIndex = 7;
            this.Sifre_lb.Text = "ŞİFRE :";
            // 
            // Ad_lb
            // 
            this.Ad_lb.AutoSize = true;
            this.Ad_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad_lb.Location = new System.Drawing.Point(483, 185);
            this.Ad_lb.Name = "Ad_lb";
            this.Ad_lb.Size = new System.Drawing.Size(179, 25);
            this.Ad_lb.TabIndex = 6;
            this.Ad_lb.Text = "KULLANICI ADI :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 46F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(430, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 86);
            this.label1.TabIndex = 13;
            this.label1.Text = "HOŞ GELDİNİZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(483, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lütfen kullanıcı adınızı ve şifrenizi giriniz :";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cikis_btn);
            this.Controls.Add(this.Giris_btn);
            this.Controls.Add(this.Sifre_tbx);
            this.Controls.Add(this.Ad_tbx);
            this.Controls.Add(this.Sifre_lb);
            this.Controls.Add(this.Ad_lb);
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cikis_btn;
        private System.Windows.Forms.Button Giris_btn;
        private System.Windows.Forms.TextBox Sifre_tbx;
        private System.Windows.Forms.TextBox Ad_tbx;
        private System.Windows.Forms.Label Sifre_lb;
        private System.Windows.Forms.Label Ad_lb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

