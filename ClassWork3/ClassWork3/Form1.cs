using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork3
{
    delegate string myDelegate(string text);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //სფეისები გადავაკეთოთ დეფისებად
            //corect corect = new corect();
            //label2.Text = corect.CorectString(textBox1.Text);

            //მოცემულ სთრინგში წავშალოთ შფეისები
            //ChangeString changeString = new ChangeString();
            //label2.Text = corect.CorectString(textBox1.Text);

            //მოცემული სტრინგის სიმბოლოების დათვლა და კონტროლი
            //count count = new count();
            //count.StringCounter(textBox1,label2);

            //დელეგატები
            
        }
    }
}
