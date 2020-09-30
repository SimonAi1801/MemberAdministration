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
    public partial class AddAndEditWindow : Window
    {
        private Person _person;
        public AddAndEditWindow(Person person)
        {
            InitializeComponent();
            _person = person;
        }
    }
}
