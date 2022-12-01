using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Console
{
        abstract class Function : IComparable<Function>
        {
            public abstract double A { get; set; }
            public abstract double B { get; set; }
            public abstract double Count(double x);

            public abstract Int32 CompareTo(Function obj);
        }

        class Line : Function
        {
            public sealed override Double A { get; set; }
            public sealed override Double B { get; set; }

            public Line(double a, double b)
            {
                A = a;
                B = b;
            }

            public override double Count(double x)
            {
                return A * x + B;
            }

            public override Int32 CompareTo(Function obj)
            {
                return A.CompareTo(obj.A);
            }
        }


        class Kub : Function
        {
            public sealed override Double A { get; set; }
            public sealed override Double B { get; set; }
            public readonly double C;

            public Kub(double a, double b, double c)
            {
                A = a;
                B = b;
                C = c;
            }

            public override double Count(double x)
            {
                return A * x * x + B * x + C;
            }

            public override Int32 CompareTo(Function obj)
            {
                return A.CompareTo(obj.A);
            }
        }
        class Hyperbola : Function
        {
            public sealed override Double A { get; set; }
            public sealed override Double B { get; set; }

            public Hyperbola(double a, double b)
            {
                A = a;
                B = b;
            }

            public override double Count(double x)
            {
                return (A / x) + B;
            }
            public override Int32 CompareTo(Function obj)
            {
                return A.CompareTo(obj.A);
            }
        }
    }

