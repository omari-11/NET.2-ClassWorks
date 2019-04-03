using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork4
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            mydelegate nc;
            mydelegate nc1 = new mydelegate(core.add);
            mydelegate nc2 = new mydelegate(core.shouting);
            mydelegate nc3 = new mydelegate(core.multiplication);
            mydelegate nc4 = new mydelegate(core.divide);


            nc = nc1;
            nc += nc3;
            nc += nc2;
            nc(2);

            label2.Text = core.num.ToString();

        }
    }
}
