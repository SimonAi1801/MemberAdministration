using MahApps.Metro.Controls;
using MemberAdmin.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MemberAdmin.Wpf
{
    /// <summary>
    /// Interaction logic for AddAndEditWindow.xaml
    /// </summary>
    public partial class AddAndEditWindow : MetroWindow
    {
        private Person _person;
        private Repository _repo;
        public AddAndEditWindow(Person person)
        {
            InitializeComponent();
            Loaded += AddAndEditWindow_Loaded;
            _person = person;
        }

        private void AddAndEditWindow_Loaded(object sender, RoutedEventArgs e)
        {
            btnSave.Click += BtnSave_Click;
            btnCancle.Click += BtnCancle_Click;
            _repo = Repository.GetInstance();

            if (_person == null)
            {
                DataContext = new Person
                {
                    FirstName = "Bitte Vornamen eingeben!",
                    LastName = "Bitte Nachnamen eingeben!",
                    BirthDate = Convert.ToDateTime("01.01.2000"),
                    Belt = "Bitte Gurt eingeben!"
                };
            }
            else
            {
                DataContext = _person;
            }
        }

        private void BtnCancle_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (_person == null)
            {
                _repo.Add(DataContext as Person);
            }
            Close();
        }
    }
}
