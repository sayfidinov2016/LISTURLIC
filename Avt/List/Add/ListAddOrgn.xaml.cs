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

namespace LISTURLIC.Avt.List.Add
{
    /// <summary>
    /// Логика взаимодействия для ListAddOrgn.xaml
    /// </summary>
    public partial class ListAddOrgn : Page
    {
        public ListAddOrgn()
        {
            InitializeComponent();
            ListOrn.ItemsSource = ContextClass.context.Organizations.Where(i => i.Status_organizations == 2).ToList();
        }

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.GoBack();
        }

        private void VodBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ListOrn.SelectedItem is Organizations orgn)
            {
                IDClass.id = orgn.ID_organizations;
            }
            FrameCalss.frokno.Navigate(new AddDataOrgnPage());
        }
    }
}
