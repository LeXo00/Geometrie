using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOMETRIE
{
    internal class ClasseRectangle : Classe4Angles
    {
        private static readonly Random _random = new Random();
        private static HashSet<double> _generatedNumbers = new HashSet<double>();

		public void Dessi()
		{

		}

		public double Init()
		{
            return init();
        }

		public double Perimetre(double L, double l)
		{
            return Addition(L,l,0)*2;
        }

		public double Surface(double L, double l)
		{
            return Multiplication(L, l);
        }

	}
}
