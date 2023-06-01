public class Order
{
     public Order()
    {
        this.OrdersProducts = new List<OrderProduct>();
    }

    public int Id { get; set;}
    public string PhoneNumber { get; set;}
    public string Comment { get; set;}
    public DateTime CreationDate { get; set; }
    public string FullName { get; set; }

    public List<OrderProduct> OrdersProducts { get; set;}
}

