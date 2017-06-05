using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Hiperbola : IFunction
    {
        protected double a, b, x;
        public Hiperbola(double x, double a, double b)
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
            double f = System.Math.Sqrt(((System.Math.Pow(a, 2) - System.Math.Pow(x, 2)) * b * b) / System.Math.Pow(a, 2));
            return f;
        }
        public static Hiperbola operator +(Hiperbola obj1, Hiperbola obj2)
        {
            Hiperbola obj3 = new Hiperbola(obj1.x + obj2.x, obj1.a + obj2.a, obj1.b + obj2.b);
            return obj3;
        }
        public static Hiperbola operator -(Hiperbola obj1, Hiperbola obj2)
        {
            Hiperbola obj3 = new Hiperbola(obj1.x - obj2.x, obj1.a - obj2.a, obj1.b - obj2.b);
            return obj3;
        }
        public static Hiperbola operator *(Hiperbola obj1, Hiperbola obj2)
        {
            Hiperbola obj3 = new Hiperbola(obj1.x * obj2.x, obj1.a * obj2.a, obj1.b * obj2.b);
            return obj3;
        }
        public static Hiperbola operator /(Hiperbola obj1, Hiperbola obj2)
        {
            Hiperbola obj3 = new Hiperbola(obj1.x / obj2.x, obj1.a / obj2.a, obj1.b / obj2.b);
            return obj3;
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
        public static bool operator ==(Hiperbola obj1, Hiperbola obj2)
        {
            if (obj1 == null || obj2 == null)
                return false;
            return (obj1.x == obj2.x && obj1.a == obj2.a && obj1.b == obj2.b);
        }
        public static bool operator !=(Hiperbola obj1, Hiperbola obj2)
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
