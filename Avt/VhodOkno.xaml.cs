using LISTURLIC.Classs;
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

namespace LISTURLIC.Avt
{
    /// <summary>
    /// Логика взаимодействия для VhodOkno.xaml
    /// </summary>
    public partial class VhodOkno : Window
    {
        public VhodOkno()
        {
            InitializeComponent();
            
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void ExitBnt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void VhodBtn_Click(object sender, RoutedEventArgs e)
        {
            var oper = ContextClass.context.Users.Where(i => LoginTxt.Text == i.Login && PassTxt.Password == i.Pasword);

            if (oper.Count() > 0)
            {
                AtrClass.chet = 1;
                var id = ContextClass.context.Users.Where(i => LoginTxt.Text == i.Login && PassTxt.Password == i.Pasword).FirstOrDefault();
                AtrClass.id = id.ID_users;
                AtrClass.post = id.Post1.Post1;
                FrameCalss.frokno.Navigate(new AcaountPage());
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Неправильный логин или пароль", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                LoginTxt.Text = "";
                PassTxt.Password = "";
            }
        }
    }
}
