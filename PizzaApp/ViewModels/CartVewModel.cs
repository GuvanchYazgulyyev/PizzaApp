using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ViewModels
{
    /// <summary>
    /// Sepet sayfası işlemleri.
    /// </summary>
    public partial class CartVewModel : ObservableObject
    {
        public event EventHandler<Pizza> CartItemRemoved;
        public event EventHandler<Pizza> CartItemUpdated;
        public event EventHandler CartCleared;

        public ObservableCollection<Pizza> Items { get; set; } = new();
        [ObservableProperty]
        private double _totalAmount;
        private void RecalculateTotalAmount() => TotalAmount = Items.Sum(f => f.Amount);

        [RelayCommand]
        private void UpdateCartItem(Pizza pizza)
        {
            var item = Items.FirstOrDefault(h => h.Name == pizza.Name);
            if (item is not null)
            {
                item.CartQuantity = pizza.CartQuantity;
            }
            else
                Items.Add(pizza.Clone());
            RecalculateTotalAmount();
        }

        /// <summary>
        /// Sepetten Sil
        /// </summary>
        /// <param name="name"></param>
        [RelayCommand]
        private async void RemoveCartItem(string name)
        {
            var item = Items.FirstOrDefault(h => h.Name == name);
            if (item is not null)
            {
                Items.Remove(item);
                RecalculateTotalAmount();

                CartItemRemoved?.Invoke(this, item);

                var snackBarOptions = new SnackbarOptions
                {
                    CornerRadius = 10,
                    BackgroundColor = Colors.PaleGoldenrod
                };

                var snackBarr = Snackbar.Make($"'{item.Name}' isimli ürünü sepetten siliyorsun!",
                       () =>
                       {
                           Items.Add(item);
                           RecalculateTotalAmount();
                           CartItemUpdated?.Invoke(this, item);
                       }, "İptal Et", TimeSpan.FromSeconds(5), snackBarOptions);
                await snackBarr.Show();
            }
        }

        /// <summary>
        /// Sepet Temizlendiginide Uyarı ver!!!
        /// </summary>
        [RelayCommand]
        private async Task ClearCart()
        {
            if (await Shell.Current.DisplayAlert("Sepetin Temizlensin mi ?", "Sepeti Temizlemek İstediginiden Emin misin?", "Evet", "Hayır"))
            {
                Items.Clear();
                RecalculateTotalAmount();
                CartCleared?.Invoke(this, EventArgs.Empty);
                await Toast.Make("Sepet Temizlendi!", ToastDuration.Short).Show();
            }
        }

        [RelayCommand]
        private async Task PlaceOrder()
        {
            Items.Clear();

            CartCleared?.Invoke(this, EventArgs.Empty);

            RecalculateTotalAmount();
            // Kontrol Satfasına Git!

            await Shell.Current.GoToAsync(nameof(CheckOutPage), animate: true);
        }
    }
}
