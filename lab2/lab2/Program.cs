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
    }

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
    }

    class Parabola : Function
    {
        protected double p;
        public Parabola(double x, double p) : base(x)
        {
            this.p = p;
        }
        public override double y()
        {
            double f = System.Math.Pow(x,2)/(2*p);
            return f;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
