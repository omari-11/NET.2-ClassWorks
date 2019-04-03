using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork3
{
    class corect
    {
        public string CorectString(string text)
        {
            string corectText = text.Replace(' ','-');
            return corectText;
        }
    }
}
