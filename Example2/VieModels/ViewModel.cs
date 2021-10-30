using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            Customers = new ObservableCollection<Customer>() { };
            SelectedCustomer = new Customer();

            Customers.Add(new Customer(1, "Lamyaa", new ObservableCollection<Order>() { new Order(1, 5, 600.33) }));
            Customers.Add(new Customer(2, "Khalid", new ObservableCollection<Order>() { new Order(2, 10, 1200.66)}));
        }


        public ObservableCollection<Customer> Customers { get; set; }


        private Customer selectedCustomer;
        public Customer SelectedCustomer
        {
            get { return selectedCustomer; }
            set { selectedCustomer = value; OnPropertyChanged("SelectedCustomer"); }
        }


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
