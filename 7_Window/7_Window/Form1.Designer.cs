
namespace _7_Window
{
    partial class frmWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.lblSum = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkPod = new System.Windows.Forms.CheckBox();
            this.chkShip = new System.Windows.Forms.CheckBox();
            this.btCalc = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Высота:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "см";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "см";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 30);
            this.textBox2.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер окна:";
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.Location = new System.Drawing.Point(6, 134);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(171, 29);
            this.rbt3.TabIndex = 10;
            this.rbt3.Text = "Энергосберега";
            this.rbt3.UseVisualStyleBackColor = true;
            this.rbt3.CheckedChanged += new System.EventHandler(this.rbt3_CheckedChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(156, 184);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(85, 25);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "350 грн.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Цена за кв. м:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Стоимость:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt1);
            this.groupBox2.Controls.Add(this.rbt2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rbt3);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Location = new System.Drawing.Point(294, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 216);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стеклопакет:";
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Checked = true;
            this.rbt1.Location = new System.Drawing.Point(6, 39);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(177, 29);
            this.rbt1.TabIndex = 8;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Однокамерный";
            this.rbt1.UseVisualStyleBackColor = true;
            this.rbt1.CheckedChanged += new System.EventHandler(this.rbt1_CheckedChanged);
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Location = new System.Drawing.Point(6, 85);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(174, 29);
            this.rbt2.TabIndex = 9;
            this.rbt2.Text = "Двухкамерный";
            this.rbt2.UseVisualStyleBackColor = true;
            this.rbt2.CheckedChanged += new System.EventHandler(this.rbt2_CheckedChanged);
            // 
            // lblSum
            // 
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSum.Location = new System.Drawing.Point(426, 266);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(137, 57);
            this.lblSum.TabIndex = 15;
            this.lblSum.Text = "_";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkPod);
            this.groupBox3.Controls.Add(this.chkShip);
            this.groupBox3.Location = new System.Drawing.Point(12, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 178);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // chkPod
            // 
            this.chkPod.Checked = true;
            this.chkPod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPod.Location = new System.Drawing.Point(13, 91);
            this.chkPod.Name = "chkPod";
            this.chkPod.Size = new System.Drawing.Size(182, 58);
            this.chkPod.TabIndex = 20;
            this.chkPod.Text = "Подоконник (200 грн. за м)";
            this.chkPod.UseVisualStyleBackColor = true;
            // 
            // chkShip
            // 
            this.chkShip.AutoSize = true;
            this.chkShip.Checked = true;
            this.chkShip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShip.Location = new System.Drawing.Point(13, 44);
            this.chkShip.Name = "chkShip";
            this.chkShip.Size = new System.Drawing.Size(124, 29);
            this.chkShip.TabIndex = 19;
            this.chkShip.Text = "Доставка";
            this.chkShip.UseVisualStyleBackColor = true;
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(300, 364);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(99, 46);
            this.btCalc.TabIndex = 0;
            this.btCalc.Text = "Расчет";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(425, 364);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(99, 46);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDelivery.Location = new System.Drawing.Point(426, 323);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(23, 25);
            this.lblDelivery.TabIndex = 17;
            this.lblDelivery.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "+Доставка:";
            // 
            // frmWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(586, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmWindow";
            this.Text = "Стеклопакет";
            this.Load += new System.EventHandler(this.frmWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.CheckBox chkPod;
        private System.Windows.Forms.CheckBox chkShip;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label label1;
    }
}

