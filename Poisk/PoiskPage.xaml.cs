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

namespace LISTURLIC.Poisk
{
    /// <summary>
    /// Логика взаимодействия для PoiskPage.xaml
    /// </summary>
    public partial class PoiskPage : Page
    {
        private Тax_accounting tax = new Тax_accounting();
        public PoiskPage()
        {
            InitializeComponent();
            string poisk = PoiskTxt.Text;
        }

        private void PioslBtn_Click(object sender, RoutedEventArgs e)
        {
            var inn = ContextClass.context.Тax_accounting.Where(i => PoiskTxt.Text == i.INN);
            var ogrn = ContextClass.context.Registration_information.Where(i => PoiskTxt.Text == i.OGRN || PoiskTxt.Text == i.Address);
            var name = ContextClass.context.Organizations.Where(i => PoiskTxt.Text == i.Abbreviated_name);
            var adres = ContextClass.context.Registration_information.Where(i => PoiskTxt.Text == i.Address);
            NumberClass.vod = PoiskTxt.Text;

            if (inn.Count() > 0)
            {
                NumberClass.number = 0;
                FrameCalss.frokno.Navigate(new ListPage());
            }
            else if (ogrn.Count() > 0)
            {
                NumberClass.number = 1;
                FrameCalss.frokno.Navigate(new ListPage());
            }
            else if(name.Count()> 0)
            {
                FrameCalss.frokno.Navigate(new ListPage());
            }
            else if (adres.Count() > 0)
            {
                NumberClass.number = 2;
                FrameCalss.frokno.Navigate(new ListPage());
            }
            else
            {
                NumberClass.number = 3;
                System.Windows.MessageBox.Show(@"По запросу " + PoiskTxt.Text + " нечего не найдено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
