using System;
using System.Windows.Forms;

namespace UserInput
{
    partial class UserControl1
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

        //[STAThread]
        //static void Main()
        //{
        //    Application.Run(new UserControl1());
        //}


        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numUDAge = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numUDAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Возраст (25-65)";
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Location = new System.Drawing.Point(62, 81);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(0, 13);
            this.lbloutput.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // numUDAge
            // 
            this.numUDAge.Location = new System.Drawing.Point(114, 47);
            this.numUDAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDAge.Name = "numUDAge";
            this.numUDAge.Size = new System.Drawing.Size(120, 20);
            this.numUDAge.TabIndex = 4;
            this.numUDAge.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numUDAge.Validated += new System.EventHandler(this.numUDAge_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numUDAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numUDAge;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
