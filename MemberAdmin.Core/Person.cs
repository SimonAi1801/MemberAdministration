using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MemberAdmin.Core
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _belt;
        private DateTime _birthDate;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                OnPropertyChanged(_firstName);
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                OnPropertyChanged(_lastName);
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
                OnPropertyChanged(_birthDate.ToString());
            }
        }


        public string Belt 
        { 
            get 
            {
                return _belt;
            }
            set 
            {
                _belt = value;
                OnPropertyChanged(_belt);
            }
        }

        public string FullName
        {
            get
            {
                OnPropertyChanged($"{_firstName} {_lastName}");
                return $"{_firstName} {_lastName}";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
