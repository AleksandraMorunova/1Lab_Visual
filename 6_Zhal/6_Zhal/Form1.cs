using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Zhal {
    /// <summary>
    /// Программа Жалюзи определяет сумму, которую необходимо заплатить за установку жалюзи.
    /// </summary>
    public partial class frmZhal : Form  {
        public frmZhal() {
            InitializeComponent();
        }
        private void btCalc_Click(object sender, EventArgs e) {
            if (txtHeight.Text == "" || txtWidth.Text == "") {
                lblResult.Text = "Не все данные введены";
            }
            else
            {
                double width, height, result;
                width = double.Parse(txtWidth.Text);
                height = double.Parse(txtHeight.Text);
                if (rbtAluminum.Checked == true) {
                    result = (width / 100) * (height / 100) * 400;
                    lblResult.Text = result.ToString();
                }
                if (rbtPlastic.Checked == true) {
                    result = (width / 100) * (height / 100) * 190;
                    lblResult.Text = result.ToString();
                }
            }
        }
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
