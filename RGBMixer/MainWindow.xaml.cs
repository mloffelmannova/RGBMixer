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

namespace RGBMixer
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

        private void btnBarva_Click(object sender, RoutedEventArgs e)
        {
            byte hodnotaR = Convert.ToByte(posuvnikR.Value);
            byte hodnotaG = Convert.ToByte(posuvnikG.Value);
            byte hodnotaB = Convert.ToByte(posuvnikB.Value);

            MessageBox.Show($"{hodnotaR}, {hodnotaG}, {hodnotaB} ");
            LabelMeneny.Background = new SolidColorBrush(Color.FromRgb(hodnotaR, hodnotaG, hodnotaB));
        }
    }
}
