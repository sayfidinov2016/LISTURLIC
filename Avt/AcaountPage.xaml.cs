using LISTURLIC.Avt.List;
using LISTURLIC.Classs;
using LISTURLIC.Poisk;
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

namespace LISTURLIC.Avt
{
    /// <summary>
    /// Логика взаимодействия для AcaountPage.xaml
    /// </summary>
    public partial class AcaountPage : Page
    {
        public AcaountPage()
        {
            InitializeComponent();
            var act_id = ContextClass.context.Users.Where(i => AtrClass.id == i.ID_users).FirstOrDefault();
            FioTxt.Text = act_id.Allname;
            PostTxt.Text = act_id.Post1.Post1;

            AddBtn.Visibility = Visibility.Hidden;
            UserBtn.Visibility = Visibility.Hidden;
            string post = AtrClass.post;

            if (post == "Заместитель руководителя" || post == "Руководитель")
            {
                AddBtn.Visibility = Visibility.Visible;
            }
            if (post == "Руководитель")
            {
                UserBtn.Visibility = Visibility.Visible;
            }
        }
        
        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AtrClass.chet = 0;
                FrameCalss.frokno.Navigate(new PoiskPage());
            }
            catch
            {
                MessageBox.Show("Исключение!");
            }
        }

        private void ListBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.Navigate(new ListOrgnPage());
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.Navigate(new ViewAddPage());
        }

        private void UserBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.Navigate(new UsersPage());
        }
    }
}
