using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezierVsDeCasteljau.Modelos
{
    public class Punto2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punto2D()
        {
        }

        public Punto2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
