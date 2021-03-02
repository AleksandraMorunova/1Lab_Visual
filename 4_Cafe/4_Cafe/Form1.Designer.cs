
namespace _4_Cafe
{
    partial class frmCafe
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
            this.btCalc = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSalat = new System.Windows.Forms.CheckBox();
            this.chkMeat = new System.Windows.Forms.CheckBox();
            this.chkSous = new System.Windows.Forms.CheckBox();
            this.chkSok = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCalc
            // 
            this.btCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCalc.Location = new System.Drawing.Point(33, 376);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(137, 48);
            this.btCalc.TabIndex = 0;
            this.btCalc.Text = "Расчет";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Location = new System.Drawing.Point(225, 376);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(137, 48);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите блюда для заказа. При заказе всех блюд Вы получаете скидку 10%";
            // 
            // chkSalat
            // 
            this.chkSalat.AutoSize = true;
            this.chkSalat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSalat.Location = new System.Drawing.Point(33, 127);
            this.chkSalat.Name = "chkSalat";
            this.chkSalat.Size = new System.Drawing.Size(133, 22);
            this.chkSalat.TabIndex = 3;
            this.chkSalat.Text = "Салат (25 грн.)";
            this.chkSalat.UseVisualStyleBackColor = true;
            this.chkSalat.CheckedChanged += new System.EventHandler(this.chkSalat_CheckedChanged);
            // 
            // chkMeat
            // 
            this.chkMeat.AutoSize = true;
            this.chkMeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkMeat.Location = new System.Drawing.Point(33, 179);
            this.chkMeat.Name = "chkMeat";
            this.chkMeat.Size = new System.Drawing.Size(195, 22);
            this.chkMeat.TabIndex = 4;
            this.chkMeat.Text = "Мясное блюдо (70 грн.)";
            this.chkMeat.UseVisualStyleBackColor = true;
            this.chkMeat.CheckedChanged += new System.EventHandler(this.chkMeat_CheckedChanged);
            // 
            // chkSous
            // 
            this.chkSous.AutoSize = true;
            this.chkSous.Enabled = false;
            this.chkSous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSous.Location = new System.Drawing.Point(33, 235);
            this.chkSous.Name = "chkSous";
            this.chkSous.Size = new System.Drawing.Size(117, 22);
            this.chkSous.TabIndex = 5;
            this.chkSous.Text = "Соус (5 грн.)";
            this.chkSous.UseVisualStyleBackColor = true;
            // 
            // chkSok
            // 
            this.chkSok.AutoSize = true;
            this.chkSok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSok.Location = new System.Drawing.Point(33, 288);
            this.chkSok.Name = "chkSok";
            this.chkSok.Size = new System.Drawing.Size(118, 22);
            this.chkSok.TabIndex = 6;
            this.chkSok.Text = "Сок (10 грн.)";
            this.chkSok.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Стоимость заказа (грн.):";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSum.Location = new System.Drawing.Point(283, 331);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 20);
            this.lblSum.TabIndex = 8;
            // 
            // frmCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkSok);
            this.Controls.Add(this.chkSous);
            this.Controls.Add(this.chkMeat);
            this.Controls.Add(this.chkSalat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCafe";
            this.Text = "Кафе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSalat;
        private System.Windows.Forms.CheckBox chkMeat;
        private System.Windows.Forms.CheckBox chkSous;
        private System.Windows.Forms.CheckBox chkSok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSum;
    }
}

