using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paragrafi_kelimelere_ayirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            string cumle = richTextBox1.Text;

            string[] kelimeler = cumle.Split(' ');

            foreach (var item in kelimeler)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
