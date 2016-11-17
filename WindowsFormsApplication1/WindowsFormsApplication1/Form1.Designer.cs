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
            this.q = new System.Windows.Forms.Button();
            this.w = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // q
            // 
            this.q.Location = new System.Drawing.Point(13, 13);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(75, 23);
            this.q.TabIndex = 0;
            this.q.Text = "q";
            this.q.UseVisualStyleBackColor = true;
            // 
            // w
            // 
            this.w.Location = new System.Drawing.Point(113, 12);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(75, 23);
            this.w.TabIndex = 1;
            this.w.Text = "w";
            this.w.UseVisualStyleBackColor = true;
            // 
            // e
            // 
            this.e.Location = new System.Drawing.Point(206, 12);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(75, 23);
            this.e.TabIndex = 2;
            this.e.Text = "e";
            this.e.UseVisualStyleBackColor = true;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(316, 12);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(75, 23);
            this.a.TabIndex = 3;
            this.a.Text = "a";
            this.a.UseVisualStyleBackColor = true;
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(408, 11);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(75, 23);
            this.s.TabIndex = 4;
            this.s.Text = "s";
            this.s.UseVisualStyleBackColor = true;
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(489, 13);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(22, 23);
            this.d.TabIndex = 5;
            this.d.Text = "d";
            this.d.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 262);
            this.Controls.Add(this.d);
            this.Controls.Add(this.s);
            this.Controls.Add(this.a);
            this.Controls.Add(this.e);
            this.Controls.Add(this.w);
            this.Controls.Add(this.q);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button q;
        private System.Windows.Forms.Button w;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Button d;
    }
}

