public class StringWorker 
{
    public StringWorker() 
    {

    }

    public string Implode(string delimeter, params object?[] strings) 
    {
        return string.Join(delimeter, strings);
    }

    public string[] Explode(string strings, char delimeter)
    {
        return strings.Split(delimeter);
    }
}