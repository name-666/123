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
    /// Логика взаимодействия для tool.xaml
    /// </summary>
    public partial class tool : Window
    {
        test123Entities db = new test123Entities();
        public tool()
        {
            
            InitializeComponent();

            dataGrid.ItemsSource = db.user.ToList();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            user us = db.user.Where(t => t.username == "123").SingleOrDefault();
            db.user.Remove(us);
            db.SaveChanges();
            
        }
    }
}
