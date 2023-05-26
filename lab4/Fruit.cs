    //class (+)
    public abstract class Fruit 
    {
        protected Fruit(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }

        public double Price { get; }

        public string GetDetails() 
        {
            // string concatenation (+)
            return Name + " costs " + Price + " UAH"; 
        }

        public abstract string[] GetProducingCountries();
    }
