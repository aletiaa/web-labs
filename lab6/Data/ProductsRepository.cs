public class ProductsRepository 
{
    private ShopContext _db;
    public ProductsRepository(ShopContext db)
    {
        _db = db;
    }

    public List<Product> Products
    { 
        get
        {
            return _db.Products.ToList(); // == select
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