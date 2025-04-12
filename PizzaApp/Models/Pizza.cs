
using CommunityToolkit.Mvvm.ComponentModel;

namespace PizzaApp.Models
{
    public partial class Pizza : ObservableObject
    {
        private string _name;
        private string _image;
        private double _price;
        private int _cartQuantity;
        private string _description;

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

        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
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
