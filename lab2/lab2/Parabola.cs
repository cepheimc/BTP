﻿using System;
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
        public bool operator ==(Parabola obj1, Parabola obj2)
        {
            if (obj1 == null || obj2 == null)
                return false;
            return (obj1.x == obj2.x && obj1.p == obj2.p);
        }
        public bool operator !=(Parabola obj1, Parabola obj2)
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
            return "x = " + x + " p = " + p + "\ny = " + y();
        }
    }
}
