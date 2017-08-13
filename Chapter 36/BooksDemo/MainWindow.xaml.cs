﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wrox.ProCSharp.WPF.Data;

namespace Wrox.ProCSharp.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClose(object sender, ExecutedRoutedEventArgs e)
        {

            Application.Current.Shutdown();
        }

        //private void OnShowBook(object sender, ExecutedRoutedEventArgs e)
        //{
        //    var bookUI = new BookUC();
        //    // bookUI.DataContext = new Book { Title = "Professional C# 2018", Publisher = "Wrox Press", Isbn = "978-0-470-19137-8" };
        //    this.tabControl1.SelectedIndex = this.tabControl1.Items.Add(new TabItem { Header = "Book", Content = bookUI });
        //}

        private void OnShowBook(object sender, RoutedEventArgs e)
        {
            var bookUI = new BookUC();
            // bookUI.DataContext = new Book { Title = "Professional C# 2008", Publisher = "Wrox Press", Isbn = "978-0-470-19137-8" };
            this.tabControl1.SelectedIndex = this.tabControl1.Items.Add(new TabItem { Header = "Book", Content = bookUI });
        }

        private void OnShowBooks(object sender, RoutedEventArgs e)
        {
            var booksUI = new BooksUC();
            this.tabControl1.SelectedIndex = this.tabControl1.Items.Add(new TabItem { Header="Books", Content=booksUI});

        }

        private void OnShowGrid(object sender, RoutedEventArgs e)
        {
            var gridUI = new DataGridUC();
            this.tabControl1.SelectedIndex = this.tabControl1.Items.Add(new TabItem { Header = "DataGrid", Content = gridUI });
        }


        private void OnShowBook(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}