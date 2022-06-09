using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace docentlik_puan_hesaplama
{
    public partial class Kitap1 : Form
    {
        public int Puan;
        Form1 ownerForm = null;
        public Kitap1(Form1 ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void makale_yazar_sayi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_lisans_ekle_Click(object sender, EventArgs e)
        {
            string result = "";
            result = (cmb_kitap_doktora.SelectedItem.ToString() + " Kitap - " + Puan.ToString());
            

            this.ownerForm.PassValue(result);
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bildiri_sayisi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_makale_doktora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kitap1_Load(object sender, EventArgs e)
        {
            cmb_kitap_doktora.Items.Add("Doktora Öncesi");
            cmb_kitap_doktora.Items.Add("Doktora Sonrası");
        }
    }
}
