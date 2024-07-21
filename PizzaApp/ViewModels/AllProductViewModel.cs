namespace PizzaApp.ViewModels
{
    [QueryProperty(nameof(FromSearch), nameof(FromSearch))]
    public partial class AllProductViewModel : ObservableObject
    {
        private readonly PizzaServices _services;

        public AllProductViewModel(PizzaServices services)
        {
            _services = services;
            Pizzas = new ObservableCollection<Pizza>(_services.GetPopularPizzas());
        }

        [ObservableProperty]
        private bool fromSearch;

        [ObservableProperty]
        private bool searching;

        public ObservableCollection<Pizza> Pizzas { get; } = new ObservableCollection<Pizza>();

        [RelayCommand]
        private async Task SearchPizzas(string searchTerm)
        {
            Pizzas.Clear();
            Searching = true;
            await Task.Delay(1000);
            var pizzas = _services.SearchPizzas(searchTerm);
            foreach (var item in pizzas)
            {
                Pizzas.Add(item);
            }
            Searching = false;
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
