using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Hiperbola : Function
    {
        protected double a, b;
        public Hiperbola(double x, double a, double b)
            : base(x)
        {
            this.a = a;
            this.b = b;
        }
        public override double y()
        {
            double f = System.Math.Sqrt(((System.Math.Pow(a, 2) - System.Math.Pow(x, 2)) * b * b) / System.Math.Pow(a, 2));
            return f;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Hiperbola hip = obj as Hiperbola;
            if (hip as Hiperbola == null)
            {
                return false;
            }
            return a == hip.a && b == hip.b && x == hip.x;
        }
        public bool Equals(Hiperbola obj)
        {
            if (obj == null)
            {
                return false;
            }
            return obj.a == this.a && obj.b == this.b && obj.x == this.x;
        }
    }
}
