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
            this.r = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Button();
            this.f = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(13, 48);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(75, 23);
            this.r.TabIndex = 0;
            this.r.Text = "r";
            this.r.UseVisualStyleBackColor = true;
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(122, 47);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(75, 23);
            this.t.TabIndex = 1;
            this.t.Text = "t";
            this.t.UseVisualStyleBackColor = true;
            // 
            // f
            // 
            this.f.Location = new System.Drawing.Point(230, 47);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(75, 23);
            this.f.TabIndex = 2;
            this.f.Text = "f";
            this.f.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 262);
            this.Controls.Add(this.f);
            this.Controls.Add(this.t);
            this.Controls.Add(this.r);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button r;
        private System.Windows.Forms.Button t;
        private System.Windows.Forms.Button f;
    }
}

