using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOMETRIE
{
    internal class ClasseTriangle : ClasseAvecAngle

    {

        public double Init()
        {
            return init();
        }

        public double Perimetre(double C, double B, double C2)
		{
            return Addition(C,B,C2);
        }

        public double Surface(double B, double H)
        {
            return Multiplication(B,H)/2;
        }
    }
}
