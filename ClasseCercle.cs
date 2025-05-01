using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOMETRIE
{
    internal class ClasseCercle : ClasseRond
    {
        public void Dessin()
        {

        }
        public double Init()
        {
            return init();
        }

        public double Perimetre(double r)
        {
            return Multiplication(2, 3.14)*r;
        }

        public double Surface(double r)
        {
            return Multiplication(r,r) * 3.14;
        }
    }
}
