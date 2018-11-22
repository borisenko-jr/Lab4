using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPIN_KeyPress);

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
            if (char.IsDigit(e.KeyChar))
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
            if (txtPIN.Text == "")
            {
                e.Cancel = false;
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
                    lbloutput.Text = "Поле PIN не может содержать буквы";
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
