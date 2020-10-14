using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Dynamic;
using System.Text;

namespace Data
{
    public class Order : ICollection, INotifyPropertyChanged, INotifyCollectionChanged
    {
        /// <summary>
        /// establishes needed events and global variables
        /// some of this is unfinished as I don't understand exactly how to impliment it
        /// </summary>
        public IOrderItem[] OrderArray;
        public event CollectionChangeEventHandler CollectChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public virtual CollectionChangeAction C_Action { get; }
        
        /// <summary>
        /// Invoking methods for events of collection and property changes
        /// </summary>
        /// <param name="name"></param>
        private void OnCollectChanged([CallerMemberName] string name = "")
        {
            CollectChanged?.Invoke(this, new CollectionChangeEventArgs(C_Action, this));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            OnCollectChanged(name);
        }

        /// <summary>
        /// Implimentation of global variables
        /// all setters invoke OnPropertyChange
        /// </summary>
        public List<IOrderItem> currentOrder;
        private int OrderNumber = 1;
        public int orderNumber {
            get
            {
                return OrderNumber;
            }

            set
            {
                OrderNumber = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Logic for generating Calories, SubTotal, Tax and Total are handled at time of get function being called
        /// The main leader of items currentOrder contains all IOrderItems for the current order and is cycled through at the time the variable is called
        /// </summary>
        private uint calories = 0;
        public uint Calories
        {
            get
            {
                calories = 0;
                foreach (IOrderItem x in currentOrder)
                {
                    calories += x.Calories;
                }
                return calories;
            }
        }
        private double salesTaxRate = .12;
        public double SalesTaxRate {
            get
            {
                return salesTaxRate;
            }

            set
            {
                salesTaxRate = value;
                OnPropertyChanged();
            }
        }

        private double subtotal = 0.0;
        public double Subtotal 
        {
            get
            {
                subtotal = 0.0;
                foreach(IOrderItem x in currentOrder)
                {
                   subtotal += x.Price;
                }
                return subtotal;
            }
        }

        private double tax = 0.0;
        public double Tax
        {
            get
            {
                tax = 0.0;
                tax = SalesTaxRate * Subtotal;
                return Math.Round(tax, 2);
            }
        }

        private double total = 0.0;
        public double Total
        {
            get
            {
                total = 0.0;
                total = Subtotal + Tax;
                return Math.Round(total, 2);
            }
        }

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        /// <summary>
        /// Initial constructor
        /// </summary>
        /// <param name="_number"></param>
        public Order(int _number)
        { 
            currentOrder = new List<IOrderItem>();
            OrderNumber = _number;
        }

        /// <summary>
        /// Adds supplied item, in this case an object of any IOrderItem type and adds it to the current instance of the object
        /// </summary>
        /// <param name="_item"></param>
        public void Add(IOrderItem _item)
        {
            currentOrder.Add(_item);
            OnPropertyChanged();
        }

        /// <summary>
        /// removes supplied IOrderItem from the current instance of the object
        /// this logic is primarily handled front end but the functionality works
        /// </summary>
        /// <param name="_item"></param>
        public void Remove(IOrderItem _item)
        {
            for (int i = 0; i < currentOrder.Count; i++)
            {
                if (currentOrder[i].Equals(_item))
                {
                    currentOrder.RemoveAt(i);
                }
            }
            OnPropertyChanged();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
