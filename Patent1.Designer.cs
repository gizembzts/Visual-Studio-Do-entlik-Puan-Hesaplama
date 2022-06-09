
namespace docentlik_puan_hesaplama
{
    partial class Patent1
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
            this.patent_sayısı = new System.Windows.Forms.NumericUpDown();
            this.patent_yazar_sayi = new System.Windows.Forms.NumericUpDown();
            this.btn_patent_ekle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_patent_doktora = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.patent_sayısı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patent_yazar_sayi)).BeginInit();
            this.SuspendLayout();
            // 
            // patent_sayısı
            // 
            this.patent_sayısı.Location = new System.Drawing.Point(189, 132);
            this.patent_sayısı.Name = "patent_sayısı";
            this.patent_sayısı.Size = new System.Drawing.Size(120, 23);
            this.patent_sayısı.TabIndex = 41;
            this.patent_sayısı.ValueChanged += new System.EventHandler(this.editörlük_veya_bölüm_yazarlığı_ValueChanged);
            // 
            // patent_yazar_sayi
            // 
            this.patent_yazar_sayi.Location = new System.Drawing.Point(188, 176);
            this.patent_yazar_sayi.Name = "patent_yazar_sayi";
            this.patent_yazar_sayi.Size = new System.Drawing.Size(120, 23);
            this.patent_yazar_sayi.TabIndex = 40;
            // 
            // btn_patent_ekle
            // 
            this.btn_patent_ekle.Location = new System.Drawing.Point(91, 240);
            this.btn_patent_ekle.Name = "btn_patent_ekle";
            this.btn_patent_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_patent_ekle.TabIndex = 39;
            this.btn_patent_ekle.Text = "Ekle";
            this.btn_patent_ekle.UseVisualStyleBackColor = true;
            this.btn_patent_ekle.Click += new System.EventHandler(this.btn_lisans_ekle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Yazar Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Patent Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Doktora  Zamanı";
            // 
            // cmb_patent_doktora
            // 
            this.cmb_patent_doktora.FormattingEnabled = true;
            this.cmb_patent_doktora.Location = new System.Drawing.Point(188, 84);
            this.cmb_patent_doktora.Name = "cmb_patent_doktora";
            this.cmb_patent_doktora.Size = new System.Drawing.Size(121, 23);
            this.cmb_patent_doktora.TabIndex = 35;
            // 
            // Patent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 346);
            this.Controls.Add(this.patent_sayısı);
            this.Controls.Add(this.patent_yazar_sayi);
            this.Controls.Add(this.btn_patent_ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_patent_doktora);
            this.Name = "Patent1";
            this.Text = "Patent1";
            this.Load += new System.EventHandler(this.Patent1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patent_sayısı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patent_yazar_sayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown patent_sayısı;
        private System.Windows.Forms.NumericUpDown patent_yazar_sayi;
        private System.Windows.Forms.Button btn_patent_ekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_patent_doktora;
    }
}