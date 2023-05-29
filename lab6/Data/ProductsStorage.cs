public class ProductsStorage 
{
    private ShopContext _db;
    public ProductsStorage(ShopContext db)
    {
        _db = db;

        // Product raspberryPie = new Product(1, "Малиновий мусовий тoрт", 1800);
        // Product applePie = new Product(2, "Яблуневий тарт з малиною та агрусом", 1300);
        // Product chocolatePie = new Product(3, "Мусовий торт з різними видами шоколаду", 1300);
        // Product strawberryChocoPie = new Product(4, "Шоколадний торт з полуничним джемом", 1800);
        // Product lemonBlueberryPie = new Product(5, "Лимонно-чорничний тарт з м'ятою та горіхами", 1800);

        // _products = new List<Product>();

        // _products.Add(raspberryPie);
        // _products.Add(applePie);
        // _products.Add(chocolatePie);
        // _products.Add(strawberryChocoPie);
        // _products.Add(lemonBlueberryPie);
    }

    public List<Product> Products
    { 
        get
        {
            return _db.Products.ToList();
        }
    }

    public void Add(Product product)
    {
        _db.Products.Add(product);
        _db.SaveChanges();
    }

    public void Remove(int id)
    {
        Product removeProduct = FindProduct(id);
        _db.Products.Remove(removeProduct);
        _db.SaveChanges();
    }

    public Product FindProduct(int id)
    {
        Product foundProduct = _db.Products.FirstOrDefault(product => product.ID == id);
        return foundProduct;
    }
}