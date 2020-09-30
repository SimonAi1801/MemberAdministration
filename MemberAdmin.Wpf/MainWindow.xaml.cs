﻿using MemberAdmin.Core;
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

namespace MemberAdmin.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Repository _repo;
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            btnNew.Click += BtnNew_Click;
            btnEdit.Click += BtnEdit_Click;
            btnCancle.Click += BtnCancle_Click;
            btnDelete.Click += BtnDelete_Click;
            _repo = Repository.GetInstance();
            lBoxMembers.ItemsSource = _repo.GetAll();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            _repo.Remove(lBoxMembers.SelectedItem as Person);

            lBoxMembers.ItemsSource = _repo.GetAll();
        }

        private void BtnCancle_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            AddAndEditWindow addAndEdit = new AddAndEditWindow(lBoxMembers.SelectedItem as Person);
            addAndEdit.ShowDialog();
            lBoxMembers.ItemsSource = _repo.GetAll();
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            AddAndEditWindow addAndEdit = new AddAndEditWindow(null);
            addAndEdit.ShowDialog();
            lBoxMembers.ItemsSource = _repo.GetAll();

        }
    }
}
