using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Auto {
    /// <summary>
    /// Программа Автозаправка вычисляет количество литров бензина
    /// </summary>
    public partial class frmAuto : Form {
        public frmAuto() {
            InitializeComponent();
        }
        private void btExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btCalc_Click(object sender, EventArgs e) {
            int n;
            double price, sum, litrs;
            n = cmbBenz.SelectedIndex;
            switch (n) {
                case 0:
                    price = 14.85;
                    break;
                case 1:
                    price = 15.05;
                    break;
                case 2:
                    price = 16.80;
                    break;
                case 3:
                    price = 14.55;
                    break;
                default:
                    price = 0;
                    break;
            }
            if(price == 0 || txtSum.Text == "") {
                lblPrice.Text = "";
                lblLitr.Text = "Не все данные выбраны!";
            }
            else
            {
                lblPrice.Text = price.ToString();
                sum = double.Parse(txtSum.Text);
                litrs = Math.Round(sum / price, 2);
                lblLitr.Text = litrs.ToString();
            }
        }

        private void frmAuto_Load(object sender, EventArgs e) {
            cmbBenz.Items.Add("92");
            cmbBenz.Items.Add("95");
            cmbBenz.Items.Add("98");
            cmbBenz.Items.Add("ДТ");
        }
    }

}
