using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace docentlik_puan_hesaplama
{
    public partial class Patent1 : Form
    {
        public int Puan;
        Form1 ownerForm = null;
        public Patent1(Form1 ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        private void editörlük_veya_bölüm_yazarlığı_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Patent1_Load(object sender, EventArgs e)
        {
            cmb_patent_doktora.Items.Add("Doktora Öncesi");
            cmb_patent_doktora.Items.Add("Doktora Sonrası");
        }

        private void btn_lisans_ekle_Click(object sender, EventArgs e)
        {
            string result = "";
            result = (cmb_patent_doktora.SelectedItem.ToString() + " Kitap - " + Puan.ToString());


            this.ownerForm.PassValue(result);
            this.Close();
        }
    }
}
