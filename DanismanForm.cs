using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace docentlik_puan_hesaplama
{
    public partial class DanismanForm : Form
    {
        public int Puan;
        Form1 ownerForm = null;
        public DanismanForm(Form1 ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        private void btn_danisman_ekle_Click(object sender, EventArgs e)
        {
            string result = "";
            int danismanPuan = 0;
           
            if(cmb_danisman_seviye.SelectedItem.ToString() == "Asıl Danışman")
            {
                danismanPuan = Puan;
                result = (cmb_danisman_doktora.SelectedItem.ToString() + " " + cmb_danisman_seviye.SelectedItem.ToString() + " - " + danismanPuan.ToString());
            }
            else if(cmb_danisman_seviye.SelectedItem.ToString() == "Eş Danışman")
            {
                danismanPuan = Puan/2;
                result = (cmb_danisman_doktora.SelectedItem.ToString() + " " + cmb_danisman_seviye.SelectedItem.ToString() + " - " + danismanPuan.ToString());
            }

            this.ownerForm.PassValue(result);
            this.Close();
        }

        private void DanismanForm_Load(object sender, EventArgs e)
        {
            cmb_danisman_doktora.Items.Add("Doktora Öncesi");
            cmb_danisman_doktora.Items.Add("Doktora Sonrası");

            cmb_danisman_seviye.Items.Add("Asıl Danışman");
            cmb_danisman_seviye.Items.Add("Eş Danışman");
        }
    }
}
