using LISTURLIC.Avt;
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

namespace LISTURLIC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Oknofr.Navigate(new PoiskPage());
            FrameCalss.frokno = Oknofr;
        }

        private void CloseBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void SverBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void PoiscBtn_Click(object sender, RoutedEventArgs e)
        {
            Oknofr.Navigate(new PoiskPage());
        }

        private void VhodBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AtrClass.chet == 0)
            {
                VhodOkno vhodOkno = new VhodOkno();
                vhodOkno.ShowDialog();
            }
            else
            {
                FrameCalss.frokno.Navigate(new AcaountPage());
            }
        }
    }
}
