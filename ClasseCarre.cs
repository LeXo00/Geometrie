using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOMETRIE
{
    internal class ClasseCarre : Classe4Angles
    {
        public void Dessin()
        {

        }

        public int Init()
        {
            return Init();
        }

        public double Perimetre(double C)
        {
            return Multiplication(C, 4);
        }
        public double Surface(double C)
        {
            return Multiplication(C,C);
        } 
    }
}
