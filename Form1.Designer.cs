namespace Компонент
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flag1 = new Компонент.Flag();
            this.flag2 = new Компонент.Flag();
            this.flag3 = new Компонент.Flag();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // flag1
            // 
            this.flag1.Color1 = System.Drawing.Color.Blue;
            this.flag1.Color2 = System.Drawing.Color.White;
            this.flag1.Color3 = System.Drawing.Color.Red;
            this.flag1.Location = new System.Drawing.Point(55, 12);
            this.flag1.Name = "flag1";
            this.flag1.Size = new System.Drawing.Size(294, 152);
            this.flag1.TabIndex = 6;
            // 
            // flag2
            // 
            this.flag2.Color1 = System.Drawing.Color.Blue;
            this.flag2.Color2 = System.Drawing.Color.White;
            this.flag2.Color3 = System.Drawing.Color.Red;
            this.flag2.Location = new System.Drawing.Point(102, 219);
            this.flag2.Name = "flag2";
            this.flag2.Size = new System.Drawing.Size(263, 160);
            this.flag2.TabIndex = 7;
            // 
            // flag3
            // 
            this.flag3.Color1 = System.Drawing.Color.Blue;
            this.flag3.Color2 = System.Drawing.Color.White;
            this.flag3.Color3 = System.Drawing.Color.Red;
            this.flag3.Location = new System.Drawing.Point(503, 248);
            this.flag3.Name = "flag3";
            this.flag3.Size = new System.Drawing.Size(304, 190);
            this.flag3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flag3);
            this.Controls.Add(this.flag2);
            this.Controls.Add(this.flag1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private Flag flag1;
        private Flag flag2;
        private Flag flag3;
    }
}

