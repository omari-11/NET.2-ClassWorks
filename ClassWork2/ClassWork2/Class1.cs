using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClassWork2
{
    class Class1
    {
        //პოლიმორფიზმი "არგუმენტები სხვადასხვა პოზიციაზეა!"
        public void OutText(TextBox textbox, Label label)
        {
            label.Text = "Hii " + textbox.Text;
        }

        public void OutText(Label label, TextBox textbox)
        {
            label.Text = "Hii " + textbox.Text;
        }
    }
}
