
using CommunityToolkit.Mvvm.ComponentModel;

namespace PizzaApp.Models
{
    public partial class Pizza : ObservableObject
    {
        private string _name;
        private string _image;
        private double _price;
        private int _cartQuantity;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Image
        {
            get => _image;
            set => SetProperty(ref _image, value);
        }

        public double Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }

        public int CartQuantity
        {
            get => _cartQuantity;
            set
            {
                SetProperty(ref _cartQuantity, value);
                OnPropertyChanged(nameof(Amount)); // Notify for the calculated property
            }
        }

        public double Amount => CartQuantity * Price;

        public Pizza Clone() => MemberwiseClone() as Pizza;
    }
}
