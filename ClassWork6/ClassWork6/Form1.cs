using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Rectangle r1 = new Rectangle();

            //string name = textBox1.Text;
            //label2.Text = "Hello " + name;


            Rectangle r = new Rectangle(30);
            r.gamotanacv(label2);

            MemkvidreClass m = new MemkvidreClass(20);
            label2.Text = m.partobi().ToString(); 

        }
    }
}
