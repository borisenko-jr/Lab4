namespace TestUserElement
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
            this.userControl11 = new UserInput.UserControl1();
            this.userControl12 = new UserInput.UserControl1();
            this.userControl13 = new UserInput.UserControl1();
            this.userControl14 = new UserInput.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(267, 115);
            this.userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(12, 133);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(267, 115);
            this.userControl12.TabIndex = 1;
            // 
            // userControl13
            // 
            this.userControl13.Location = new System.Drawing.Point(12, 254);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(267, 115);
            this.userControl13.TabIndex = 2;
            // 
            // userControl14
            // 
            this.userControl14.Location = new System.Drawing.Point(285, 133);
            this.userControl14.Name = "userControl14";
            this.userControl14.Size = new System.Drawing.Size(267, 115);
            this.userControl14.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl14);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserInput.UserControl1 userControl11;
        private UserInput.UserControl1 userControl12;
        private UserInput.UserControl1 userControl13;
        private UserInput.UserControl1 userControl14;
    }
}

