using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Window {
    /// <summary>
    /// Программа Стеклопакет позволяет вычислить стоимость окна (стеклопакета).
    /// </summary>
    public partial class frmWindow : Form {
        public frmWindow() {
            InitializeComponent();
        }
        private void rbt1_CheckedChanged(object sender, EventArgs e) {
            lblPrice.Text = "350 грн.";
            lblSum.Text = "_";
        }
        private void rbt2_CheckedChanged(object sender, EventArgs e) {
            lblPrice.Text = "400 грн.";
            lblSum.Text = "_";
        }
        private void rbt3_CheckedChanged(object sender, EventArgs e) {
            lblPrice.Text = "450 грн.";
            lblSum.Text = "_";
        }
        private void btCalc_Click(object sender, EventArgs e) {
            if (textBox1.Text == "" || textBox2.Text == "") {
                lblSum.Text = "Не все данные введены";
            }
            else
            {
                double height, width, preResult;
                double price = 0;
                height = double.Parse(textBox2.Text);
                width = double.Parse(textBox1.Text);
                preResult = (height / 100) * (width / 100);
                if (rbt1.Checked == true) {
                    price += 350 * preResult;
                }
                if (rbt2.Checked == true) {
                    price += 400 * preResult;
                }
                if (rbt3.Checked == true) {
                    price += 450 * preResult;
                }
                if (chkPod.Checked == true) {
                    price += price + 200 * (width / 100);
                }
                lblSum.Text = price.ToString();
                if (chkShip.Checked == true) {
                    lblDelivery.Text = "50 грн";
                }
                else lblDelivery.Text = "Без доставки";
            }
        }
        private void frmWindow_Load(object sender, EventArgs e) {
        }
    }
}
