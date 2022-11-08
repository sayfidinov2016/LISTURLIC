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
    /// Логика взаимодействия для ChangePage.xaml
    /// </summary>
    public partial class ChangePage : Page
    {
        public ChangePage()
        {
            InitializeComponent();
            var change = ContextClass.context.Organizations.Where(i => i.ID_organizations == IDClass.id).FirstOrDefault();
            

            CityTxt.Text = change.Address.City;
            adresTxt.Text = change.Address.Address1;

            CityTxt1.Text = change.Registration_information.City;
            adresTxt1.Text = change.Registration_information.Address;
            OGRNtxt.Text = change.Registration_information.OGRN;

            InnTxt.Text = change.Тax_accounting.INN;
            KppTxt1.Text = change.Тax_accounting.KPP;
            OrganTxt.Text = change.Тax_accounting.Name_authority;

            FullTxt.Text = change.Full_name;
            AbbTxt.Text = change.Abbreviated_name;

            NameTxt1.Text = change.Legal_entity.Name;
            LastTxt.Text = change.Legal_entity.Lastname;
            PatrTxt1.Text = change.Legal_entity.Patronymic;
            PostTxt.Text = change.Legal_entity.Post;

            ViewTxt.Text = change.Capital.View;
            SumTxt.Text = change.Capital.Size__in_rub_.ToString();

            ChangeDate.Visibility = Visibility.Hidden;
            ChangeDate1.Visibility = Visibility.Hidden;
            ChangeDate2.Visibility = Visibility.Hidden;
            string post = AtrClass.post;
            if (!(post == "Оператор"))
            {
                ChangeDate.Visibility = Visibility.Visible;
                ChangeDate1.Visibility = Visibility.Visible;
                ChangeDate2.Visibility = Visibility.Visible;
            }
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!ProverkaClass.Proverka(OGRNtxt, InnTxt, KppTxt1, NameTxt1, LastTxt, PatrTxt1, PostTxt, ViewTxt, SumTxt))
            {
                return;
            }

            var change = ContextClass.context.Organizations.Where(i => i.ID_organizations == IDClass.id).FirstOrDefault();

            change.Address.City = CityTxt.Text;
            change.Address.Address1 = adresTxt.Text;
            change.Registration_information.City = CityTxt1.Text;
            change.Registration_information.Address = adresTxt1.Text;
            change.Тax_accounting.INN = InnTxt.Text;
            change.Тax_accounting.KPP = KppTxt1.Text;
            change.Тax_accounting.Name_authority = OrganTxt.Text;
            change.Legal_entity.Name = NameTxt1.Text;
            change.Legal_entity.Lastname = LastTxt.Text;
            change.Legal_entity.Patronymic = PatrTxt1.Text;
            change.Legal_entity.Post = PostTxt.Text;
            change.Capital.View = ViewTxt.Text;
            change.Capital.Size__in_rub_ = Int32.Parse(SumTxt.Text);

            MessageBox.Show("Успешно изменено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.GoBack();
        }
    }
}
