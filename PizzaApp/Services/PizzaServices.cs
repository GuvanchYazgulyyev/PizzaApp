using PizzaApp.Models;

namespace PizzaApp.Services
{
    public class PizzaServices
    {
        private static readonly IEnumerable<Pizza> _pizzas = new List<Pizza>
        {
            new Pizza
            {
                Name = "Gamer Pizza",
                Image = "gamer_pizza.png",
                Price = 220
            },
            new Pizza
            {
                Name = "Gennaro Pizza",
                Image = "gennaro_pizza.png",
                Price = 240
            },
            new Pizza
            {
                Name = "Akdeniz Pizza",
                Image = "akdeniz_pizza.png",
                Price = 210
            },
            new Pizza
            {
                Name = "Eko Sucuklu Pizza",
                Image = "eko_sucuklu_pizza.png",
                Price = 270
            },
            new Pizza
            {
                Name = "Etli Karışık Pizza",
                Image = "etli_karisik_pizza.png",
                Price = 370
            },
            new Pizza
            {
                Name = "Mantarlı Pizza",
                Image = "mantarli_pizza.png",
                Price = 200
            }
        };

        /// <summary>
        /// Tüm pizzaları listeler.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Pizza> GetAllPizzas() => _pizzas;

        /// <summary>
        /// Popüler pizzaları listeler.
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public IEnumerable<Pizza> GetPopularPizzas(int count = 6) => _pizzas.OrderBy(p => Guid.NewGuid()).Take(count);

        /// <summary>
        /// Pizzaları arar ve filtreler.
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public IEnumerable<Pizza> SearchPizzas(string search) =>
            string.IsNullOrEmpty(search)
                ? _pizzas
                : _pizzas.Where(f => f.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
    }
}
