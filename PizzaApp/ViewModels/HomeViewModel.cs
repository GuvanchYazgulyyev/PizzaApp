using CommunityToolkit.Mvvm.ComponentModel;
using PizzaApp.Models;
using PizzaApp.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PizzaApp.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        private readonly PizzaServices _pizzaServices;

        public HomeViewModel(PizzaServices pizzaServices)
        {
            _pizzaServices = pizzaServices;
            Pizzas = new ObservableCollection<Pizza>(_pizzaServices.GetPopularPizzas());

            // ICommand'ları manuel olarak tanımlıyoruz
            GoToDetailPageCommand = new Command<Pizza>(async (pizza) => await GoToDetailPage(pizza));
            GoToAllPizzasPageCommand = new Command(async () => await GoToAllPizzasPage());
        }

        public ObservableCollection<Pizza> Pizzas { get; set; }
        public ICommand GoToDetailPageCommand { get; }
        public ICommand GoToAllPizzasPageCommand { get; }

        private async Task GoToDetailPage(Pizza pizza)
        {
            var parameters = new Dictionary<string, object>
            {
                [nameof(DetailProductPageViewModel.Pizza)] = pizza
            };
            await Shell.Current.GoToAsync(nameof(DetailProductPage), animate: true, parameters);
        }

        private async Task GoToAllPizzasPage()
        {
            var parameters = new Dictionary<string, object>
            {
                [nameof(AllProductViewModel.FromSearch)] = false
            };
            await Shell.Current.GoToAsync(nameof(AllProductPage), animate: true, parameters);
        }
    }
}

















/////Eski Versiyonu Yukarıdakı kodu farklı geliştirdim 


//using CommunityToolkit.Mvvm.ComponentModel;
//using PizzaApp.Models;
//using PizzaApp.Services;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PizzaApp.ViewModels
//{
//    public partial class HomeViewModel : ObservableObject
//    {
//        private readonly PizzaServices _pizzaServices;

//        public HomeViewModel(PizzaServices pizzaServices)
//        {
//            _pizzaServices = pizzaServices;
//            Pizzas = new(_pizzaServices.GetPopularPizzas());
//        }
//        public ObservableCollection<Pizza> Pizzas { get; set; }

//        [RelayCommand]
//        private async Task GToAllPizzasPage(bool fromSearch = false)
//        {
//            var parameters = new Dictionary<string, object>()
//            {
//                [nameof(AllProductViewModel.FromSearch)] = fromSearch
//            };
//            await Shell.Current.GoToAsync(nameof(AllProductPage), animate: true, parameters);
//        }

//        [RelayCommand]
//        private async Task GoToDetailPage(Pizza pizza)
//        {
//            var parameters = new Dictionary<string, object>
//            {
//                [nameof(DetailProductPageViewModel.Pizza)] = pizza
//            };
//            await Shell.Current.GoToAsync(nameof(DetailProductPage), animate: true, parameters);
//        }
//    }
//}
