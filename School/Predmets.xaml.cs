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
    /// Логика взаимодействия для Predmets.xaml
    /// </summary>
    public partial class Predmets : Window
    {
        public Predmets()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //открытие меню оценок, выбор предмета идет по тексту кнопки
            AdminMenu aM = new AdminMenu(((Button)sender).Content.ToString());
            aM.Show();
            Close();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new MainWindow();
            mW.Show();
            Close();
        }
    }
}
