using System;
using System.Collections.Generic;
using System.Text;
using MvvmSQLiteExample.Model;
using Xamarin.Forms;
using SQLite;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MvvmSQLiteExample.ViewModel
{
    public class MainpageViewModel : INotifyPropertyChanged
    {
        SQLiteConnection conn;
        public MainpageViewModel()
        {
            conn = DependencyService.Get<ISqliteConnection>().GetConnection();
            addtable();
            _btnlogin = new Command(GetCommand);


            Getdetails();
            //OnPropertyChanged();

        }
        private ICommand _btnlogin;
        public ICommand btnlogin
        {
            set
            {
                _btnlogin = value;
            }
            get
            {
                return _btnlogin;
            }
        }
        private void GetCommand()
        {

            Employee employee = new Employee();
            employee.Emplid = 1;
            employee.Emplname = etempname;
            employee.EmplAddress = etempaddress;
            int i = conn.Insert(employee);
            if (i > 0)
            {

                App.Current.MainPage.DisplayAlert("App emp", "Employee record added sucessfully", "ok");
                Getdetails();
            }
            else
            {
                App.Current.MainPage.DisplayAlert("App emp", "Employee record added failed,please try again", "ok");
            }


        }
        private void Getdetails()
        {
            var empdata = conn.Table<Employee>().ToList();
            _lstemplist = empdata;
            OnPropertyChanged("lstemplist");
        }

        private Employee _lstitems;
        public Employee lstitems
        {
            set
            {
                _lstitems = value;

            }
            get { return _lstitems; }

        }



        private List<Employee> _lstemplist;
        public List<Employee> lstemplist
        {
            set
            {
                _lstemplist = value;
            }
            get
            {
                return _lstemplist;
            }
        }

        private string _etempname;
        public string etempname
        {
            set
            {
                _etempname = value;
            }
            get
            {
                return _etempname;
            }
        }

        private string _etempaddress;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public string etempaddress
        {
            set
            {
                _etempaddress = value;
            }
            get
            {
                return _etempaddress;
            }
        }


        private void addtable()
        {
            conn.CreateTable<Employee>();

        }
    }
}
