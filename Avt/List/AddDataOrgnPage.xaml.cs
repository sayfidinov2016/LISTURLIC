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
    /// Логика взаимодействия для AddDataOrgnPage.xaml
    /// </summary>
    public partial class AddDataOrgnPage : Page
    {
        
        public AddDataOrgnPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Address address = new Address()
            {
                ID_address = IDClass.id,
                City = CityUr.Text,
                GRN = GRN.Text,
                Date_USRLE = (DateTime)Date.SelectedDate,
                Address1 = Adres.Text
            };
            ContextClass.context.Address.Add(address);

            Registration_information regst = new Registration_information()
            {
                ID_registrations = IDClass.id,
                Мethod_education = Obraz.Text,
                OGRN = OGRN.Text,
                Date = (DateTime)Date1.SelectedDate,
                City = City.Text,
                Address = Adres1.Text
            };
            ContextClass.context.Registration_information.Add(regst);

            Legal_entity legal = new Legal_entity()
            {
                ID_legal_entity = IDClass.id,
                Lastname = Lastname.Text,
                Name = Name.Text,
                Patronymic =Patronymic.Text,
                INN = INN.Text,
                Post = Post.Text
            };
            ContextClass.context.Legal_entity.Add(legal);

            Capital capital = new Capital()
            {
                ID_capital = IDClass.id,
                View = View.Text,
                Size__in_rub_ = Int32.Parse(Size.Text)
            };
            ContextClass.context.Capital.Add(capital);

            Тax_accounting tax = new Тax_accounting()
            {
                ID_accounting = IDClass.id,
                INN = INN1.Text,
                KPP = KPP.Text,
                Date  = (DateTime)Date2.SelectedDate,
                Name_authority = NameOrgan.Text
            };
            ContextClass.context.Тax_accounting.Add(tax);

            var change = ContextClass.context.Organizations.Where(i => i.ID_organizations == IDClass.id).FirstOrDefault();
            change.Status_organizations = 1;
            ContextClass.context.SaveChanges();

            FrameCalss.frokno.Navigate(new AcaountPage());
        }

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.GoBack();
        }
    }
}
