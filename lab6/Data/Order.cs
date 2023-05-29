public class Order
{
     public Order()
    {
        this.Products = new List<Product>();
    }

    public int Id { get; set;}
    public string PhoneNumber { get; set;}
    public string Comment { get; set;}
    public DateTime CreationDate { get; set; }

    public virtual List<Product> Products { get; set;}
}

