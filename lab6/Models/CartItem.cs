public class CartItem
{
    public CartItem(int productId, string productName, double price, int quantity)
    {
        ProductId = productId;
        Quantity = quantity;
        ProductName = productName;
        Price = price;
    }

    public int ProductId { get; }
    public string ProductName { get; }
    public double Price { get; }
    public int Quantity { get; private set; }

    public void IncreaseQuantity()
    {
        Quantity++;
    }
}