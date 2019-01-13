using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrAccounting.Model {
    public class Customer : INotifyPropertyChanged {
        private string name;
        private string company;
        private string address;
        private string city;
        private string zip;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }
        public string Company {
            get { return company; }
            set { company = value; OnPropertyChanged("Company"); }
        }
        public string Address {
            get { return address; }
            set { address = value; OnPropertyChanged("Address"); }
        }
        public string City {
            get { return city; }
            set { city = value; OnPropertyChanged("City"); }
        }
        public string Zip {
            get { return zip; }
            set { zip = value; OnPropertyChanged("Zip"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
