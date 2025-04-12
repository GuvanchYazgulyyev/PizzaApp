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
                Price = 220,
                Description="Öncelikle hamur için mayayı bir bardaklık suya koyup karıştırın bekletin.\r\nTasa unu tuzu şekeri koyup karıştırın daha sonra bir çay bardağı yağı koyup az yoğurun ve sonra suyu azar azar koyarak yoğurun yumuşak kıvam alana kadar yoğurun ve beklemeye alın 20 dakika.\r\nEti tavaya alın suyunu bıraksın fakat kurutmayın.\r\nDaha sonra tereyağı ve zeytin yağını katın sarımsak ve domatesi koyun.\r\nİsteğe göre biber ve soğan da koyabilirsiniz , kavurun domates az diri kalsın çok pişirmeyin.",
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
                Price = 210,
                Description="hamuru üzerine nefis Sbarro pizza sosu, mozzarella peyniri, taze dilimlenmiş kırmızı ve yeşil biber, taze doğranmış mantar, küp kesilmiş taze domates, mısır, zeytin, beyaz küp peynir ve kekik! "
            },
            new Pizza
            {
                Name = "Eko Sucuklu Pizza",
                Image = "eko_sucuklu_pizza.png",
                Price = 270,
                Description="hamuru üzerine nefis Sbarro pizza sosu, mozzarella peyniri, sucuk ",
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
                Price = 200,
                Description="hamuru üzerine nefis Sbarro pizza sosu, mozzarella peyniri, kekik! ",
            },
            new Pizza
            {
                Name="White Pizza",
                Image="white_pizza.png",
                Price=250,
                Description="hamuru üzerine enfes ricotta sosu, mozzarella peyniri, romano peyniri ve maydanoz! "
            },
            new Pizza
            {
                Name="4 Peynirli Pizza",
                Image="peynirli_pizza.png",
                Price=280,
                Description="hamuru üzerine nefis Sbarro pizza sosu, krema, mozzarella peyniri, beyaz peynir, parmesan peyniri, susam, mayonez! ",
            },
            new Pizza
            {
                Name="Barbekü Tavuklu Pizza",
                Image="barbeku_tavuklu_pizza.png",
                Price=245,
                Description="hamuru üzerine nefis Sbarro pizza sosu, barbekü sos, mozzarella peyniri, soğan, mısır, tavuk döner, kekik! "
            },
            new Pizza
            {
                Name="Supreme Pizza",
                Image="supreme_pizza.png",
                Price=270,
                Description="hamuru üzerine nefis Sbarro pizza sosu, mozzarella peyniri, sosis, taze dilimlenmiş kırmızı ve yeşil biber, soğan, mantar ve özel tarifimize göre hazırlanmış pepperoni! ",
            },
              new Pizza
            {
                Name="Pepperoni Pizza",
                Image="pepperoni_pizza.png",
                Price=270,
                Description="hamuru üzerine nefis Sbarro pizza sosu, mozarella, pepperoni, kekik ",
            },
                 new Pizza
            {
                Name="Gennaro Pizza",
                Image="gennaro_pizza.png",
                Price=290,
                Description="hamuru üzerine nefis Sbarro pizza sosu, mozzarella peyniri, dilimlenmiş sucuk, marine mantar, mısır ve kekik!",
            },
                    new Pizza
            {
                Name="Ton Balıklı Pizza",
                Image="ton_balikli_pizza.png",
                Price=320,
                Description="hamuru üzerine nefis Sbarro pizza sosu, mozzarella peyniri, ton balığı, mısır ve marine edilmiş domates! ",
            },
                       new Pizza
            {
                Name="Sucuklu Favori Pizza",
                Image="sucuklu_stuffed_pizza.png",
                Price=370,
                Description="hamuru üzerine nefis Sbarro pizza sosu, mozzarella peyniri, sucuk, siyah zeytin, mısır!  ",
            },
                          new Pizza
            {
                Name="Etli Karışık Pizza",
                Image="etli_karisik_pizza.png",
                Price=390,
                Description="hamuru üzerine nefis Sbarro pizza sosu, mozzarella peyniri, sucuk, sosis, pepperoni, mısır, siyah zeytin ",
            },
            new Pizza
            {
                Name="Karışık Sosisli Pizza",
                Image="karisik_sosisli_pizza.png",
                Price=370,
                Description="hamuru üzerine nefis Sbarro pizza sosu, mozzarella peyniri, dilimlenmiş sosis, taze mantar, siyah zeytin, taze dilimlenmiş yeşil ve kırmızı biber! ",
            },
             new Pizza
            {
                Name="Sosis ve Pepperoni Stuffed Pizza",
                Image="sosis_ve_pepperoni_stuffed_pizza.png",
                Price=370,
                Description="hamuru arasında Mozzarella peyniri, sosis parçaları, özel tarifimize göre hazırlanmış pepperoni ve parmesan peyniri. ",
            },
            new Pizza
            {
                Name="Sucuklu Stuffed Pizza",
                Image="sucuklu_stuffed_pizza.png",
                Price=390,
                Description="hamuru arasında mozzarella peyniri, sucuk, siyah zeytin, kırmızı ve yeşil biber, acılı seçeneği ile! ",
            },
            new Pizza
            {
                Name="Supreme Stuffed Pizza",
                Image="supreme_stuffed_pizza.png",
                Price=380,
                Description="hamuru arasında mozzarella peyniri, özel tarifimize göre hazırlanmış pepperoni, parmesan peynir, soğan, mantar karışımı, kırmızı ve yeşil biber.",
            },
             new Pizza
            {
                Name="Sosisli Stromboli",
                Image="sosisli_stromboli.png",
                Price=180,
                Description="hamuru içinde sosis, nefis sütlü parmesan ve mozzarella peyniri! ",
            },
              new Pizza
            {
                Name="Pepperonili Stromboli",
                Image="pepperonili_stromboli.png",
                Price=190,
                Description="hamuru içinde özel tarifimize göre hazırlanmış pepperoni, parmesan ve mozzarella peyniri! ",
            },
            new Pizza
            {
                Name="Ispanaklı Stromboli",
                Image="ispanakli_stromboli.png",
                Price=190,
                Description="hamuru içinde mozzarella peyniri, parmesan peyniri ve ıspanak karışımı! ",
            },
            new Pizza
            {
                Name="Ayran Küçük",
                Image="ayran_200ml.png",
                Price=15,
                Description="Süt Ürünü",
            },
             new Pizza
            {
                Name="Ayran Büyük",
                Image="ayran_300ml.png",
                Price=25,
                Description="Süt Ürünü",
            },

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
