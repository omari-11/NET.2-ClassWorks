using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string name = textBox1.Text;
            //label2.Text = "Hello " + name;
            //გავიხსენოთ კლასები 
            Class1 class1 = new Class1();
            class1.OutText(textBox1,label2);
            //მემკვიდრეობით გადაცემული 
            message message = new message();
            class1.OutText(label2, textBox1);
        }
    }
}
