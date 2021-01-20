using System;

namespace MarketOtomasyonProjesi
{
    partial class tedarikcilerform
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vergiadbox = new System.Windows.Forms.TextBox();
            this.verginobox = new System.Windows.Forms.TextBox();
            this.kategoricbox = new System.Windows.Forms.ComboBox();
            this.epostabox = new System.Windows.Forms.TextBox();
            this.fadresbox = new System.Windows.Forms.TextBox();
            this.ftelnobox = new System.Windows.Forms.TextBox();
            this.fadibox = new System.Windows.Forms.TextBox();
            this.fidbox = new System.Windows.Forms.TextBox();
            this.tmzlbtn = new System.Windows.Forms.Button();
            this.gnclbtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.kydtbtn = new System.Windows.Forms.Button();
            this.fvergidairesi = new System.Windows.Forms.Label();
            this.fvergino = new System.Windows.Forms.Label();
            this.fkategori = new System.Windows.Forms.Label();
            this.feposta = new System.Windows.Forms.Label();
            this.fiadres = new System.Windows.Forms.Label();
            this.fitelno = new System.Windows.Forms.Label();
            this.fadi = new System.Windows.Forms.Label();
            this.fid = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 387);
            this.dataGridView1.TabIndex = 41;
            // 
            // vergiadbox
            // 
            this.vergiadbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vergiadbox.Location = new System.Drawing.Point(911, 68);
            this.vergiadbox.Name = "vergiadbox";
            this.vergiadbox.Size = new System.Drawing.Size(188, 26);
            this.vergiadbox.TabIndex = 40;
            // 
            // verginobox
            // 
            this.verginobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verginobox.Location = new System.Drawing.Point(911, 21);
            this.verginobox.Name = "verginobox";
            this.verginobox.Size = new System.Drawing.Size(188, 26);
            this.verginobox.TabIndex = 39;
            // 
            // kategoricbox
            // 
            this.kategoricbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoricbox.FormattingEnabled = true;
            this.kategoricbox.Items.AddRange(new object[] {
            "GIDA",
            "TEMİZLİK",
            "HAFTALIK KAMPANYA"});
            this.kategoricbox.Location = new System.Drawing.Point(503, 150);
            this.kategoricbox.Name = "kategoricbox";
            this.kategoricbox.Size = new System.Drawing.Size(188, 28);
            this.kategoricbox.TabIndex = 38;
            this.kategoricbox.SelectedIndexChanged += new System.EventHandler(this.kategoricbox_SelectedIndexChanged);
            // 
            // epostabox
            // 
            this.epostabox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.epostabox.Location = new System.Drawing.Point(140, 150);
            this.epostabox.Name = "epostabox";
            this.epostabox.Size = new System.Drawing.Size(188, 26);
            this.epostabox.TabIndex = 37;
            // 
            // fadresbox
            // 
            this.fadresbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fadresbox.Location = new System.Drawing.Point(503, 21);
            this.fadresbox.Multiline = true;
            this.fadresbox.Name = "fadresbox";
            this.fadresbox.Size = new System.Drawing.Size(188, 113);
            this.fadresbox.TabIndex = 36;
            // 
            // ftelnobox
            // 
            this.ftelnobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ftelnobox.Location = new System.Drawing.Point(140, 108);
            this.ftelnobox.Name = "ftelnobox";
            this.ftelnobox.Size = new System.Drawing.Size(188, 26);
            this.ftelnobox.TabIndex = 35;
            // 
            // fadibox
            // 
            this.fadibox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fadibox.Location = new System.Drawing.Point(140, 63);
            this.fadibox.Name = "fadibox";
            this.fadibox.Size = new System.Drawing.Size(188, 26);
            this.fadibox.TabIndex = 34;
            // 
            // fidbox
            // 
            this.fidbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fidbox.Location = new System.Drawing.Point(140, 21);
            this.fidbox.Name = "fidbox";
            this.fidbox.Size = new System.Drawing.Size(188, 26);
            this.fidbox.TabIndex = 33;
            // 
            // tmzlbtn
            // 
            this.tmzlbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.tmzlbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tmzlbtn.Location = new System.Drawing.Point(920, 201);
            this.tmzlbtn.Name = "tmzlbtn";
            this.tmzlbtn.Size = new System.Drawing.Size(182, 67);
            this.tmzlbtn.TabIndex = 32;
            this.tmzlbtn.Text = "TEMİZLE";
            this.tmzlbtn.UseVisualStyleBackColor = false;
            this.tmzlbtn.Click += new System.EventHandler(this.tmzlbtn_Click_1);
            // 
            // gnclbtn
            // 
            this.gnclbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.gnclbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gnclbtn.Location = new System.Drawing.Point(614, 201);
            this.gnclbtn.Name = "gnclbtn";
            this.gnclbtn.Size = new System.Drawing.Size(182, 67);
            this.gnclbtn.TabIndex = 31;
            this.gnclbtn.Text = "GÜNCELLE";
            this.gnclbtn.UseVisualStyleBackColor = false;
            this.gnclbtn.Click += new System.EventHandler(this.gnclbtn_Click_1);
            // 
            // silbtn
            // 
            this.silbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.silbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbtn.Location = new System.Drawing.Point(323, 201);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(182, 67);
            this.silbtn.TabIndex = 30;
            this.silbtn.Text = "SİL";
            this.silbtn.UseVisualStyleBackColor = false;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click_1);
            // 
            // kydtbtn
            // 
            this.kydtbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.kydtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kydtbtn.Location = new System.Drawing.Point(12, 201);
            this.kydtbtn.Name = "kydtbtn";
            this.kydtbtn.Size = new System.Drawing.Size(182, 67);
            this.kydtbtn.TabIndex = 29;
            this.kydtbtn.Text = "KAYDET";
            this.kydtbtn.UseVisualStyleBackColor = false;
            this.kydtbtn.Click += new System.EventHandler(this.kydtbtn_Click_1);
            // 
            // fvergidairesi
            // 
            this.fvergidairesi.AutoSize = true;
            this.fvergidairesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fvergidairesi.Location = new System.Drawing.Point(745, 69);
            this.fvergidairesi.Name = "fvergidairesi";
            this.fvergidairesi.Size = new System.Drawing.Size(136, 20);
            this.fvergidairesi.TabIndex = 28;
            this.fvergidairesi.Text = "VERGİ DAİRESİ:";
            // 
            // fvergino
            // 
            this.fvergino.AutoSize = true;
            this.fvergino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fvergino.Location = new System.Drawing.Point(745, 24);
            this.fvergino.Name = "fvergino";
            this.fvergino.Size = new System.Drawing.Size(100, 20);
            this.fvergino.TabIndex = 27;
            this.fvergino.Text = "VERGİ NO :";
            // 
            // fkategori
            // 
            this.fkategori.AutoSize = true;
            this.fkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fkategori.Location = new System.Drawing.Point(384, 150);
            this.fkategori.Name = "fkategori";
            this.fkategori.Size = new System.Drawing.Size(104, 20);
            this.fkategori.TabIndex = 26;
            this.fkategori.Text = "KATEGORİ :";
            // 
            // feposta
            // 
            this.feposta.AutoSize = true;
            this.feposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.feposta.Location = new System.Drawing.Point(8, 153);
            this.feposta.Name = "feposta";
            this.feposta.Size = new System.Drawing.Size(92, 20);
            this.feposta.TabIndex = 25;
            this.feposta.Text = "E-POSTA :";
            // 
            // fiadres
            // 
            this.fiadres.AutoSize = true;
            this.fiadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiadres.Location = new System.Drawing.Point(384, 24);
            this.fiadres.Name = "fiadres";
            this.fiadres.Size = new System.Drawing.Size(81, 20);
            this.fiadres.TabIndex = 24;
            this.fiadres.Text = "ADRESİ :";
            // 
            // fitelno
            // 
            this.fitelno.AutoSize = true;
            this.fitelno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fitelno.Location = new System.Drawing.Point(8, 108);
            this.fitelno.Name = "fitelno";
            this.fitelno.Size = new System.Drawing.Size(126, 20);
            this.fitelno.TabIndex = 23;
            this.fitelno.Text = "TELEFON NO :";
            // 
            // fadi
            // 
            this.fadi.AutoSize = true;
            this.fadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fadi.Location = new System.Drawing.Point(8, 66);
            this.fadi.Name = "fadi";
            this.fadi.Size = new System.Drawing.Size(47, 20);
            this.fadi.TabIndex = 22;
            this.fadi.Text = "ADI :";
            // 
            // fid
            // 
            this.fid.AutoSize = true;
            this.fid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fid.Location = new System.Drawing.Point(8, 24);
            this.fid.Name = "fid";
            this.fid.Size = new System.Drawing.Size(100, 20);
            this.fid.TabIndex = 21;
            this.fid.Text = "FİRMA NO :";
            this.fid.Click += new System.EventHandler(this.fid_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tedarikcilerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 708);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vergiadbox);
            this.Controls.Add(this.verginobox);
            this.Controls.Add(this.kategoricbox);
            this.Controls.Add(this.epostabox);
            this.Controls.Add(this.fadresbox);
            this.Controls.Add(this.ftelnobox);
            this.Controls.Add(this.fadibox);
            this.Controls.Add(this.fidbox);
            this.Controls.Add(this.tmzlbtn);
            this.Controls.Add(this.gnclbtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.kydtbtn);
            this.Controls.Add(this.fvergidairesi);
            this.Controls.Add(this.fvergino);
            this.Controls.Add(this.fkategori);
            this.Controls.Add(this.feposta);
            this.Controls.Add(this.fiadres);
            this.Controls.Add(this.fitelno);
            this.Controls.Add(this.fadi);
            this.Controls.Add(this.fid);
            this.Name = "tedarikcilerform";
            this.Text = "tedarikcilerform";
            this.Load += new System.EventHandler(this.tedarikcilerform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void kategoricbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void fid_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox vergiadbox;
        private System.Windows.Forms.TextBox verginobox;
        private System.Windows.Forms.ComboBox kategoricbox;
        private System.Windows.Forms.TextBox epostabox;
        private System.Windows.Forms.TextBox fadresbox;
        private System.Windows.Forms.TextBox ftelnobox;
        private System.Windows.Forms.TextBox fadibox;
        private System.Windows.Forms.TextBox fidbox;
        private System.Windows.Forms.Button tmzlbtn;
        private System.Windows.Forms.Button gnclbtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button kydtbtn;
        private System.Windows.Forms.Label fvergidairesi;
        private System.Windows.Forms.Label fvergino;
        private System.Windows.Forms.Label fkategori;
        private System.Windows.Forms.Label feposta;
        private System.Windows.Forms.Label fiadres;
        private System.Windows.Forms.Label fitelno;
        private System.Windows.Forms.Label fadi;
        private System.Windows.Forms.Label fid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}