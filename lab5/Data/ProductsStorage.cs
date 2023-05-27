public class ProductsStorage 
{
    private List<Product> _products;
    private static ProductsStorage _instance;

    private ProductsStorage()
    {
        Product raspberryPie = new Product(1, "Малиновий мусовий тoрт", 1800);
        Product applePie = new Product(2, "Яблуневий тарт з малиною та агрусом", 1300);
        Product chocolatePie = new Product(3, "Мусовий торт з різними видами шоколаду", 1300);
        Product strawberryChocoPie = new Product(4, "Шоколадний торт з полуничним джемом", 1800);
        Product lemonBlueberryPie = new Product(5, "Лимонно-чорничний тарт з м'ятою та горіхами", 1800);

        _products = new List<Product>();

        _products.Add(raspberryPie);
        _products.Add(applePie);
        _products.Add(chocolatePie);
        _products.Add(strawberryChocoPie);
        _products.Add(lemonBlueberryPie);
    }

    public static ProductsStorage Instance
    {
        get 
        {
            if (_instance == null)
            {
                _instance = new ProductsStorage();
            }
            
            return _instance;
        }
    }

    public List<Product> Products
    { 
        get
        {
            return _products;
        }
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Remove(int id)
    {
        Product removeProduct = FindProduct(id);
        _products.Remove(removeProduct); 
    }

    public Product FindProduct(int id)
    {
        Product foundProduct = _products.Find(product => product.ID == id);
        return foundProduct;
    }
}