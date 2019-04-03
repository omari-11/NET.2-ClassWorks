using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork3
{
    class count
    {
        public void StringCounter(TextBox textBox1, Label label1)
        {
            textBox1.MaxLength = 40;
            label1.Text = textBox1.Text.Length.ToString();
            if (textBox1.Text.Length==40)
            {
                MessageBox.Show("სტრიქონის მახსიმალური სიმბოლოების რაოდენობა = 40 !!!");
            }
        }
    }
}
