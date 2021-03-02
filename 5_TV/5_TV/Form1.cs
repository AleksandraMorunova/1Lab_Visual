using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_TV {
    /// <summary>
    /// Программа Телевизор
    /// </summary>
    public partial class frmTV : Form {
        public frmTV() {
            InitializeComponent();
        }
        private void rbtInter_CheckedChanged(object sender, EventArgs e) {
            pctUT1.Visible = false;
            pctInter.Visible = true;
            pct1p1.Visible = false;
            pctSTB.Visible = false;
            lblCanal.Text = "Сейчас в эфире 'Стосується кожного'";
        }
        private void rbt1p1_CheckedChanged(object sender, EventArgs e)  {
            pctUT1.Visible = false;
            pctInter.Visible = false;
            pct1p1.Visible = true;
            pctSTB.Visible = false;
            lblCanal.Text = "Сейчас в эфире 'Сніданок з 1 + 1'";
        }
        private void rbtSTB_CheckedChanged(object sender, EventArgs e) {
            pctUT1.Visible = false;
            pctInter.Visible = false;
            pct1p1.Visible = false;
            pctSTB.Visible = true;
            lblCanal.Text = "Сейчас в эфире 'Битва екстасенсів'";
        }
        private void rbtUT1_CheckedChanged(object sender, EventArgs e) {
            pctUT1.Visible = true;
            pctInter.Visible = false;
            pct1p1.Visible = false;
            pctSTB.Visible = false;
            lblCanal.Text = "Сейчас в эфире 'Суспільна студія'";
        }
        private void btExit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
