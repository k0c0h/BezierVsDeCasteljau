using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezierVsDeCasteljau.Modelos
{
    public class CurvaBezier
    {
        public List<Punto2D> PuntosControl { get; set; }

        public int Grado
        {
            get
            {
                return PuntosControl.Count - 1;
            }
        }

        public CurvaBezier()
        {
            PuntosControl = new List<Punto2D>();
        }

        public CurvaBezier(List<Punto2D> puntos)
        {
            if (puntos == null)
            {
                throw new ArgumentNullException(nameof(puntos));
            }

            PuntosControl = new List<Punto2D>(puntos);
        }
    }
}
