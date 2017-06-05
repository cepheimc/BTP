using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Parabola : IFunction
    {
        protected double p, x;
        public Parabola()  {}

        public Parabola(double x, double p)
        {
            if (p == 0)
            {
                throw new NumbException("знаменатель = 0");
            }
            else
            {
                this.x = x;
                this.p = p;
            }
        }
        public double y()
        {
            double f = System.Math.Pow(x, 2) / (2 * p);
            return f;
        }
        public static Parabola operator+(Parabola obj1, Parabola obj2)
        {
            Parabola obj3 = new Parabola(obj1.x + obj2.x, obj1.p + obj2.p);
            return obj3;
        }
        public static Parabola operator -(Parabola obj1, Parabola obj2)
        {
            Parabola obj3 = new Parabola(obj1.x - obj2.x, obj1.p - obj2.p);
            return obj3;
        }
        public static Parabola operator *(Parabola obj1, Parabola obj2)
        {
            Parabola obj3 = new Parabola(obj1.x * obj2.x, obj1.p * obj2.p);
            return obj3;
        }
        public static Parabola operator /(Parabola obj1, Parabola obj2)
        {
            Parabola obj3 = new Parabola(obj1.x / obj2.x, obj1.p / obj2.p);
            return obj3;
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
        public static bool operator ==(Parabola obj1, Parabola obj2)
        {
            if (obj1 == null || obj2 == null)
                return false;
            return (obj1.x == obj2.x && obj1.p == obj2.p);
        }
        public static bool operator !=(Parabola obj1, Parabola obj2)
        {
            if (obj1 == null || obj2 == null)
                return false;
            return !(obj1.x == obj2.x && obj1.p == obj2.p);
        }
        public override int GetHashCode()
        {
            return (int)x ^ (int)p;
        }
        public override string ToString()
        {
            return "x = " + x + " p = " + p + "\ny = " + y() + "\n";
        }
    }
}
