namespace PizzaApp.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // sayfaya Yönlendirme
    async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
}
