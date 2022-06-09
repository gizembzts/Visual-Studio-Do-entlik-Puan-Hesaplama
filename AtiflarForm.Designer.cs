
namespace docentlik_puan_hesaplama
{
    partial class AtiflarForm
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
            this.atif_sayisi = new System.Windows.Forms.NumericUpDown();
            this.btn_atif_ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_atif_doktora = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.atif_sayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // atif_sayisi
            // 
            this.atif_sayisi.Location = new System.Drawing.Point(172, 56);
            this.atif_sayisi.Name = "atif_sayisi";
            this.atif_sayisi.Size = new System.Drawing.Size(120, 23);
            this.atif_sayisi.TabIndex = 21;
            // 
            // btn_atif_ekle
            // 
            this.btn_atif_ekle.Location = new System.Drawing.Point(112, 111);
            this.btn_atif_ekle.Name = "btn_atif_ekle";
            this.btn_atif_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_atif_ekle.TabIndex = 18;
            this.btn_atif_ekle.Text = "Ekle";
            this.btn_atif_ekle.UseVisualStyleBackColor = true;
            this.btn_atif_ekle.Click += new System.EventHandler(this.btn_atif_ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Atıf Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Doktora  Zamanı";
            // 
            // cmb_atif_doktora
            // 
            this.cmb_atif_doktora.FormattingEnabled = true;
            this.cmb_atif_doktora.Location = new System.Drawing.Point(171, 27);
            this.cmb_atif_doktora.Name = "cmb_atif_doktora";
            this.cmb_atif_doktora.Size = new System.Drawing.Size(121, 23);
            this.cmb_atif_doktora.TabIndex = 11;
            // 
            // AtiflarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 309);
            this.Controls.Add(this.atif_sayisi);
            this.Controls.Add(this.btn_atif_ekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_atif_doktora);
            this.Name = "AtiflarForm";
            this.Text = "AtiflarForm";
            this.Load += new System.EventHandler(this.AtiflarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atif_sayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown atif_sayisi;
        private System.Windows.Forms.Button btn_atif_ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_atif_doktora;
    }
}