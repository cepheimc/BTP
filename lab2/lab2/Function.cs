using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Function
    {
        protected double x;
        public Function(double x)
        {
            this.x = x;
        }
        public double output { get; set; }
        public abstract double y();
    }
}
