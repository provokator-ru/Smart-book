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

namespace Smart_book
{
    /// <summary>
    /// Логика взаимодействия для Step9.xaml
    /// </summary>
    public partial class Step9 : Page
    {
        public Step9()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Step8());
        }
    }
}
