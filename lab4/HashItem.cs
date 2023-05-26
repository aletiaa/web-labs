public class HashItem : object
{
    public HashItem(int value)
    {
        Value = value;    
    }

    public int Value { get; }

    public override bool Equals(Object obj)
    {
       if (obj == null || ! (obj is HashItem))
          return false;
       else
          return GetHashCode() == ((HashItem) obj).GetHashCode();
    }

    public override int GetHashCode()
        {
            return Value * 2;
        }
}