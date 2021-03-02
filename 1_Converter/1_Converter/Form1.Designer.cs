
namespace _1_Converter
{
    partial class frmConv
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
            this.txtKurs = new System.Windows.Forms.TextBox();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUAH = new System.Windows.Forms.Label();
            this.btCalc = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKurs
            // 
            this.txtKurs.Location = new System.Drawing.Point(239, 177);
            this.txtKurs.Name = "txtKurs";
            this.txtKurs.Size = new System.Drawing.Size(100, 30);
            this.txtKurs.TabIndex = 0;
            this.txtKurs.Text = "25,2";
            // 
            // txtUSD
            // 
            this.txtUSD.Location = new System.Drawing.Point(239, 117);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(100, 30);
            this.txtUSD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена (USD):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Курс (UAH/USD):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Цена (UAH):";
            // 
            // lblUAH
            // 
            this.lblUAH.AutoSize = true;
            this.lblUAH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUAH.Location = new System.Drawing.Point(175, 250);
            this.lblUAH.Name = "lblUAH";
            this.lblUAH.Size = new System.Drawing.Size(18, 20);
            this.lblUAH.TabIndex = 6;
            this.lblUAH.Text = "_";
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(49, 307);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(120, 42);
            this.btCalc.TabIndex = 7;
            this.btCalc.Text = "Пересчет";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(205, 307);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(120, 42);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 82);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите курс, цену в долларах и щелкните на  кнопке Пересчет";
            // 
            // frmConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(381, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.lblUAH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUSD);
            this.Controls.Add(this.txtKurs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConv";
            this.Text = "Конвертер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKurs;
        private System.Windows.Forms.TextBox txtUSD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUAH;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
    }
}

