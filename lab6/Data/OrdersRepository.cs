public class OrdersRepository 
{
    private ShopContext _db;
    public OrdersRepository(ShopContext db)
    {
        _db = db;
    }

    public void AddProduct(int productId)
    {
        Order currentOrder = new Order();
        
    }

    // public void Remove(int id)
    // {
    //     Product removeProduct = FindProduct(id);
    //     _db.Products.Remove(removeProduct);
    //     _db.SaveChanges();
    // }

    // public Product FindProduct(int id)
    // {
    //     Product foundProduct = _db.Products.FirstOrDefault(product => product.ID == id);
    //     return foundProduct;
    // }
}