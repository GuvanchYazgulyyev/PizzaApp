namespace PizzaApp.Pages;

public partial class CartPage : ContentPage
{
	private readonly CartVewModel _cartVewModel;
	public CartPage(CartVewModel cartVewModel)
	{
        _cartVewModel = cartVewModel;
		InitializeComponent();
		BindingContext = _cartVewModel;
	}

   async private void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(AllProductPage));
    }
}