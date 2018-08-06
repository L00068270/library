﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using library.dashboard.viewmodels;

namespace library.pages
{
    /// <summary>
    /// Interaction logic for dashboard.xaml
    /// </summary>
    public partial class dashboard : Page
    {
        /**************************************************************************************************
         * database framework reference
         *************************************************************************************************/

        LinqAzureDatabaseDataContext dc = new LinqAzureDatabaseDataContext
            (Properties.Settings.Default.libraryConnectionString);

        public static ListView listview;

        /**************************************************************************************************
         * new instance of LibraryMember class so we can send the authenticated LibraryMember information 
         * from the login form
         *************************************************************************************************/
        public LibraryMember _instanceLibraryMember = new LibraryMember();

        public dashboard()
        {
            InitializeComponent();
            functionToLoadDatabaseToListView();
        }

        

        /**************************************************************************************************
         * set the dashboard to load LibraryMember details into the LibraryMember information box at
         * the top of the screen when it is opened from the login window
         *************************************************************************************************/
        private void functionWindowLoaded(object sender, RoutedEventArgs e)
        {
            lblCurrentUser.Content = _instanceLibraryMember.NameFirst;
        }

        //*************************************************************************************************        
        // functionToLoadDatabaseToListView
        //*************************************************************************************************
        public void functionToLoadDatabaseToListView()
        {
            //myListView.ItemsSource = dc.LibraryMembers.ToList();
            //listview = myListView;
        }


        List<LibraryMember> _libraryMemberList = new List<LibraryMember>();

        //lstLibraryMembersList.ItemsSource = _libraryMemberList;

        
        /*
        public class LibraryMemberSummaryData
        {
            public string MemberID { get; set; }
            public string NameFirst { get; set; }
            public string NameLast { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Classification { get; set; }
        }
        */






        private void btnSearchText_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnResetSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBuilding_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            Environment.Exit(0);
        }

        private void books_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new viewmodel_books();
        }

        private void journals_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new viewmodel_journals();
        }

        private void dvds_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new viewmodel_dvds();
        }

        private void conferenceproceedings_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new viewmodel_conferenceproceedings();
        }

        private void referencebooks_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new viewmodel_referencebooks();
        }
    }    
}
