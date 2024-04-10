using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_10._04._2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ersatzwiederstand_Click(object sender, RoutedEventArgs e)
        {
            double reihe, parallel;
            double r1 = Convert.ToDouble(R1.Text);
            double r2 = Convert.ToDouble(R2.Text);

            reihe = r1 + r2;
            parallel = (r1 * r2) / (r1 + r2);

            Reihe.Text = reihe.ToString();
            Parallel.Text = parallel.ToString();

            if(parallel == 0)
            {
                MessageBox.Show("Parallele Ersatzwiederstandswert soll nicht null sein!");
            }

            else if(reihe < 0)
            {
               MessageBox.Show("Reihe Eresatzwiederstandswert soll nicht kleiner als null sein!");
            }  
        }

        private void Löschen_Click(object sender, RoutedEventArgs e)
        {
            R1.Text = "";
            R2.Text = "";
            Reihe.Text = "";
            Parallel.Text = "";
        }   
    }
}
