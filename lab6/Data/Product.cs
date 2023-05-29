public class Product 
{
    public Product() 
    {
        this.Orders = new List<Order>();
    }
 
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public virtual List<Order> Orders { get; set; }
}