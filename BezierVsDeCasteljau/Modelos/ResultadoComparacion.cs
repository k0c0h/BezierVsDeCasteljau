using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezierVsDeCasteljau.Modelos
{
    public class ResultadoComparacion
    {
        public List<double> DiferenciasX { get; set; }
        public List<double> DiferenciasY { get; set; }
        public List<double> ErroresPuntos { get; set; }

        public double ErrorPromedio { get; set; }
        public double ErrorMaximo { get; set; }

        public ResultadoComparacion()
        {
            DiferenciasX = new List<double>();
            DiferenciasY = new List<double>();
            ErroresPuntos = new List<double>();
        }
    }
}

