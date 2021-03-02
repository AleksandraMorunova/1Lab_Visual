using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Cafe {
    /// <summary>
    /// Программа Кафе
    /// </summary>
    public partial class frmCafe : Form {
        int sum = 0;
        public frmCafe() {
            InitializeComponent();
        }
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void chkSalat_CheckedChanged(object sender, EventArgs e) {
            if (chkSalat.Checked == true) sum += 25;
            else sum -= 25;
            lblSum.Text = sum.ToString();
        }

        private void chkMeat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMeat.Checked == true) {
                sum += 70;
                chkSous.Enabled = true;
            }
            else {
                sum -= 70;
                chkSous.Enabled = false;
                chkSous.Checked = false;
            }
            lblSum.Text = sum.ToString();
        }

        private void btCalc_Click(object sender, EventArgs e) {
            if (chkSalat.Checked == false && chkMeat.Checked == false && chkSous.Checked == false && chkSok.Checked == false)
                MessageBox.Show("Вы ничего не заказывали", "Расчет");
            else if (chkSalat.Checked == true && chkMeat.Checked == true && chkSous.Checked == true && chkSok.Checked == true)
                MessageBox.Show("Вам предоставляется скидка 10%. Стоимость заказа" + (sum * 0.9).ToString() + "грн.","Расчет");
        }
    }
}
