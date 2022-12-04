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

namespace School
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminMenu a = new AdminMenu(((Button) sender).Content.ToString());
            a.Show();
        }

        private void loginB_Click(object sender, RoutedEventArgs e)
        {
            DatabaseSEntities1 db = new DatabaseSEntities1();
            if (db.Student.Where(x => x.Login == loginText.Text && x.Password == passwordText.Password).Count() > 0)
            {
                Student s = db.Student.Where(x => x.Login == loginText.Text && x.Password == passwordText.Password).FirstOrDefault();
                MessageBox.Show($"Вход выполнен под пользователем {s.FullName}");
                StudentMenu sM = new StudentMenu(s.ID_s);
                sM.Show();
                Close();
            }
            else if (loginText.Text == "admin" && passwordText.Password == "admin")
            {
                Predmets p = new Predmets();
                MessageBox.Show($"Вход выполнен под администратором");
                p.Show();
                Close();
            }
            else MessageBox.Show("Такого логина или пароля не существует");
        }
    }
}
