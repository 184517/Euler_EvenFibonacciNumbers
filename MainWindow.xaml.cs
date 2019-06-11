/* Jordan Ross
 * June 11, 2019
 * Sum of all even fibonacci numbers from 1 to 4 million
 */
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

namespace Euler_EvenFibonacciNumbers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ulong fourmill = 4000000;
        ulong start0 = 0;
        ulong start1 = 1;
        ulong nextNum;
        ulong sum;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            for(ulong i = 2; nextNum <= fourmill; i++)
            {
                nextNum = start0 + start1;
                start0 = start1;
                
                if(nextNum % 2 == 0)
                {
                    sum += nextNum;
                    
                }
                start1 = nextNum;
            }
            MessageBox.Show(sum.ToString());
        }
    }
}
