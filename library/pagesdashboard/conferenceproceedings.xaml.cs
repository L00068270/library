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

namespace library.pagesdashboard
{
    /// <summary>
    /// Interaction logic for conferenceproceedings.xaml
    /// </summary>
    public partial class conferenceproceedings : Page
    {
        public conferenceproceedings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            pages.dashboard dashboard = new pages.dashboard();
            this.NavigationService.Navigate(dashboard);
        }
    }
}