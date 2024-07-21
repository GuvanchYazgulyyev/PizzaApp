using CommunityToolkit.Mvvm.ComponentModel;
using PizzaApp.Models;
using PizzaApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        private readonly PizzaServices _pizzaServices;

        public HomeViewModel(PizzaServices pizzaServices)
        {
            _pizzaServices = pizzaServices;
            Pizzas = new(_pizzaServices.GetPopularPizzas());
        }
        public ObservableCollection<Pizza> Pizzas { get; set; }

        [RelayCommand]
        private async Task GToAllPizzasPage(bool fromSearch = false)
        {
            var parameters = new Dictionary<string, object>()
            {
                [nameof(AllProductViewModel.FromSearch)] = fromSearch
            };
            await Shell.Current.GoToAsync(nameof(AllProductPage), animate: true, parameters);
        }

        [RelayCommand]
        private async Task GoToDetailPage(Pizza pizza)
        {
            var parameters = new Dictionary<string, object>
            {
                [nameof(DetailProductPageViewModel.Pizza)] = pizza
            };
            await Shell.Current.GoToAsync(nameof(DetailProductPage), animate: true, parameters);
        }
    }
}
