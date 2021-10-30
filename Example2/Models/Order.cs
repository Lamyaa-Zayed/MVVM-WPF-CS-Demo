using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class Order : INotifyPropertyChanged
    {
        public Order(int id, int count, double price)
        {
            ID = id;
            Count = count;
            Price = price;
        }
        
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; OnPropertyChanged("ID"); }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; OnPropertyChanged("Count"); }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged("Price"); }
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
