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
    /// Логика взаимодействия для OrganPage.xaml
    /// </summary>
    public partial class OrganPage : Page
    {
        public OrganPage()
        {
            try
            {
                InitializeComponent();
                var orgn = ContextClass.context.Organizations.Where(i => i.ID_organizations == IDClass.id).FirstOrDefault();

                NameTxt.Text = orgn.Full_name;

                NamTxt.Text = orgn.Full_name;
                GrnTxt.Text = orgn.Dategrn;
                AbbTxt.Text = orgn.Abbreviated_name;

                CityTxt.Text = orgn.Address.City;
                GrnTxt1.Text = orgn.Address.Dategrn;
                adresTxt.Text = orgn.Address.Address1;

                SpTxt.Text = orgn.Registration_information.Мethod_education;
                OGRNTxt.Text = orgn.Registration_information.OGRN;
                RegTxt.Text = orgn.Registration_information.Date.ToString();
                CityTxt1.Text = orgn.Registration_information.City;
                adressTxt.Text = orgn.Registration_information.Address;
                GrnTxt2.Text = orgn.Dategrn;

                NameTxt1.Text = orgn.Registration_authority1.Name;
                AddresTxt.Text = orgn.Registration_authority1.Address;
                GrnTxt3.Text = orgn.Dategrn;

                FioTxt.Text = orgn.Legal_entity.Allname;
                INNTxt1.Text = orgn.Legal_entity.INN;
                GrnTxt4.Text = orgn.Dategrn;

                ViewTxt.Text = orgn.Capital.View;
                KapitTxt.Text = orgn.Capital.Size__in_rub_.ToString();
                GrnTxt5.Text = orgn.Dategrn;

                INNTxt2.Text = orgn.Тax_accounting.INN;
                KppTxt.Text = orgn.Тax_accounting.KPP;
                DateposTxt.Text = orgn.Тax_accounting.Date.ToString();
                InfTxt.Text = orgn.Тax_accounting.Name_authority;
                GrnTxt6.Text = orgn.Dategrn;
            }
            catch
            {
                MessageBox.Show("Исключение!");
            }
        }

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.GoBack();
        }
    }
}
