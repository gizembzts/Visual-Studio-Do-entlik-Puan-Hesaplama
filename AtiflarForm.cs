using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace docentlik_puan_hesaplama
{    
    public partial class AtiflarForm : Form
    {
        public int Puan;
        Form1 ownerForm = null;
        public AtiflarForm(Form1 ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        private void btn_atif_ekle_Click(object sender, EventArgs e)
        {
            string result = "";
            result = (cmb_atif_doktora.SelectedItem.ToString() + " Atıf - " + Puan.ToString());


            this.ownerForm.PassValue(result);
            this.Close();
        }

        private void AtiflarForm_Load(object sender, EventArgs e)
        {
            cmb_atif_doktora.Items.Add("Doktora Öncesi");
            cmb_atif_doktora.Items.Add("Doktora Sonrası");
        }
    }
}
