using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class Customer : INotifyPropertyChanged
    {
        public Customer()
        {
            Orders = new ObservableCollection<Order>();
        }
        public Customer(int id, string name, ObservableCollection<Order> orders)
        {
            ID = id;
            Name = name;
            Orders = orders;
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; OnPropertyChanged("ID"); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public ObservableCollection<Order> Orders { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
