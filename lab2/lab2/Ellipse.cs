using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Ellipse : Function
    {
        protected double a, b;
        public Ellipse(double x, double a, double b)
            : base(x)
        {
            this.a = a;
            this.b = b;
        }
        public override double y()
        {
            double f = System.Math.Sqrt((System.Math.Pow(x, 2) - (System.Math.Pow(a, 2)) * b * b) / System.Math.Pow(a, 2));
            return f;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Ellipse ell = obj as Ellipse;
            if (ell as Ellipse == null)
            {
                return false;
            }
            return a == ell.a && b == ell.b && x == ell.x;
        }
        public bool Equals(Ellipse obj)
        {
            if (obj == null)
            {
                return false;
            }
            return obj.a == this.a && obj.b == this.b && obj.x == this.x;
        }
    }
}
