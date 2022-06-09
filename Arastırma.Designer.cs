
namespace docentlik_puan_hesaplama
{
    partial class Arastırma
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
            this.proje_sayısı = new System.Windows.Forms.NumericUpDown();
            this.btn_arastirma_ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_arastirma_doktora = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.proje_sayısı)).BeginInit();
            this.SuspendLayout();
            // 
            // proje_sayısı
            // 
            this.proje_sayısı.Location = new System.Drawing.Point(201, 124);
            this.proje_sayısı.Name = "proje_sayısı";
            this.proje_sayısı.Size = new System.Drawing.Size(120, 23);
            this.proje_sayısı.TabIndex = 48;
            // 
            // btn_arastirma_ekle
            // 
            this.btn_arastirma_ekle.Location = new System.Drawing.Point(103, 232);
            this.btn_arastirma_ekle.Name = "btn_arastirma_ekle";
            this.btn_arastirma_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_arastirma_ekle.TabIndex = 46;
            this.btn_arastirma_ekle.Text = "Ekle";
            this.btn_arastirma_ekle.UseVisualStyleBackColor = true;
            this.btn_arastirma_ekle.Click += new System.EventHandler(this.btn_arastirma_ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Proje Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Doktora  Zamanı";
            // 
            // cmb_arastirma_doktora
            // 
            this.cmb_arastirma_doktora.FormattingEnabled = true;
            this.cmb_arastirma_doktora.Location = new System.Drawing.Point(200, 76);
            this.cmb_arastirma_doktora.Name = "cmb_arastirma_doktora";
            this.cmb_arastirma_doktora.Size = new System.Drawing.Size(121, 23);
            this.cmb_arastirma_doktora.TabIndex = 42;
            // 
            // Arastırma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 331);
            this.Controls.Add(this.proje_sayısı);
            this.Controls.Add(this.btn_arastirma_ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_arastirma_doktora);
            this.Name = "Arastırma";
            this.Text = "Arastırma";
            this.Load += new System.EventHandler(this.Arastırma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proje_sayısı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown proje_sayısı;
        private System.Windows.Forms.Button btn_arastirma_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_arastirma_doktora;
    }
}