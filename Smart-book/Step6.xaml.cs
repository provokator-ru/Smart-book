﻿using System;
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
    /// Логика взаимодействия для Step6.xaml
    /// </summary>
    public partial class Step6 : Page
    {
        public Step6()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Step7());
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Step5());
        }
    }
}
