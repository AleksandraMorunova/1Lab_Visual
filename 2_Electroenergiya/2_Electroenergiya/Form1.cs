using System;
using System.Windows.Forms;

namespace _2_Electroenergiya {
    /// <summary>
    /// Программа Электроэнергия определяет сумму, которую необходимо заплатить за пользование электроэнергией на основании показаний счетчика.
    /// </summary>
    public partial class frmEl : Form {
        public frmEl() {
            InitializeComponent();
        }
        private void btCalc_Click(object sender, EventArgs e) {
            double pastPrice, presentPrice, resultPrice, price;
            if (txtPast.Text == "" || txtPresent.Text == "" || txtPrice.Text == "") {
                lblResult.Text = "Не все данные введены";
            }
            else {
                pastPrice = double.Parse(txtPast.Text);
                presentPrice = double.Parse(txtPresent.Text);
                resultPrice = double.Parse(txtPrice.Text);
                price = (presentPrice - pastPrice) * resultPrice;
                lblResult.Text = price.ToString();
            }
        }
        private void btExit_Click_1(object sender, EventArgs e) {
            //this.Close();
            Application.Exit();
        }
    }
}
