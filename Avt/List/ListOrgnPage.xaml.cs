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

namespace LISTURLIC.Avt.List
{
    /// <summary>
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public partial class ListOrgnPage : Page
    {
        private void Update_search()
        {
            var poisk = ContextClass.context.Organizations.ToList();
            poisk = poisk.Where(i => i.Abbreviated_name.ToLower().Contains(PoiskTxt.Text.ToLower())).ToList();
            ListOrgn.ItemsSource = poisk.OrderBy(i => i.Abbreviated_name);
        }
        
        public ListOrgnPage()
        {
            InitializeComponent();
            ListOrgn.ItemsSource = ContextClass.context.Organizations.ToList();
        }

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.GoBack();
        }

        private void PoiskTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update_search();
        }

        private void VodBtn_Click(object sender, RoutedEventArgs e)
        {
            try 
            { 
                if (ListOrgn.SelectedItem is Organizations orgn)
                {
                    IDClass.id = orgn.ID_organizations;
                }
                var status = ContextClass.context.Organizations.Where(i => i.ID_organizations == IDClass.id).FirstOrDefault();
                int _status = status.Status_organizations;
                if (_status == 3)
                {
                    FrameCalss.frokno.Navigate(new LikvidOrgPage());
                }
                else if (_status == 2)
                {
                    MessageBox.Show("Предприятие в стадии реорганизации", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
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

        private void ChangBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ListOrgn.SelectedItem is Organizations orgn)
            {
                IDClass.id = orgn.ID_organizations;
            }
            var status = ContextClass.context.Organizations.Where(i => i.ID_organizations == IDClass.id).FirstOrDefault();
            int _status = status.Status_organizations;
            if (_status == 2)
            {
                MessageBox.Show("Предприятие в стадии реорганизации", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
            else if (_status == 3)
            {
                MessageBox.Show("Предприятие ликвидированное", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                FrameCalss.frokno.Navigate(new ChangePage());
            }
           
        }

        private void LikvBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ListOrgn.SelectedItem is Organizations orgn)
            {
                IDClass.id = orgn.ID_organizations;
            }
            var status = ContextClass.context.Organizations.Where(i => i.ID_organizations == IDClass.id).FirstOrDefault();
            int _status = status.Status_organizations;
            if (_status == 2)
            {
                MessageBox.Show("Предприятие в стадии реорганизации", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
            else if (_status == 3) 
            {
                MessageBox.Show("Предприятие уже ликвидированное", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                FrameCalss.frokno.Navigate(new LikvPage());
            }
            
        }
    }
}
