
namespace _6_Zhal
{
    partial class frmZhal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.rbtAluminum = new System.Windows.Forms.RadioButton();
            this.rbtPlastic = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(42, 312);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(126, 40);
            this.btCalc.TabIndex = 0;
            this.btCalc.Text = "Расчет";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(249, 312);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(126, 40);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ширина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Высота:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "см";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "см";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Стоимость:";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(249, 233);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(138, 65);
            this.lblResult.TabIndex = 7;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(158, 43);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(142, 30);
            this.txtHeight.TabIndex = 8;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(158, 102);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(142, 30);
            this.txtWidth.TabIndex = 9;
            // 
            // rbtAluminum
            // 
            this.rbtAluminum.AutoSize = true;
            this.rbtAluminum.Location = new System.Drawing.Point(42, 174);
            this.rbtAluminum.Name = "rbtAluminum";
            this.rbtAluminum.Size = new System.Drawing.Size(131, 29);
            this.rbtAluminum.TabIndex = 12;
            this.rbtAluminum.TabStop = true;
            this.rbtAluminum.Text = "алюминий";
            this.rbtAluminum.UseVisualStyleBackColor = true;
            // 
            // rbtPlastic
            // 
            this.rbtPlastic.AutoSize = true;
            this.rbtPlastic.Location = new System.Drawing.Point(249, 174);
            this.rbtPlastic.Name = "rbtPlastic";
            this.rbtPlastic.Size = new System.Drawing.Size(109, 29);
            this.rbtPlastic.TabIndex = 13;
            this.rbtPlastic.TabStop = true;
            this.rbtPlastic.Text = "пластик";
            this.rbtPlastic.UseVisualStyleBackColor = true;
            // 
            // frmZhal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(418, 396);
            this.Controls.Add(this.rbtPlastic);
            this.Controls.Add(this.rbtAluminum);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCalc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmZhal";
            this.Text = "Жалюзи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.RadioButton rbtAluminum;
        private System.Windows.Forms.RadioButton rbtPlastic;
    }
}

