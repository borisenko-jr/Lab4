using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;


namespace XML_serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Создаем экземпляр frmSize класса FormSize:
            FormSize frmSize = new FormSize();
            // Присваиваем текущие значения высоты и ширины формы 
            //переменным height и width
            frmSize.height = this.Height;
            frmSize.width = this.Width;
            //Cоздаем экземпляр  xmlser класса XmlSerializer
            XmlSerializer xmlser = new XmlSerializer(typeof(FormSize));
            //Создаем переменную filename, которой присваиваем 
            //название файла applicationSettings.xml в текущей директории
            string filename = Environment.CurrentDirectory + "\\applicationSettings.xml";
            //Создаем поток filestream для создания XML-файла
            FileStream filestream = new FileStream(filename, FileMode.Create);
            //Создаем сериализацию для экземпляра frmSize
            xmlser.Serialize(filestream, frmSize);
            //Закрываем поток
            filestream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Создаем экземпляр frmSizeSetup класса FormSize:
            FormSize frmSizeSetup = new FormSize();
            //Cоздаем экземпляр  xmlser класса XmlSerializer
            XmlSerializer xmlser = new XmlSerializer(typeof(FormSize));
            //Создаем переменную filename, которой присваиваем 
            //название файла applicationSettings.xml в текущей директории
            string filename = Environment.CurrentDirectory + "\\applicationSettings.xml";
            //Создаем поток filestream для чтения XML-файла
            FileStream filestream = new FileStream(filename, FileMode.Open);
            //Экземпляру frmSizeSetup передаем данные,
            //полученные в процессе десериализации
            frmSizeSetup = (FormSize)xmlser.Deserialize(filestream);
            //Устанавливаем  текущие высоту и ширину формы
            this.Height = frmSizeSetup.height;
            this.Width = frmSizeSetup.width;
            //Закрываем поток
            filestream.Close();
        }
    }

    public class FormSize
    {
        public int height;
        public int width;
    }

}
