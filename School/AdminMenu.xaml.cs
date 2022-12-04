using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        string itemP;
        DatabaseSEntities1 db = new DatabaseSEntities1();
        public AdminMenu(string item)
        {
            itemP = item;
            InitializeComponent();
            int[] tt = { 0, 2, 3, 4, 5 };
            test.ItemsSource = db.Evaluations.Where(x => x.Item.Name_i == itemP).ToList();
            yan.ItemsSource = tt;
            fev.ItemsSource = tt;
            mar.ItemsSource = tt;
            apr.ItemsSource = tt;
            may.ItemsSource = tt;
            iun.ItemsSource = tt;
            iul.ItemsSource = tt;
            avg.ItemsSource = tt;
            sen.ItemsSource = tt;
            oct.ItemsSource = tt;
            noyab.ItemsSource = tt;
            dec.ItemsSource = tt;
        }

        private void SaveB_Click(object sender, RoutedEventArgs e)
        {
            Evaluations ev = test.SelectedItem as Evaluations;
            db.SaveChanges();
            test.ItemsSource = db.Evaluations.Where(x => x.Item.Name_i == itemP).ToList();
        }

        private void test_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
      /*      Evaluations ev = test.SelectedItem as Evaluations;
            var conn = db.Evaluations.Where(c => c.ID_t == ev.ID_t).FirstOrDefault();
            conn.Yan_e = ev.Yan_e;
            conn.Fev_e = ev.Fev_e;
            db.SaveChanges();*/
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Predmets p = new Predmets();
            p.Show();
            Close();
        }
    }
}
