using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace docentlik_puan_hesaplama
{
    public partial class Toplantı : Form
    {
        public int Puan;
        Form1 ownerForm = null;
        public Toplantı(Form1 ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        private void btn_toplanti_ekle_Click(object sender, EventArgs e)
        {
            string result = "";
            result = (cmb_toplanti_doktora.SelectedItem.ToString() + " Bilimsel Toplantı - " + Puan.ToString());


            this.ownerForm.PassValue(result);
            this.Close();
        }

        private void Toplantı_Load(object sender, EventArgs e)
        {
            cmb_toplanti_doktora.Items.Add("Doktora Öncesi");
            cmb_toplanti_doktora.Items.Add("Doktora Sonrası");
        }
    }
}
