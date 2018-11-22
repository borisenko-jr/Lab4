using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RegistrationForm
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.TextBox txtPIN;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lbloutput;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbloutput = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPIN = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbloutput);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtPIN);
			this.groupBox1.Location = new System.Drawing.Point(16, 80);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 176);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Введите регистрационые данные";
			// 
			// lbloutput
			// 
			this.lbloutput.Location = new System.Drawing.Point(16, 136);
			this.lbloutput.Name = "lbloutput";
			this.lbloutput.Size = new System.Drawing.Size(280, 23);
			this.lbloutput.TabIndex = 2;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(96, 32);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(184, 20);
			this.txtName.TabIndex = 1;
			this.txtName.Text = "";
			this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "PIN";
			// 
			// txtPIN
			// 
			this.txtPIN.Location = new System.Drawing.Point(96, 64);
			this.txtPIN.Name = "txtPIN";
			this.txtPIN.Size = new System.Drawing.Size(184, 20);
			this.txtPIN.TabIndex = 1;
			this.txtPIN.Text = "";
			this.txtPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPIN_KeyPress);
			this.txtPIN.Validating += new System.ComponentModel.CancelEventHandler(this.txtPIN_Validating);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(120, 264);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Регистрация";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Выберите тип регистрации";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(40, 40);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(232, 24);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Расширенные возможности";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(272, 16);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 4;
			this.radioButton1.Text = "Полная";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(272, 48);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 4;
			this.radioButton2.Text = "Ограниченная";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(384, 302);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.radioButton2);
			this.Name = "Form1";
			this.Text = "Регистрация программы";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

	
		

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			//Создаем новый экземпляр lbl класса Label:
			Label lbl = new Label();
			//Определяем расположение  надписи - свойство Location
			lbl.Location = new System.Drawing.Point(16, 96);
			//Устанавливаем размер надписи
			lbl.Size = new System.Drawing.Size(32, 23);
			//Задаем имя:
			lbl.Name = "labelll";
			//Определяем поярдок переключения принажатии клавиши Tab
			lbl.TabIndex = 2;
			//Устнаавливаем текст надписи на форме
			lbl.Text = "PIN2";
			//Добавляем элемент в коллекцию, вызывая метод Add
			groupBox1.Controls.Add(lbl);


			TextBox txt = new TextBox();
			txt.Location = new System.Drawing.Point(96, 96);
			txt.Size = new System.Drawing.Size(184, 20);
			txt.Name = "textboxx";
			txt.TabIndex = 1;
			txt.Text = "";
			groupBox1.Controls.Add(txt);
			txt.KeyPress+= new System.Windows.Forms.KeyPressEventHandler(this.txtPIN_KeyPress);
		
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			//Создаем новый экземпляр lbl класса Label:
			Label lbl = new Label();
			//Определяем расположение  надписи - свойство Location
			lbl.Location = new System.Drawing.Point(16, 96);
			//Устанавливаем размер надписи
			lbl.Size = new System.Drawing.Size(32, 23);
			//Задаем имя:
			lbl.Name = "labelll";
			//Определяем поярдок переключения принажатии клавиши Tab
			lbl.TabIndex = 2;
			//Устнаавливаем текст надписи на форме
			lbl.Text = "PIN2";
			//Добавляем элемент в коллекцию, вызывая метод Add
			groupBox1.Controls.Add(lbl);


			TextBox txt = new TextBox();
			txt.Location = new System.Drawing.Point(96, 96);
			txt.Size = new System.Drawing.Size(184, 20);
			txt.Name = "textboxx";
			txt.TabIndex = 1;
			txt.Text = "";
			groupBox1.Controls.Add(txt);
		
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			//Удаляем все элементы из коллекции
			groupBox1.Controls.Clear();
			
			//Добавляем первую надпись
			Label lbl1 = new Label();
			lbl1.Location = new System.Drawing.Point(16, 32);
			lbl1.Name = "labelfirst";
			lbl1.Size = new System.Drawing.Size(48, 23);
			lbl1.TabIndex = 4;
			lbl1.Text = "Name";
			groupBox1.Controls.Add(lbl1);
			
			//Добавляем вторую надпись
			Label lbl2 = new Label();
			lbl2.Location = new System.Drawing.Point(16, 64);
			lbl2.Name = "labelsecond";
			lbl2.Size = new System.Drawing.Size(40, 23);
			lbl2.TabIndex = 3;
			lbl2.Text = "PIN";
			groupBox1.Controls.Add(lbl2);

			//Добавляем первое текстовое поле
			TextBox txt1 = new TextBox();
			txt1.Location = new System.Drawing.Point(96, 32);
			txt1.Name = "textBox1";
			txt1.Size = new System.Drawing.Size(184, 20);
			txt1.TabIndex = 0;
			txt1.Text = "";
			groupBox1.Controls.Add(txt1);

			//Добавляем  второе  текстовое поле
			TextBox txt2 = new TextBox();
			txt2.Location = new System.Drawing.Point(96, 64);
			txt2.Name = "textBox2";
			txt2.Size = new System.Drawing.Size(184, 20);
			txt2.TabIndex = 1;
			txt2.Text = "";
			groupBox1.Controls.Add(txt2);
			
			

		}

		private void txtName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) )
			{
				e.Handled = true;
				lbloutput.Text = "Поле Name не может содержать цифры";
			}
			
		}

		private void txtPIN_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//			if (!char.IsDigit(e.KeyChar) )
			//			{
			//				e.Handled = true;
			//				lbloutput.Text ="Поля PIN и PIN2 не могут содержать буквы";
			//			}

		}

		private void txtPIN_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(txtPIN.Text =="")
			{
				e.Cancel=false;
			}
			else
			{
				try
				{
					double.Parse(txtPIN.Text);
					e.Cancel = false;
									
				}
				catch
				{
					e.Cancel = true;
					lbloutput.Text ="Поле PIN не может содержать буквы";
				}
			}
		}
	}
}


		
	

		

