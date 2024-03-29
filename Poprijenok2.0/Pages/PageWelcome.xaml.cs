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

namespace Poprijenok2._0.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageWelcome.xaml
    /// </summary>
    public partial class PageWelcome : Page
    {
        public PageWelcome()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Открытие окна для просмотра списка агентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgents_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageAgents());
        }
    }
}
