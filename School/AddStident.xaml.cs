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

namespace School
{
    /// <summary>
    /// Логика взаимодействия для AddStident.xaml
    /// </summary>
    public partial class AddStident : Window
    {
        public AddStident()
        {
            InitializeComponent();
        }

        private void createB_Click(object sender, RoutedEventArgs e)
        {
            //проверка на заполненные поля
            DatabaseSEntities1 db = new DatabaseSEntities1();
            if (surnameT.Text != "" && nameT.Text != "" && LoginT.Text != "" && PasswordT.Text != "" && db.Student.Where(x => x.Login == LoginT.Text).Count() == 0)
                DialogResult = true;
            else MessageBox.Show("Заполни все поля или такой логин уже есть");
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
