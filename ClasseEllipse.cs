using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOMETRIE
{
    internal class ClasseEllipse : ClasseRond
    {
		private int PR;

		public int pr
		{
			get { return PR; }
			set { PR = value; }
		}

		public void Dessin()
		{

		}

        public double Init()
        {
            return init();
        }

        public double Perimetre(double a, double b)
        {
			double addition1 = Addition(3 * a, b, 0);
            double addition2 = Addition(a, 3 * b, 0);
            double produit = Multiplication(addition1, addition2);
            double perimetre = 3.14 * (3 * (a + b) - Math.Sqrt(produit));
            return perimetre;

        }

        public double Surface(double a, double b)
		{
			return 3.14* Multiplication(a,b);

        }
	}
}
