using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork4
{
    delegate int mydelegate(int os);

    class core
    {
        public static int num = 10;

        public static int add(int n1)
        {
            num += n1;
            return num;
        }
        public static int shouting(int n2)
        {
            num -= n2;
            return num;
        }

        public static int multiplication(int n3)
        {
            num *= n3;
            return num;
        }

        public static int divide(int n4)
        {
            num /= n4;
            return num;
        }

    }
}
