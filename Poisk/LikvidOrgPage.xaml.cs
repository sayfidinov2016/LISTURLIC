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
    /// Логика взаимодействия для LikvidOrgPage.xaml
    /// </summary>
    public partial class LikvidOrgPage : Page
    {
        public LikvidOrgPage()
        {
            InitializeComponent();
            var orgn = ContextClass.context.Organizations.Where(i => i.ID_organizations == IDClass.id).FirstOrDefault();
            var likvid = ContextClass.context.Inactive_organizations.Where(i => i.Organizations == IDClass.id).FirstOrDefault();

            NameTxt.Text = orgn.Full_name;

            NamTxt.Text = orgn.Full_name;
            GrnTxt.Text = orgn.Dategrn;
            AbbTxt.Text = orgn.Abbreviated_name;
            CityTxt.Text = orgn.Registration_information.City;
            adresTxt.Text = orgn.Registration_information.Address;
            INNTxt.Text = orgn.Тax_accounting.INN;
            OGRNTxt.Text = orgn.Registration_information.OGRN;
            FioTxt.Text = orgn.Legal_entity.Allname;
            StatTxt.Text = orgn.Status_organizations1.Status;
            PrichTxt.Text = likvid.Reason;
            DateTxt.Text = likvid.Date.ToString();
        }

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.GoBack();
        }
    }
}
