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
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Window
    {
        test123Entities db = new test123Entities();
        public reg()
        {
            InitializeComponent();

            srole.ItemsSource = db.role.ToList();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
           
                user us = new user()
                {
                    username = login.Text,
                    userpassword = pass.Password.ToString(),
                    mail = mail.Text,
                    role = ((role)srole.SelectedItem).id
                };
            
            try
            {
                db.user.Add(us);
                db.SaveChanges();
               
            }
            catch(Exception)
            {
                
                MessageBox.Show("Ошибка заполнения формы ","Error!",MessageBoxButton.OK , MessageBoxImage.Error);
              
            }


            Close();
        }
    }
}
