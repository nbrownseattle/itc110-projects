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

namespace Assignment8_nbrown
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

        private void buttonSbmit_Click(object sender, RoutedEventArgs e)
        {
            tipCalculator m = new tipCalculator();

            int tipAmount;
            if(radioButtonten.IsChecked==true)
            {
                tipAmount = 10;
            }
            else if (radioButtonfifteen.IsChecked==true)
            {
                tipAmount = 15;
            }
            else if (radioButtontwenty.IsChecked==true)
            {
                tipAmount = 20;
            }
            else
            {
                tipAmount = int.Parse(textBoxother.Text);
            }
            m.Tip = tipAmount;
            m.Meal = double.Parse(textBoxmealamount.Text);
            textBoxtax.Text = m.GetTax().ToString();
            textBoxtip.Text = m.Tip.ToString();
            textBoxtotal.Text = m.CalculateTotal().ToString();
        }

       
    }
}
