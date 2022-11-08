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
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        public int num = NumberClass.number;
        public string str = NumberClass.vod;
        public ListPage()
        {
            InitializeComponent();

            if (num == 0)
            {
                PoislList.ItemsSource = ContextClass.context.Organizations.Where(i => i.Тax_accounting.INN == str).ToList();
            }
            else if (num == 1)
            {
                PoislList.ItemsSource = ContextClass.context.Organizations.Where(i => i.Registration_information.OGRN == str).ToList();
            }
            else if (num == 2)
            {
                PoislList.ItemsSource = ContextClass.context.Organizations.Where(i => i.Abbreviated_name == str).ToList();
            }
            else if (num == 3)
            {
                PoislList.ItemsSource = ContextClass.context.Organizations.Where(i => i.Registration_information.Address == str).ToList();
            }
        }

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.GoBack();
        }

        private void VodBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PoislList.SelectedItem is Organizations orgn)
                {
                    IDClass.id = orgn.ID_organizations;
                }
                var status = ContextClass.context.Organizations.Where(i => i.ID_organizations == IDClass.id).FirstOrDefault();
                string _status = status.Status_organizations1.Status;
                if (_status == "ликвидированное")
                {
                    FrameCalss.frokno.Navigate(new LikvidOrgPage());
                }
                else
                {
                    FrameCalss.frokno.Navigate(new OrganPage());
                }
            }
            catch
            {
                MessageBox.Show("Исключение!");
            }
            
        }
    }
}
