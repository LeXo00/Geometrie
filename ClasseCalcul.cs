using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOMETRIE
{
    internal class ClasseCalcul
    {
        private static readonly Random _random = new Random();
        private static HashSet<double> _generatedNumbers = new HashSet<double>();
        private int valeur;

		public int Valeur
		{
			get { return valeur; }
			set { valeur = value; }
		}

		public double Addition (double P1,double P2, double P3)
		{
			return P1 + P2 + P3;
		}

        public double Multiplication(double P1, double P2)
        {
            return P1 * P2;
        }

        public double init()
        {
            if (_generatedNumbers.Count >= 04)
            {
                _generatedNumbers.Clear();
            }

            double number;
            do
            {
                number = _random.Next(1, 101);
            } while (!_generatedNumbers.Add(number));

            return number;

        }

        /*public double Init(double P1, double P2)
        {
            
        }*/

    }
}
