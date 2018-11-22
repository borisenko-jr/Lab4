using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegistrySettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class FormSize
        {
            public int height;
            public int width;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormSize frmSize = new FormSize();
            frmSize.height = this.Height;
            frmSize.width = this.Width;
            //Открываем раздел RegApplication
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\RegApplication", true);
            //Если раздел не обнаружен, создаем его
            if (regkey == null)
            {
                RegistryKey newregkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft", true);
                regkey = newregkey.CreateSubKey("RegApplication");
            }
            //Записываем значения ширины и высоты формы в ключи Height и Width
            regkey.SetValue("Height", frmSize.height);
            regkey.SetValue("Width", frmSize.width);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormSize frmSizeSetup = new FormSize();
            //Открываем раздел реестра
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\RegApplication");
            //Получаем значения ключей Height и Width
            frmSizeSetup.height = Convert.ToInt32(regkey.GetValue("Height"));
            frmSizeSetup.width = Convert.ToInt32(regkey.GetValue("Width"));
            //Устанавливаем текущие значения ширины и высоты формы
            this.Height = frmSizeSetup.height;
            this.Width = frmSizeSetup.width;
        }
    }
}
