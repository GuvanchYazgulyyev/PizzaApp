using Microsoft.Maui.Controls;
#if IOS
using UIKit;
#endif

namespace PizzaApp.Pages
{
    public partial class DetailProductPage : ContentPage
    {
        private readonly DetailProductPageViewModel _detailProductPageViewModel;

        public DetailProductPage(DetailProductPageViewModel detailProductPageViewModel)
        {
            _detailProductPageViewModel = detailProductPageViewModel;
            InitializeComponent();
            BindingContext = _detailProductPageViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AdjustSafeArea();
        }

        private void AdjustSafeArea()
        {
#if IOS
            var bottom = UIApplication.SharedApplication.KeyWindow.SafeAreaInsets.Bottom;
            bottomBox.Margin = new Thickness(-1, 0, -1, (bottom + 1) * -1);
#endif
        }

        async private void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..", animate: true);
        }
        protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
        {
            base.OnNavigatedFrom(args);
            Behaviors.Add(new CommunityToolkit.Maui.Behaviors.StatusBarBehavior
            {
                StatusBarColor = Colors.DarkGoldenrod,
                StatusBarStyle = CommunityToolkit.Maui.Core.StatusBarStyle.LightContent
            });
        }
    }
}
