using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LISTURLIC.Classs
{
    static class ProverkaClass
    {
        internal static bool Proverka(TextBox OGRN, TextBox Inn, TextBox Kpp, TextBox Name, TextBox Last, TextBox Patr, TextBox Post, TextBox View, TextBox Sum)
        {
            string ogrn = OGRN.Text;
            string inn = Inn.Text;
            string kpp = Kpp.Text;
            string name = Name.Text;
            string last = Last.Text;
            string patr = Patr.Text;
            string post = Post.Text;
            string view = View.Text;
            string sum = Sum.Text;

            if (string.IsNullOrEmpty(ogrn) || !ogrn.All(Char.IsDigit))
            {
                MessageBox.Show("Неправильный введен ОГРН!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                OGRN.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(inn) || !inn.All(Char.IsDigit))
            {
                MessageBox.Show("Неправильный введен ИНН!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Inn.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(kpp) || !kpp.All(Char.IsDigit))
            {
                MessageBox.Show("Неправильный введен КПП!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Kpp.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Поле Имя пустое", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Name.Focus();

                return false;
            }
            else if (name.IndexOf('0') >= 0 || name.IndexOf('1') >= 0 || name.IndexOf('2') >= 0 || name.IndexOf('3') >= 0
                  || name.IndexOf('4') >= 0 || name.IndexOf('5') >= 0 || name.IndexOf('6') >= 0 || name.IndexOf('7') >= 0
                  || name.IndexOf('8') >= 0 || name.IndexOf('9') >= 0)
            {
                MessageBox.Show("В поле Имя имеются цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Name.Text = "";
                Name.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(last))
            {
                MessageBox.Show("Поле Фамилия пустое", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Last.Focus();

                return false;
            }
            else if (last.IndexOf('0') >= 0 || last.IndexOf('1') >= 0 || last.IndexOf('2') >= 0 || last.IndexOf('3') >= 0
                  || last.IndexOf('4') >= 0 || last.IndexOf('5') >= 0 || last.IndexOf('6') >= 0 || last.IndexOf('7') >= 0
                  || last.IndexOf('8') >= 0 || last.IndexOf('9') >= 0)
            {
                MessageBox.Show("В поле Фамилия имеются цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Last.Text = "";
                Last.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(patr))
            {
                MessageBox.Show("Поле Отчество пустое", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Patr.Focus();

                return false;
            }
            else if (patr.IndexOf('0') >= 0 || patr.IndexOf('1') >= 0 || patr.IndexOf('2') >= 0
                  || patr.IndexOf('3') >= 0 || patr.IndexOf('4') >= 0 || patr.IndexOf('5') >= 0
                  || patr.IndexOf('6') >= 0 || patr.IndexOf('7') >= 0
                  || patr.IndexOf('8') >= 0 || patr.IndexOf('9') >= 0)
            {
                MessageBox.Show("В поле Отчество имеются цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Patr.Text = "";
                Patr.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(post))
            {
                MessageBox.Show("Поле Должность пустое", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Post.Focus();

                return false;
            }
            else if (post.IndexOf('0') >= 0 || post.IndexOf('1') >= 0 || post.IndexOf('2') >= 0
                  || post.IndexOf('3') >= 0 || post.IndexOf('4') >= 0 || post.IndexOf('5') >= 0
                  || post.IndexOf('6') >= 0 || post.IndexOf('7') >= 0
                  || post.IndexOf('8') >= 0 || post.IndexOf('9') >= 0)
            {
                MessageBox.Show("В поле Должность имеются цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Post.Text = "";
                Post.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(view))
            {
                MessageBox.Show("Поле Вид капитала пустое", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                View.Focus();

                return false;
            }
            else if (view.IndexOf('0') >= 0 || view.IndexOf('1') >= 0 || view.IndexOf('2') >= 0
                  || view.IndexOf('3') >= 0 || view.IndexOf('4') >= 0 || view.IndexOf('5') >= 0
                  || view.IndexOf('6') >= 0 || view.IndexOf('7') >= 0
                  || view.IndexOf('8') >= 0 || view.IndexOf('9') >= 0)
            {
                MessageBox.Show("В поле Вид капитала имеются цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                View.Text = "";
                View.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(sum) || !sum.All(Char.IsDigit))
            {
                MessageBox.Show("Неправильный введено Сумма капитала!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Sum.Focus();

                return false;
            }

            return true;
        }
    }
}
