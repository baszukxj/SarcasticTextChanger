using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarcasticTextChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Sarcastify(textBox1.Text);
        }

        private string Sarcastify(string str)
        {
            char[] arr = str.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(arr[i].ToString()))
                {
                    continue;
                }
                if(i%2 == 0)
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
                else
                {
                    arr[i] = char.ToLower(arr[i]);
                }
            }

            return new string(arr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBox2.Text);
        }
    }
}
