using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adisyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            if (checkBoxCay.Checked == true) //checkBox seçiliyse 
            {
                toplam = toplam + 1.5;
            }
            if (checkBoxSimit.Checked == true)
            {
                toplam = toplam + 1.5;
            }
            if (checkBoxGazoz.Checked == true)
            {
                toplam = toplam + 1.5;
            }
            if (checkBoxSoda.Checked == true)
            {
                toplam = toplam + 1;
            }
            if (checkBoxAyran.Checked == true)
            {
                toplam = toplam + 2;
            }
            if (checkBoxKola.Checked == true)
            {
                toplam = toplam + 4;
            }
            txtHesap.Text = toplam.ToString() + " TL";

            temizle();
        }
        void temizle()
        {
            checkBoxCay.Checked = false;
            checkBoxSimit.Checked = false;
            checkBoxAyran.Checked = false;
            checkBoxKola.Checked = false;
            checkBoxGazoz.Checked = false;
            checkBoxSoda.Checked = false;
        }
    }
}
