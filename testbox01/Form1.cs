using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testbox01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void convert_button_Click(object sender, EventArgs e)
        {
            upper_text.Text = input_text.Text;
            reverse_text.Text = input_text.Text;

            char[] chararray = this.reverse_text.Text.ToCharArray();
            Array.Reverse(chararray);
            string reverseTxt = "";
            for (int i = 0; i <= chararray.Length - 1; i++)
            {
                reverseTxt += chararray.GetValue(i);
            }
            this.reverse_text.Text = reverseTxt;

        }

        private void input_text_TextChanged(object sender, EventArgs e)
        {
        }

        private void reverse_text_TextChanged(object sender, EventArgs e)
        {
        }

        private void upper_text_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
