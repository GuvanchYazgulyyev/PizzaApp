namespace PizzaApp.Pages
{
    public partial class AllProductPage : ContentPage
    {
        private readonly AllProductViewModel _allProductViewModel;

        public AllProductPage(AllProductViewModel allProductViewModel)
        {
            InitializeComponent();
            _allProductViewModel = allProductViewModel;
            BindingContext = _allProductViewModel;
        }

        /// <summary>
        /// Arama kýsmýný Odakla
        /// </summary>
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (_allProductViewModel.FromSearch)
            {
                await Task.Delay(100);
                searchBar.Focus();
            }

        }

        /// <summary>
        /// Arama Kýsmýnda Tüm Parametreleri Gönderirken Kontrol Et
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.OldTextValue) && string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                _allProductViewModel.SearchPizzasCommand.Execute(null);
            }
            else
            {
                _allProductViewModel.SearchPizzasCommand.Execute(e.NewTextValue);
            }
        }
    }
}
