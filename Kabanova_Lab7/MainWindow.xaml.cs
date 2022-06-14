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

namespace Kabanova_Lab7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   public partial class MainWindow : Window
    {
        private List<double> list;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n = random.Next(100);
            list = new List<double>();
            string str = "";
            for (int i = 0; i < n; i++)
            {

                list.Add(random.Next(-100,101));
                str += $"{list[i]:F2} ";
            }
            Result.Text = str;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var res = list.FirstOrDefault();
            if (res > 0) 
                Res2.Text = $"{res:F2}".ToString();
            else
                Result.Text = "";
            
        }
    }
}
