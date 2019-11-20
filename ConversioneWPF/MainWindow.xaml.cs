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

namespace ConversioneWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string r;
            try
            {

                if (Comboboxscelta.SelectedIndex == 0)
                {
                    //r = (Convert.ToString(Valore, 2));
                    int resto;
                    r = "";
                    int Valore = int.Parse(Numero.Text);
                    while (Valore > 0)
                    {
                        resto = Valore % 2;
                        Valore /= 2;
                        r = resto.ToString() + r;
                    }
                    Console.WriteLine("Binary:  {0}", r);
                    Output.Text = r;
                }
                else
                {

                    //r = (Convert.ToInt32(Numero.Text, 2).ToString());


                    string Valorestring = Numero.Text;
                    int risp = 0;
                    int exp = 0;


                    for (int i = Valorestring.Length - 1; i >= 0; i--)
                    {

                        if (Valorestring[i] == '1')
                        {
                            risp += (int)Math.Pow(2, exp);
                        }
                        else if (Valorestring[i] != '0')
                        {
                            throw new Exception("Non è un numero valido ");
                        }
                        exp++;
                    }


                    Output.Text = risp.ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString());
            }
        }
    }
}
