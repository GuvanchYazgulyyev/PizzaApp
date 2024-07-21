using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
