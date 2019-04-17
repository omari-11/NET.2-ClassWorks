using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassWork6
{
    class MemkvidreClass: Rectangle
    {
        private double simagle=30;

        public double partobi()
        {
            return this.fudze * this.simagle;
        }
        public MemkvidreClass(double f)
        {
            this.fudze = f;
        }

        //**** უკეთესი ვარიანტი :D 
        //public MemkvidreClass(double f) : base(f)
        //{}
    }
}
