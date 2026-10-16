
using System;
using System.ComponentModel;

namespace DeviceManager
{
    public class Device : INotifyPropertyChanged
    {
        public string DeviceId { get; set; } = string.Empty;

        private string deviceName = string.Empty;
        public string DeviceName
        {
            get => deviceName;
            set
            {
                if (deviceName != value)
                {
                    deviceName = value;
                    OnPropertyChanged(nameof(DeviceName));
                }
            }
        }

        private string category = string.Empty;
        public string Category
        {
            get => category;
            set
            {
                if (category != value)
                {
                    category = value;
                    OnPropertyChanged(nameof(Category));
                }
            }
        }

        private decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPropertyChanged(nameof(Price));
                }
            }
        }

        private int quantity;
        public int Quantity
        {
            get => quantity;
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    OnPropertyChanged(nameof(Quantity));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
