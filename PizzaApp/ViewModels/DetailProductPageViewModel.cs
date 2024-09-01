using Toast = CommunityToolkit.Maui.Alerts.Toast;

namespace PizzaApp.ViewModels
{
    [QueryProperty(nameof(Pizza), nameof(Pizza))]
    public partial class DetailProductPageViewModel : ObservableObject
    {
        public DetailProductPageViewModel()
        {

        }

        [ObservableProperty]
        private Pizza _pizza;

        //Sepete Ekle
        [RelayCommand]
        private void AddToCart()
        {
            Pizza.CartQuantity++;
        }
        // sepetten Çıkar
        [RelayCommand]
        private void RemoveFromCart()
        {
            if (Pizza.CartQuantity > 0)
                Pizza.CartQuantity--;
        }

        //Sepeti Gör
        [RelayCommand]
        private async Task ViewCart()
        {
            if (Pizza.CartQuantity > 0)
            {
                // Veri Gir
            }
            else
            {
                await Toast.Make("Lütfen Miktar Giriniz!", ToastDuration.Short).Show();
            }
        }
    }
}
