
namespace _5_TV
{
    partial class frmTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTV));
            this.label1 = new System.Windows.Forms.Label();
            this.rbtUT1 = new System.Windows.Forms.RadioButton();
            this.rbtInter = new System.Windows.Forms.RadioButton();
            this.lblCanal = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.rbtSTB = new System.Windows.Forms.RadioButton();
            this.rbt1p1 = new System.Windows.Forms.RadioButton();
            this.pct1p1 = new System.Windows.Forms.PictureBox();
            this.pctSTB = new System.Windows.Forms.PictureBox();
            this.pctUT1 = new System.Windows.Forms.PictureBox();
            this.pctInter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct1p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите телевизионный канал";
            // 
            // rbtUT1
            // 
            this.rbtUT1.AutoSize = true;
            this.rbtUT1.Checked = true;
            this.rbtUT1.Location = new System.Drawing.Point(37, 93);
            this.rbtUT1.Name = "rbtUT1";
            this.rbtUT1.Size = new System.Drawing.Size(68, 29);
            this.rbtUT1.TabIndex = 1;
            this.rbtUT1.TabStop = true;
            this.rbtUT1.Text = "УТ1";
            this.rbtUT1.UseVisualStyleBackColor = true;
            this.rbtUT1.CheckedChanged += new System.EventHandler(this.rbtUT1_CheckedChanged);
            // 
            // rbtInter
            // 
            this.rbtInter.AutoSize = true;
            this.rbtInter.Location = new System.Drawing.Point(37, 166);
            this.rbtInter.Name = "rbtInter";
            this.rbtInter.Size = new System.Drawing.Size(92, 29);
            this.rbtInter.TabIndex = 2;
            this.rbtInter.Text = "Интер";
            this.rbtInter.UseVisualStyleBackColor = true;
            this.rbtInter.CheckedChanged += new System.EventHandler(this.rbtInter_CheckedChanged);
            // 
            // lblCanal
            // 
            this.lblCanal.Location = new System.Drawing.Point(43, 374);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(318, 80);
            this.lblCanal.TabIndex = 9;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(116, 496);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(144, 44);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Выключить";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // rbtSTB
            // 
            this.rbtSTB.AutoSize = true;
            this.rbtSTB.Location = new System.Drawing.Point(37, 306);
            this.rbtSTB.Name = "rbtSTB";
            this.rbtSTB.Size = new System.Drawing.Size(70, 29);
            this.rbtSTB.TabIndex = 4;
            this.rbtSTB.Text = "СТБ";
            this.rbtSTB.UseVisualStyleBackColor = true;
            this.rbtSTB.CheckedChanged += new System.EventHandler(this.rbtSTB_CheckedChanged);
            // 
            // rbt1p1
            // 
            this.rbt1p1.AutoSize = true;
            this.rbt1p1.Location = new System.Drawing.Point(37, 238);
            this.rbt1p1.Name = "rbt1p1";
            this.rbt1p1.Size = new System.Drawing.Size(67, 29);
            this.rbt1p1.TabIndex = 3;
            this.rbt1p1.Text = "1+1";
            this.rbt1p1.UseVisualStyleBackColor = true;
            this.rbt1p1.CheckedChanged += new System.EventHandler(this.rbt1p1_CheckedChanged);
            // 
            // pct1p1
            // 
            this.pct1p1.Image = ((System.Drawing.Image)(resources.GetObject("pct1p1.Image")));
            this.pct1p1.Location = new System.Drawing.Point(110, 50);
            this.pct1p1.Name = "pct1p1";
            this.pct1p1.Size = new System.Drawing.Size(150, 150);
            this.pct1p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct1p1.TabIndex = 5;
            this.pct1p1.TabStop = false;
            this.pct1p1.Visible = false;
            // 
            // pctSTB
            // 
            this.pctSTB.Image = ((System.Drawing.Image)(resources.GetObject("pctSTB.Image")));
            this.pctSTB.Location = new System.Drawing.Point(110, 50);
            this.pctSTB.Name = "pctSTB";
            this.pctSTB.Size = new System.Drawing.Size(150, 150);
            this.pctSTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSTB.TabIndex = 6;
            this.pctSTB.TabStop = false;
            // 
            // pctUT1
            // 
            this.pctUT1.Image = ((System.Drawing.Image)(resources.GetObject("pctUT1.Image")));
            this.pctUT1.Location = new System.Drawing.Point(110, 50);
            this.pctUT1.Name = "pctUT1";
            this.pctUT1.Size = new System.Drawing.Size(150, 150);
            this.pctUT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUT1.TabIndex = 7;
            this.pctUT1.TabStop = false;
            // 
            // pctInter
            // 
            this.pctInter.Image = ((System.Drawing.Image)(resources.GetObject("pctInter.Image")));
            this.pctInter.Location = new System.Drawing.Point(110, 50);
            this.pctInter.Name = "pctInter";
            this.pctInter.Size = new System.Drawing.Size(150, 150);
            this.pctInter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctInter.TabIndex = 8;
            this.pctInter.TabStop = false;
            this.pctInter.Visible = false;
            // 
            // frmTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(391, 569);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lblCanal);
            this.Controls.Add(this.pctInter);
            this.Controls.Add(this.pctUT1);
            this.Controls.Add(this.pctSTB);
            this.Controls.Add(this.pct1p1);
            this.Controls.Add(this.rbtSTB);
            this.Controls.Add(this.rbt1p1);
            this.Controls.Add(this.rbtInter);
            this.Controls.Add(this.rbtUT1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTV";
            this.Text = "Телевизор";
            ((System.ComponentModel.ISupportInitialize)(this.pct1p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtUT1;
        private System.Windows.Forms.RadioButton rbtInter;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.RadioButton rbtSTB;
        private System.Windows.Forms.RadioButton rbt1p1;
        private System.Windows.Forms.PictureBox pct1p1;
        private System.Windows.Forms.PictureBox pctSTB;
        private System.Windows.Forms.PictureBox pctUT1;
        private System.Windows.Forms.PictureBox pctInter;
    }
}

