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
    /// Логика взаимодействия для AddOrgnPage.xaml
    /// </summary>
    public partial class AddOrgnPage : Page
    {
        public AddOrgnPage()
        {
            Organizations organizations = new Organizations();
            InitializeComponent();
            Type.ItemsSource = ContextClass.context.Type_organization_.Select(i => i.Type).ToList();
            Type.SelectedItem = ContextClass.context.Type_organization_.Where(i => i.ID_type == organizations.Type_organizations).Select(i => i.Type).FirstOrDefault();
            Organ.ItemsSource = ContextClass.context.Registration_authority.Select(i => i.Name).ToList();
            Organ.SelectedItem = ContextClass.context.Registration_authority.Where(i => i.ID_authority == organizations.Registration_authority).Select(i => i.Name).FirstOrDefault();

            
        }

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.GoBack();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            int _id_type = ContextClass.context.Type_organization_.Where(i => i.Type == Type.SelectedItem.ToString()).
                Select(i => i.ID_type).FirstOrDefault();
            int _id_organ = ContextClass.context.Registration_authority.Where(i => i.Name == Organ.SelectedItem.ToString()).
                Select(i => i.ID_authority).FirstOrDefault();

            Organizations org = new Organizations()
            {
                Full_name = Full.Text,
                Abbreviated_name = Abbv.Text,
                GRN = Grn.Text,
                Date_USRLE = (DateTime)Date.SelectedDate,
                Type_organizations = _id_type,
                Registration_authority = _id_organ,
                Status_organizations = 2
            };
            ContextClass.context.Organizations.Add(org);
            ContextClass.context.SaveChanges();

            MessageBox.Show("Добавлено");
        }
    }
}
