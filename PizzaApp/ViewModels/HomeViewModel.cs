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
    }
}
