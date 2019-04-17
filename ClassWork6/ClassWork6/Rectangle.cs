using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork6
{
    class Rectangle
    {

        protected double fudze;

        public Rectangle(double f)
        {
            this.fudze = f;
        }

        public void gamotanacv(Label l)
        {
            l.Text = this.fudze.ToString();
        }

        // ცარიელი მეთოდი მემკვიდრე კლასისთვის
        public Rectangle()
        {
        }

        //public void OutText(TextBox textbox, Label label)
        //{
        //    label.Text = "" + textbox.Text;
        //}
    }
}
