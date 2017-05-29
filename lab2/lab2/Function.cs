using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    interface IFunction
    {
        protected double x;
        public IFunction() { }
        public IFunction(double x)
        {
            this.x = x;
        }
        public double output { get; set; }
        public abstract double y();
    }
}
