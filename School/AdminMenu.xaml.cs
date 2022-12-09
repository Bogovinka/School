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
        //id предмета
        string itemP;
        //выбранная база данных
        DatabaseSEntities1 db = new DatabaseSEntities1();
        int[] tt = { 0, 2, 3, 4, 5 };
        public AdminMenu(string item)
        {
            //вывод данных в таблицы и комбо боксы
            itemP = item;
            InitializeComponent();
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
            //сохранение изменений в бд
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
            //выход
            Predmets p = new Predmets();
            p.Show();
            Close();
        }

        private void addU_Click(object sender, RoutedEventArgs e)
        {
            //добавление студента
            AddStident aS = new AddStident();
            aS.ShowDialog();
            if(aS.DialogResult == true)
            {
                //заполнение данных о студенте
                Student newS = new Student()
                {
                    Class_id = 1,
                    Surname = aS.surnameT.Text,
                    Name = aS.nameT.Text,
                    Login = aS.LoginT.Text,
                    Password = aS.PasswordT.Text
                };
                //заполнение его оценок
                Evaluations ev1 = new Evaluations()
                {
                    Item_id = 1,
                    Student_id = newS.ID_s,
                    Yan_e = 0,
                    Fev_e = 0,
                    Mar_e = 0,
                    Apr_e = 0,
                    May_e = 0,
                    Iun_e = 0,
                    Iul_e = 0,
                    Avg_e = 0,
                    Sen_e = 0,
                    Oct_e = 0,
                    Noyab_e = 0,
                    Dec_e = 0
                };
                Evaluations ev2 = new Evaluations()
                {
                    Item_id = 2,
                    Student_id = newS.ID_s,
                    Yan_e = 0,
                    Fev_e = 0,
                    Mar_e = 0,
                    Apr_e = 0,
                    May_e = 0,
                    Iun_e = 0,
                    Iul_e = 0,
                    Avg_e = 0,
                    Sen_e = 0,
                    Oct_e = 0,
                    Noyab_e = 0,
                    Dec_e = 0
                };
                Evaluations ev3 = new Evaluations()
                {
                    Item_id = 3,
                    Student_id = newS.ID_s,
                    Yan_e = 0,
                    Fev_e = 0,
                    Mar_e = 0,
                    Apr_e = 0,
                    May_e = 0,
                    Iun_e = 0,
                    Iul_e = 0,
                    Avg_e = 0,
                    Sen_e = 0,
                    Oct_e = 0,
                    Noyab_e = 0,
                    Dec_e = 0
                };
                Evaluations ev4 = new Evaluations()
                {
                    Item_id = 4,
                    Student_id = newS.ID_s,
                    Yan_e = 0,
                    Fev_e = 0,
                    Mar_e = 0,
                    Apr_e = 0,
                    May_e = 0,
                    Iun_e = 0,
                    Iul_e = 0,
                    Avg_e = 0,
                    Sen_e = 0,
                    Oct_e = 0,
                    Noyab_e = 0,
                    Dec_e = 0
                };
                Evaluations ev5 = new Evaluations()
                {
                    Item_id = 5,
                    Student_id = newS.ID_s,
                    Yan_e = 0,
                    Fev_e = 0,
                    Mar_e = 0,
                    Apr_e = 0,
                    May_e = 0,
                    Iun_e = 0,
                    Iul_e = 0,
                    Avg_e = 0,
                    Sen_e = 0,
                    Oct_e = 0,
                    Noyab_e = 0,
                    Dec_e = 0
                };
                Evaluations ev6 = new Evaluations()
                {
                    Item_id = 6,
                    Student_id = newS.ID_s,
                    Yan_e = 0,
                    Fev_e = 0,
                    Mar_e = 0,
                    Apr_e = 0,
                    May_e = 0,
                    Iun_e = 0,
                    Iul_e = 0,
                    Avg_e = 0,
                    Sen_e = 0,
                    Oct_e = 0,
                    Noyab_e = 0,
                    Dec_e = 0
                };
                //добавление в бд
                db.Evaluations.Add(ev1);
                db.Evaluations.Add(ev2);
                db.Evaluations.Add(ev3);
                db.Evaluations.Add(ev4);
                db.Evaluations.Add(ev5);
                db.Evaluations.Add(ev6);
                db.Student.Add(newS);
                //сохранение
                db.SaveChanges();
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
        }
    }
}
