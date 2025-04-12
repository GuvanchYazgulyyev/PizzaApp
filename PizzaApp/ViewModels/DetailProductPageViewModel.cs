using Toast = CommunityToolkit.Maui.Alerts.Toast;

namespace PizzaApp.ViewModels
{
    [QueryProperty(nameof(Pizza), nameof(Pizza))]
    public partial class DetailProductPageViewModel : ObservableObject, IDisposable
    {
        private readonly CartVewModel _cartVewModel;
        public DetailProductPageViewModel(CartVewModel cartVewModel)
        {
            _cartVewModel = cartVewModel;
            _cartVewModel.CartCleared += OnCardCleared;
            _cartVewModel.CartItemRemoved += OnCartItemRemoved;
            _cartVewModel.CartItemUpdated += OnCartItemUpdated;
        }

        private void OnCardCleared(object? sender, EventArgs e) => Pizza.CartQuantity = 0;
        private void OnCartItemRemoved(object? _, Pizza p) => OnCartItemChanged(p, 0);
        private void OnCartItemUpdated(object? _, Pizza p) => OnCartItemChanged(p, p.CartQuantity);
        private void OnCartItemChanged(Pizza p, int quantity)
        {
            if (p.Name == Pizza.Name)
                Pizza.CartQuantity = quantity;
        }

        [ObservableProperty]
        private Pizza _pizza;

        //Sepete Ekle
        [RelayCommand]
        private void AddToCart()
        {
            Pizza.CartQuantity++;
            _cartVewModel.UpdateCartItemCommand.Execute(Pizza);
        }
        // sepetten Çıkar
        [RelayCommand]
        private void RemoveFromCart()
        {
            if (Pizza.CartQuantity > 0)
            {
                Pizza.CartQuantity--;
                _cartVewModel.UpdateCartItemCommand.Execute(Pizza);
            }
        }

        //Sepeti Gör
        [RelayCommand]
        private async Task ViewCart()
        {
            if (Pizza.CartQuantity > 0)
            {
                // Veri varsa Sepet sayfasına Git!
                await Shell.Current.GoToAsync(nameof(CartPage), animate: true);
            }
            else
            {
                await Toast.Make("Lütfen Miktar Giriniz!", ToastDuration.Short).Show();
            }
        }

        public void Dispose()
        {
            _cartVewModel.CartCleared -= OnCardCleared;
            _cartVewModel.CartItemRemoved -= OnCartItemRemoved;
            _cartVewModel.CartItemUpdated -= OnCartItemUpdated;
        }
    }
}
