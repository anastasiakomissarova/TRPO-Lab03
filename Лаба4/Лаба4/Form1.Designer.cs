namespace Лаба4
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
            this.Del1 = new System.Windows.Forms.Button();
            this.Del2 = new System.Windows.Forms.Button();
            this.Del3 = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.Pusk = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Del1
            // 
            this.Del1.Location = new System.Drawing.Point(56, 100);
            this.Del1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Del1.Name = "Del1";
            this.Del1.Size = new System.Drawing.Size(159, 94);
            this.Del1.TabIndex = 0;
            this.Del1.Text = "1";
            this.Del1.UseVisualStyleBackColor = true;
            this.Del1.Click += new System.EventHandler(this.Del1_Click);
            // 
            // Del2
            // 
            this.Del2.Location = new System.Drawing.Point(56, 226);
            this.Del2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Del2.Name = "Del2";
            this.Del2.Size = new System.Drawing.Size(159, 94);
            this.Del2.TabIndex = 1;
            this.Del2.Text = "2";
            this.Del2.UseVisualStyleBackColor = true;
            this.Del2.Click += new System.EventHandler(this.Del2_Click);
            // 
            // Del3
            // 
            this.Del3.Location = new System.Drawing.Point(56, 354);
            this.Del3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Del3.Name = "Del3";
            this.Del3.Size = new System.Drawing.Size(159, 94);
            this.Del3.TabIndex = 2;
            this.Del3.Text = "3";
            this.Del3.UseVisualStyleBackColor = true;
            this.Del3.Click += new System.EventHandler(this.Del3_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(416, 100);
            this.Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(361, 22);
            this.Input.TabIndex = 3;
            // 
            // Pusk
            // 
            this.Pusk.Location = new System.Drawing.Point(439, 226);
            this.Pusk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pusk.Name = "Pusk";
            this.Pusk.Size = new System.Drawing.Size(316, 94);
            this.Pusk.TabIndex = 4;
            this.Pusk.Text = "Пуск";
            this.Pusk.UseVisualStyleBackColor = true;
            this.Pusk.Click += new System.EventHandler(this.Pusk_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(416, 423);
            this.Output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(361, 22);
            this.Output.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Pusk);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Del3);
            this.Controls.Add(this.Del2);
            this.Controls.Add(this.Del1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Del1;
        private System.Windows.Forms.Button Del2;
        private System.Windows.Forms.Button Del3;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Pusk;
        private System.Windows.Forms.TextBox Output;
    }
}

