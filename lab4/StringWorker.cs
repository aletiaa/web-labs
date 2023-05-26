public static class StringWorker 
{
    public static string Implode(string delimeter, params object?[] strings) 
    {
        return string.Join(delimeter, strings);
    }

    public static string[] Explode(string strings, char delimeter)
    {
        return strings.Split(delimeter);
    }
}