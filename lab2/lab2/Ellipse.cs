using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Ellipse : IFunction
    {
        protected double a, b, x;
        public Ellipse(double x, double a, double b)
        {
            if (a == 0)
            {
                throw new NumbException("знаменатель = 0");
            }
            else
            {
                this.x = x;
                this.a = a;
                this.b = b;
            }
        }
        public double y()
        {
            double f = System.Math.Sqrt((System.Math.Pow(x, 2) - (System.Math.Pow(a, 2)) * b * b) / System.Math.Pow(a, 2));
            return f;
        }
        public static Ellipse operator +(Ellipse obj1, Ellipse obj2)
        {
            Ellipse obj3 = new Ellipse(obj1.x + obj2.x, obj1.a + obj2.a, obj1.b + obj2.b);
            return obj3;
        }
        public static Ellipse operator -(Ellipse obj1, Ellipse obj2)
        {
            Ellipse obj3 = new Ellipse(obj1.x - obj2.x, obj1.a - obj2.a, obj1.b - obj2.b);
            return obj3;
        }
        public static Ellipse operator *(Ellipse obj1, Ellipse obj2)
        {
            Ellipse obj3 = new Ellipse(obj1.x * obj2.x, obj1.a * obj2.a, obj1.b * obj2.b);
            return obj3;
        }
        public static Ellipse operator /(Ellipse obj1, Ellipse obj2)
        {
            Ellipse obj3 = new Ellipse(obj1.x / obj2.x, obj1.a / obj2.a, obj1.b / obj2.b);
            return obj3;
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

        public static bool operator ==(Ellipse obj1, Ellipse obj2)
        {
            if (obj1 == null || obj2 == null)
                return false;
            return (obj1.x == obj2.x && obj1.a == obj2.a && obj1.b == obj2.b);
        }
        public static bool operator !=(Ellipse obj1, Ellipse obj2)
        {
            if (obj1 == null || obj2 == null)
                return false;
            return !(obj1.x == obj2.x && obj1.a == obj2.a && obj1.b == obj2.b);
        }
        public override int GetHashCode()
        {
            return (int)x ^ (int)a ^ (int)b;
        }
        public override string ToString()
        {
            return "x = " + x + " a = " + a + " b = " + b + "\ny = " + y() + "\n";
        }
    }
}
