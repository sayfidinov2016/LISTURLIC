using LISTURLIC.Avt.List.Add;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LISTURLIC.Avt.List
{
    /// <summary>
    /// Логика взаимодействия для ViewAddPage.xaml
    /// </summary>
    public partial class ViewAddPage : Page
    {
        public ViewAddPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.Navigate(new AddOrgnPage());
        }

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.GoBack();
        }

        private void AddBtn1_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.Navigate(new ListAddOrgn());
        }
    }
}
