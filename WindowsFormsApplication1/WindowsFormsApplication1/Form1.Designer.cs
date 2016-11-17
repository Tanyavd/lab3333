namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.y = new System.Windows.Forms.Button();
            this.u = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(13, 89);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(75, 23);
            this.y.TabIndex = 0;
            this.y.Text = "y";
            this.y.UseVisualStyleBackColor = true;
            // 
            // u
            // 
            this.u.Location = new System.Drawing.Point(128, 88);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(75, 23);
            this.u.TabIndex = 1;
            this.u.Text = "u";
            this.u.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 262);
            this.Controls.Add(this.u);
            this.Controls.Add(this.y);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button y;
        private System.Windows.Forms.Button u;
    }
}

