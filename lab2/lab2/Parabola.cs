using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Parabola : Function
    {
        protected double p;
        public Parabola(double x, double p)
            : base(x)
        {
            this.p = p;
        }
        public override double y()
        {
            double f = System.Math.Pow(x, 2) / (2 * p);
            return f;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Parabola parab = obj as Parabola;
            if (parab as Parabola == null)
            {
                return false;
            }
            return p == parab.p && x == parab.x;
        }
        public bool Equals(Parabola obj)
        {
            if (obj == null)
            {
                return false;
            }
            return obj.p == this.p && obj.x == this.x;
        }
    }
}
