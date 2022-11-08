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
    /// Логика взаимодействия для LikvPage.xaml
    /// </summary>
    public partial class LikvPage : Page
    {
        public LikvPage()
        {
            Organizations organizations = new Organizations();
            InitializeComponent();
            var orgn = ContextClass.context.Organizations.Where(i => i.ID_organizations == IDClass.id).FirstOrDefault();
            StatTxt.ItemsSource = ContextClass.context.Status_organizations.Select(i => i.Status).ToList();
            StatTxt.SelectedItem = ContextClass.context.Status_organizations.Where(i => i.ID_information == organizations.Status_organizations).Select(i => i.Status).FirstOrDefault();

            NameTxt.Text = orgn.Full_name;

            NamTxt.Text = orgn.Full_name;
            AbbTxt.Text = orgn.Abbreviated_name;
            StatTxt.Text = orgn.Status_organizations1.Status;

            LikvBtn.Visibility = Visibility.Hidden;
            string post = AtrClass.post;
            if (post == "Заместитель руководителя" || post == "Руководитель")
            {
                LikvBtn.Visibility = Visibility.Visible;
            }
            

            
        }

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameCalss.frokno.GoBack();
        }

        private void LikvBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(PrichTxt.Text))
                {
                    MessageBox.Show("Поле Причины пустое", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    PrichTxt.Focus();
                }

                var orgn = ContextClass.context.Organizations.Where(i => i.ID_organizations == IDClass.id).FirstOrDefault();
                orgn.Status_organizations1.Status = StatTxt.Text;

                Inactive_organizations inactive = new Inactive_organizations()
                {
                    Organizations = IDClass.id,
                    Reason = PrichTxt.Text,
                    Date = (DateTime)DateTxt.SelectedDate,
                };

                ContextClass.context.Inactive_organizations.Add(inactive);
                ContextClass.context.SaveChanges();
                MessageBox.Show($"Предриятие {AbbTxt.Text} ликвидирован!");
                FrameCalss.frokno.GoBack();
            }
            catch
            {
                MessageBox.Show("Исключение!");
            }
        }
    }
}
