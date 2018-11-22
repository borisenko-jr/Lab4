using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInput
{
    //public partial class UserControl1: UserControl
    public partial class UserControl1 : System.Windows.Forms.Form
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            if (nameValid())
            {
                // Все правильно, удаляем сообщение с надписи
                errorProvider1.SetError(txtName, "");
            }
            else
            {
                //Поле не заполнено — выводим сообщение
                errorProvider1.SetError(txtName, "Name is required.");
                lbloutput.Text = "Введите имя!";
            }
        }

        private void numUDAge_Validated(object sender, EventArgs e)
        {
            if (ageLess())
            {
                // Введенное значение  меньше 25
                errorProvider1.SetError(numUDAge, "Age not old enough");
                lbloutput.Text = "Введите значение, большее или равное  25";
            }
            else if (ageMore())
            {
                /// Введенное значение  больше 25
                errorProvider1.SetError(numUDAge, "Age is too old");
                lbloutput.Text = "Введите значение, меньшее или равное  65";
            }
            else
            {
                // Все правильно, удаляем сообщение с надписи
                errorProvider1.SetError(numUDAge, "");
            }
        }

        private bool nameValid()
        {
            // Проверяем заполнение текствого поля
            return ( txtName.Text.Length > 0);
        }

        private bool ageLess() 
        {
            //Возраст меньше 25
            return (numUDAge.Value < 25);
        }

        private bool ageMore()
        {
            //Возраст больше 25
            return (numUDAge.Value > 65 );
        }

    }
}
