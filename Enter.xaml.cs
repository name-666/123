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
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    public partial class Enter : Window

    {
        test123Entities db = new test123Entities();
        public Enter()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            user us = db.user.Where(t => t.username == login.Text && t.userpassword == pass.Password).SingleOrDefault();
            if (us != null)
            {
                
                tool tool = new tool();
                tool.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
            
        }
    }
}
