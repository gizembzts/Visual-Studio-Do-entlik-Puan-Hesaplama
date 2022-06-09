
namespace docentlik_puan_hesaplama
{
    partial class ArastirmaForm
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
            this.arastirma_sayisi = new System.Windows.Forms.NumericUpDown();
            this.btn_arastirma_ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_arastirma_doktora = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.arastirma_sayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // arastirma_sayisi
            // 
            this.arastirma_sayisi.Location = new System.Drawing.Point(165, 67);
            this.arastirma_sayisi.Name = "arastirma_sayisi";
            this.arastirma_sayisi.Size = new System.Drawing.Size(120, 23);
            this.arastirma_sayisi.TabIndex = 26;
            // 
            // btn_arastirma_ekle
            // 
            this.btn_arastirma_ekle.Location = new System.Drawing.Point(105, 122);
            this.btn_arastirma_ekle.Name = "btn_arastirma_ekle";
            this.btn_arastirma_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_arastirma_ekle.TabIndex = 25;
            this.btn_arastirma_ekle.Text = "Ekle";
            this.btn_arastirma_ekle.UseVisualStyleBackColor = true;
            this.btn_arastirma_ekle.Click += new System.EventHandler(this.btn_arastirma_ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Proje Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Doktora  Zamanı";
            // 
            // cmb_arastirma_doktora
            // 
            this.cmb_arastirma_doktora.FormattingEnabled = true;
            this.cmb_arastirma_doktora.Location = new System.Drawing.Point(164, 38);
            this.cmb_arastirma_doktora.Name = "cmb_arastirma_doktora";
            this.cmb_arastirma_doktora.Size = new System.Drawing.Size(121, 23);
            this.cmb_arastirma_doktora.TabIndex = 22;
            // 
            // ArastirmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 295);
            this.Controls.Add(this.arastirma_sayisi);
            this.Controls.Add(this.btn_arastirma_ekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_arastirma_doktora);
            this.Name = "ArastirmaForm";
            this.Text = "ArastirmaForm";
            this.Load += new System.EventHandler(this.ArastirmaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arastirma_sayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown arastirma_sayisi;
        private System.Windows.Forms.Button btn_arastirma_ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_arastirma_doktora;
    }
}