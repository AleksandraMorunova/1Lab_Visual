using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Converter {
    /// <summary>
    /// Программа Конвертер пересчитывает цену из долларов в рубли.
    /// </summary>
    public partial class frmConv : Form {
        public frmConv() {
            InitializeComponent();
        }
        private void btExit_Click(object sender, EventArgs e) {
            //this.Close();
            Application.Exit();
        }

        private void btCalc_Click(object sender, EventArgs e)  {
            double pUSD, pUAH, kurs;
            if (txtUSD.Text == "" || txtKurs.Text == "")
{
                lblUAH.Text = "Не все данные введены";
            }
            else {
                pUSD = double.Parse(txtUSD.Text);
                kurs = double.Parse(txtKurs.Text);
                pUAH = pUSD * kurs;
                lblUAH.Text = pUAH.ToString();
            }
        }
    }
}
