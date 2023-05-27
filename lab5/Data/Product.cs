public class Product 
{
    public Product() {}
    public Product(int id, string name, double price)
    {
        ID = id;
        Price = price;
        Name = name;
    }

    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}