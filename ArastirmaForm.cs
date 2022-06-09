using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace docentlik_puan_hesaplama
{
    public partial class ArastirmaForm : Form
    {
        public int Puan;
        Form1 ownerForm = null;
        public ArastirmaForm(Form1 ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        private void ArastirmaForm_Load(object sender, EventArgs e)
        {

            cmb_arastirma_doktora.Items.Add("Doktora Öncesi");
            cmb_arastirma_doktora.Items.Add("Doktora Sonrası");
        }

        private void btn_arastirma_ekle_Click(object sender, EventArgs e)
        {
            string result = "";
            result = (cmb_arastirma_doktora.SelectedItem.ToString() + " Araştırma - " + Puan.ToString());


            this.ownerForm.PassValue(result);
            this.Close();
        }
    }
}
