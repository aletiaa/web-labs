public class ShopDbInitializer
{
    public static void Seed(IApplicationBuilder builder)
    {
        using (var serviceScope = builder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<ShopContext>();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product() { Price = 2800, Name = "Полунично-ванільний торт з макарунами"},
                    new Product() { Price = 2300, Name = "Торт з баварським кремом та полуницею"},
                    new Product() { Price = 2250, Name = "Малиново-ванільний торт з марципаном"},
                    new Product() { Price = 1700, Name = "Торт із заварни кремом та карамеллю"},
                    new Product() { Price = 2300, Name = "Моркв'яно-горіховий торт з апельсином"},
                    new Product() { Price = 1800, Name = "Малиновий мусовий торт"},
                    new Product() { Price = 1800, Name = "Лимонно-чорничний тарт з м'ятою та горіхами"},
                    new Product() { Price = 1650, Name = "Лимоно-лаймовий тарт з м'якоттю та кокосом"},
                    new Product() { Price = 1300, Name = "Яблуневий тарт з малиною та агрусом"},
                    new Product() { Price = 1300, Name = "Мусовий торт з різнии видами шоколаду"},
                    new Product() { Price = 1100, Name = "Тарт-чизкейк з карамеллю та листовим тістом"},
                    new Product() { Price = 1800, Name = "Шоколадний торт з полуничним джемом"}
                );

                context.SaveChanges();
            }
        }
    }
}