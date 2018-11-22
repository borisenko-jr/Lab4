using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragnDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
        }

        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void textBox2_DragDrop(object sender, DragEventArgs e)
        {
            textBox2.Text = e.Data.GetData(DataFormats.StringFormat).ToString();
        }

        private void richTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            int i;
            String s;

            // Определяем начальную позицию для текста
            i = richTextBox1.SelectionStart;
            s = richTextBox1.Text.Substring(i);
            richTextBox1.Text = richTextBox1.Text.Substring(0, i);

            // Перетаскиваем текст 
            richTextBox1.Text = richTextBox1.Text +
          e.Data.GetData(DataFormats.Text).ToString();
            richTextBox1.Text = richTextBox1.Text + s;
        }


    }
}
