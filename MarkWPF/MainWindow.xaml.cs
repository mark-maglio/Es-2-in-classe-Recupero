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
using LibreriaES2;

namespace MarkWPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Calcola_Click(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(TxtNumero.Text);
            int n1;
            if (Utilità.VerificaInteri(n))
            {
                lbl_Tutto.Content = "il numero è intero";
                n1 = (int)n;
            }
            else
            {
                lbl_Tutto.Content = "il numero non è intero";
                n1 =Utilità.Arrotonda(n);
            }
            if(Utilità.Pari_Dispari(n1))
            {
                lbl_Tutto.Content += "\nIl numero è Pari";
            }
            else
            {
                lbl_Tutto.Content += "\nIl numero è Dispari";
            }
        } 
    }
}
