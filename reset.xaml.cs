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
using System.Windows.Shapes;

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для reset.xaml
    /// </summary>
    public partial class reset : Window
    {
        public reset()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random tmp = new Random();
            int r = tmp.Next();
            r %= 10000;

        }
    }
}
