public class OrdersRepository 
{
    private ShopContext _db;
    private ProductsRepository _productsRepository;
    public OrdersRepository(ShopContext db,  ProductsRepository productsRepository)
    {
        _db = db;
        _productsRepository = productsRepository;
    }

    public void CreateOrder(Order order)
    {
        var allItems = Cart.Instance.GetAllItems();
        order.CreationDate = DateTime.Now;
        
        foreach (var item in allItems)
        {
            var productId = item.ProductId;
            Product product = _productsRepository.FindProduct(productId);

            for (int i = 0; i < item.Quantity; i++)
            {
                order.Products.Add(product);
            }
        }
        
        _db.Orders.Add(order);
        _db.SaveChanges();
    }
}