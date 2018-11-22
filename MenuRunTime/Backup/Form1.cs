using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MenuRunTime
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtMenuText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbShortCuts;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.MenuItem mnuChangeColor;
		private System.Windows.Forms.MenuItem mnuExit;
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtMenuText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbShortCuts = new System.Windows.Forms.ComboBox();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.mnuChangeColor = new System.Windows.Forms.MenuItem();
			this.mnuExit = new System.Windows.Forms.MenuItem();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbShortCuts);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtMenuText);
			this.groupBox1.Location = new System.Drawing.Point(14, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 136);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(96, 104);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtMenuText
			// 
			this.txtMenuText.Location = new System.Drawing.Point(128, 32);
			this.txtMenuText.Name = "txtMenuText";
			this.txtMenuText.Size = new System.Drawing.Size(120, 20);
			this.txtMenuText.TabIndex = 1;
			this.txtMenuText.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.TabIndex = 2;
			this.label1.Text = "Текст меню";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Сочетание клавиш";
			// 
			// cmbShortCuts
			// 
			this.cmbShortCuts.Location = new System.Drawing.Point(128, 72);
			this.cmbShortCuts.Name = "cmbShortCuts";
			this.cmbShortCuts.Size = new System.Drawing.Size(121, 21);
			this.cmbShortCuts.TabIndex = 3;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.mnuChangeColor,
																						 this.mnuExit});
			// 
			// mnuChangeColor
			// 
			this.mnuChangeColor.Index = 0;
			this.mnuChangeColor.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
			this.mnuChangeColor.Text = "Изменить цвет";
			this.mnuChangeColor.Click += new System.EventHandler(this.mnuChangeColor_Click);
			// 
			// mnuExit
			// 
			this.mnuExit.Index = 1;
			this.mnuExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
			this.mnuExit.Text = "Выход";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.ContextMenu = this.contextMenu1;
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
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

		private void mnuExit_Click(object sender, System.EventArgs e)
		{
		 this.Close();
		}

		private void mnuChangeColor_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog()==DialogResult.OK)
			{
				this.BackColor =colorDialog1.Color;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			object[] sc = new object[Enum.GetValues(typeof (Shortcut)).Length];
			Enum.GetValues(typeof(Shortcut)).CopyTo(sc,0);
			cmbShortCuts.Items.AddRange(sc);
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			//Если значение текстового поля пустое, выводим сообщение
			if(txtMenuText.Text=="")
			{
				//Текст сообщения
				MessageBox.Show("Введите текст для пункта меню");
				return;
			}
			//Если не выбрано значение сочетания клавиш, выводим сообщение
			if(cmbShortCuts.SelectedItem==null)
			{
				//Текст сообщения
				MessageBox.Show("Выберите сочетание клавиш");
				return;

			}
			//Создаем новый экземпляр mnu класса пунктов  меню MenuItem
			MenuItem mnu = new MenuItem();
			//Устанавливаем в качестве текста пункта значение, введенное в txtMenuText
			mnu.Text = txtMenuText.Text;
			//Устанавливаем в качестве сочетания клавиш данного пункта 
			//выбранное значение из cmbShortCuts
			mnu.Shortcut=(Shortcut)cmbShortCuts.SelectedItem;
			//Добавляем пункт в контекстное меню contextMenu1
			contextMenu1.MenuItems.Add(mnu);
			//Определяем обработчик для события Click экземпляра  mnu
			mnu.Click += new System.EventHandler(this.NewmnuChangeColor_Click);
		}
		//Обработчик события Click экземпляра mnu
		private void NewmnuChangeColor_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog()==DialogResult.OK)
			{
				this.BackColor =colorDialog1.Color;
			}
		}
		}
	}

