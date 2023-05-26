//inheritance ()
public class Mango : Fruit
{
    public Mango(string name, double price, int caliber) 
        :base(name, price)
    {
        Caliber = caliber;
    }

    public int Caliber { get;}

    public override string[] GetProducingCountries()
    {
        return new []
        {
             "Ecuador", 
             "India",
             "China", 
             "Thailand",
             "Pakistan",
             "Indonesia"
        };
    }

    /*
    after *sealed* applied to method 
    we can't override virtual/abstract methods._instance
     
    sealed can be applied to class 
    which means class cannot be inherited.
    */
    public override sealed string ToString()  
    {
        return $"Hi. This is Mango. My name is {Name}.";
    }


}