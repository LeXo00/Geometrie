using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GEOMETRIE
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClasseCarre uncarre = new ClasseCarre();
        ClasseTriangle untriangle = new ClasseTriangle();
        ClasseRectangle unrectangle = new ClasseRectangle();
        ClasseCercle uncercle = new ClasseCercle();
        ClasseEllipse uneellipse = new ClasseEllipse();
        public MainWindow()
        {
            InitializeComponent();
            txtInfoCarre.Text = Convert.ToString(uncarre.init());
            txtInfoTriangle.Text = Convert.ToString(untriangle.Init());
            txtInfoTriangle2.Text = Convert.ToString(untriangle.Init());
            txtInfoTriangle3.Text = Convert.ToString(untriangle.Init());
            txtInfoTriangle4.Text = Convert.ToString(untriangle.Init());
            txtInfoRectangle.Text = Convert.ToString(unrectangle.Init());
            txtInfoRectangle2.Text = Convert.ToString(unrectangle.Init());
            txtInfoCercle.Text = Convert.ToString(uncercle.Init());
            txtInfoEllipse.Text = Convert.ToString(uneellipse.Init());
            txtInfoEllipse2.Text = Convert.ToString(uneellipse.Init());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void btnRepCarre_Click(object sender, RoutedEventArgs e)
        {
            txtRepCarrePe.Text = Convert.ToString(uncarre.Perimetre(Convert.ToInt32(txtInfoCarre.Text)));
            txtRepCarreSu.Text = Convert.ToString(uncarre.Surface(Convert.ToInt32(txtInfoCarre.Text)));
        }

        private void btnValiderCarre_Click(object sender, RoutedEventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtPropCarrePe.Text) || string.IsNullOrWhiteSpace(txtPropCarreSu.Text))
            {
                
                return;
            }

            
            Console.WriteLine("Les TextBox sont remplies !");
            

            if (Convert.ToInt32(txtPropCarrePe.Text)== uncarre.Perimetre(Convert.ToInt32(txtInfoCarre.Text)))
            {
                txtPropCarrePe.Background = new SolidColorBrush(Colors.Green); 
            }
            else
            {
                txtPropCarrePe.Background = new SolidColorBrush(Colors.Red);
            }

            if (Convert.ToInt32(txtPropCarreSu.Text) == uncarre.Surface(Convert.ToInt32(txtInfoCarre.Text)))
            {
                txtPropCarreSu.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                txtPropCarreSu.Background = new SolidColorBrush(Colors.Red);
            }

        }


        private void btnValiderTriangle_Click(object sender, RoutedEventArgs e)
        {
            // Vérifie si les TextBox sont vides
            if (string.IsNullOrWhiteSpace(txtPropTrianglePe.Text) || string.IsNullOrWhiteSpace(txtPropTriangleSu.Text))
            {
                // Ne rien faire si l'une des TextBox est vide
                return;
            }

            if (Convert.ToDouble(txtPropTrianglePe.Text) == untriangle.Perimetre(Convert.ToDouble(txtInfoTriangle.Text), Convert.ToDouble(txtInfoTriangle2.Text), Convert.ToDouble(txtInfoTriangle3.Text)))
            {
                txtPropTrianglePe.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                txtPropTrianglePe.Background = new SolidColorBrush(Colors.Red);
            }

            if (Convert.ToDouble(txtPropTriangleSu.Text) == untriangle.Surface(Convert.ToDouble(txtInfoTriangle2.Text), Convert.ToDouble(txtInfoTriangle4.Text)))
            {
                txtPropTriangleSu.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                txtPropTriangleSu.Background = new SolidColorBrush(Colors.Red);
            }

        }

        private void btnRepTriangle_Click(object sender, RoutedEventArgs e)
        {
            txtRepTrianglePe.Text = Convert.ToString(untriangle.Perimetre(Convert.ToDouble(txtInfoTriangle.Text), Convert.ToDouble(txtInfoTriangle2.Text), Convert.ToInt32(txtInfoTriangle3.Text)));
            txtRepTriangleSu.Text = Convert.ToString(untriangle.Surface(Convert.ToDouble(txtInfoTriangle2.Text), Convert.ToDouble(txtInfoTriangle4.Text)));
        }

        private void btnValiderRectangle_Click(object sender, RoutedEventArgs e)
        {
            // Vérifie si les TextBox sont vides
            if (string.IsNullOrWhiteSpace(txtPropRectanglePe.Text) || string.IsNullOrWhiteSpace(txtPropRectangleSu.Text))
            {
                // Ne rien faire si l'une des TextBox est vide
                return;
            }

            if (Convert.ToInt32(txtPropRectanglePe.Text) == unrectangle.Perimetre(Convert.ToInt32(txtInfoRectangle.Text), Convert.ToInt32(txtInfoRectangle2.Text)))
            {
                txtPropRectanglePe.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                txtPropRectanglePe.Background = new SolidColorBrush(Colors.Red);
            }

            if (Convert.ToInt32(txtPropRectangleSu.Text) == unrectangle.Surface(Convert.ToInt32(txtInfoRectangle.Text), Convert.ToInt32(txtInfoRectangle2.Text)))
            {
                txtPropRectangleSu.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                txtPropRectangleSu.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void btnRepRectangle_Click(object sender, RoutedEventArgs e)
        {
            txtRepRectanglePe.Text = Convert.ToString(unrectangle.Perimetre(Convert.ToInt32(txtInfoRectangle.Text), Convert.ToInt32(txtInfoRectangle2.Text)));
            txtRepRectangleSu.Text = Convert.ToString(unrectangle.Surface(Convert.ToInt32(txtInfoRectangle.Text), Convert.ToInt32(txtInfoRectangle2.Text)));
        }



        private void reset_Click(object sender, RoutedEventArgs e)
        {
            txtInfoCarre.Text = Convert.ToString(uncarre.init());
            txtInfoTriangle.Text = Convert.ToString(untriangle.Init());
            txtInfoTriangle2.Text = Convert.ToString(untriangle.Init());
            txtInfoTriangle3.Text = Convert.ToString(untriangle.Init());
            txtInfoTriangle4.Text = Convert.ToString(untriangle.Init());
            txtInfoRectangle.Text = Convert.ToString(unrectangle.Init());
            txtInfoRectangle2.Text = Convert.ToString(unrectangle.Init());
            txtInfoCercle.Text = Convert.ToString(uncercle.Init());
            txtInfoEllipse.Text = Convert.ToString(uneellipse.Init());
            txtInfoEllipse2.Text = Convert.ToString(uneellipse.Init());
            txtPropCarrePe.Text = string.Empty; txtPropCarreSu.Text = string.Empty; txtRepCarrePe.Text = string.Empty; txtRepCarreSu.Text = string.Empty;
            txtPropTrianglePe.Text = string.Empty; txtPropTriangleSu.Text = string.Empty; txtRepTrianglePe.Text = string.Empty; txtRepTriangleSu.Text = string.Empty;
            txtPropRectanglePe.Text = string.Empty; txtPropRectangleSu.Text = string.Empty; txtRepRectanglePe.Text = string.Empty; txtRepRectangleSu.Text = string.Empty;
            txtPropCerclePe.Text = string.Empty; txtPropCercleSu.Text = string.Empty; txtRepCerclePe.Text = string.Empty; txtRepCercleSu.Text = string.Empty;
            txtPropEllipsePe.Text = string.Empty; txtPropEllipseSu.Text = string.Empty; txtRepEllipsePe.Text = string.Empty; txtRepEllipseSu.Text = string.Empty;
            txtPropCarrePe.Background = new SolidColorBrush(Colors.White); txtPropCarreSu.Background = new SolidColorBrush(Colors.White); txtPropTrianglePe.Background = new SolidColorBrush(Colors.White); txtPropTriangleSu.Background = new SolidColorBrush(Colors.White);
            txtPropRectanglePe.Background = new SolidColorBrush(Colors.White); txtPropRectangleSu.Background = new SolidColorBrush(Colors.White); txtPropCerclePe.Background = new SolidColorBrush(Colors.White); txtPropCercleSu.Background = new SolidColorBrush(Colors.White);
            txtPropEllipsePe.Background = new SolidColorBrush(Colors.White); txtPropEllipseSu.Background = new SolidColorBrush(Colors.White);
        }


        private const double tolerance = 0.0001; // Tolérance pour la comparaison

        // Méthode pour comparer deux valeurs doubles avec une tolérance
        private bool AreEqual(double a, double b)
        {
            return Math.Abs(a - b) < tolerance;
        }

        private void btnValiderCercle_Click(object sender, RoutedEventArgs e)
        {
            // Vérifie si les TextBox sont vides
            if (string.IsNullOrWhiteSpace(txtPropCerclePe.Text) || string.IsNullOrWhiteSpace(txtPropCercleSu.Text))
            {
                // Ne rien faire si l'une des TextBox est vide
                return;
            }

            double rayon = Convert.ToDouble(txtInfoCercle.Text);

            // Calcul du périmètre et de la surface
            double perimetreCalcule = uncercle.Perimetre(rayon);
            double surfaceCalcule = uncercle.Surface(rayon);

            // Comparaison pour le périmètre
            if (AreEqual(Convert.ToDouble(txtPropCerclePe.Text.Trim()), perimetreCalcule))
            {
                txtPropCerclePe.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                txtPropCerclePe.Background = new SolidColorBrush(Colors.Red);
            }

            // Comparaison pour la surface
            if (AreEqual(Convert.ToDouble(txtPropCercleSu.Text.Trim()), surfaceCalcule))
            {
                txtPropCercleSu.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                txtPropCercleSu.Background = new SolidColorBrush(Colors.Red);
            }

        }

        private void btnRepCercle_Click(object sender, RoutedEventArgs e)
        {
            txtRepCerclePe.Text = Convert.ToString(Math.Round(uncercle.Perimetre(Convert.ToDouble(txtInfoCercle.Text)), 2));
            txtRepCercleSu.Text = Convert.ToString(Math.Round(uncercle.Surface(Convert.ToDouble(txtInfoCercle.Text)), 2));
        }

        private void btnRepEllipse_Click(object sender, RoutedEventArgs e)
        {
            txtRepEllipsePe.Text = Convert.ToString(Math.Round(uneellipse.Perimetre(Convert.ToDouble(txtInfoEllipse.Text), Convert.ToDouble(txtInfoEllipse2.Text)), 2));
            txtRepEllipseSu.Text = Convert.ToString(Math.Round(uneellipse.Surface(Convert.ToDouble(txtInfoEllipse.Text), Convert.ToDouble(txtInfoEllipse2.Text)), 2));
        }


        private void btnValiderEllipse_Click(object sender, RoutedEventArgs e)
        {
            // Vérifie si les TextBox sont vides
            if (string.IsNullOrWhiteSpace(txtPropEllipsePe.Text) || string.IsNullOrWhiteSpace(txtPropEllipseSu.Text))
            {
                // Ne rien faire si l'une des TextBox est vide
                return;
            }

            double perimetreCalcule = uneellipse.Perimetre(Convert.ToDouble(txtInfoEllipse.Text), Convert.ToDouble(txtInfoEllipse2.Text));
            double surfaceCalcule = uneellipse.Surface(Convert.ToDouble(txtInfoEllipse.Text), Convert.ToDouble(txtInfoEllipse2.Text));

            // Comparaison pour le périmètre
            if (AreEqual(Convert.ToDouble(txtPropEllipsePe.Text.Trim()), perimetreCalcule))
            {
                txtPropEllipsePe.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                txtPropEllipsePe.Background = new SolidColorBrush(Colors.Red);
            }

            // Comparaison pour la surface
            if (AreEqual(Convert.ToDouble(txtPropEllipseSu.Text.Trim()), surfaceCalcule))
            {
                txtPropEllipseSu.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                txtPropEllipseSu.Background = new SolidColorBrush(Colors.Red);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtBlocRappel.Visibility = Visibility.Visible;
        }
    }
}
