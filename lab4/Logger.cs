public class Logger
{
    private static Logger _instance;

    private Logger() { }

    public static Logger Instance 
    {
         get 
         {
            if (_instance == null)
            {
                _instance = new Logger();
            }

            return _instance;
         }
    }

    public void Log(object data)
    {
        System.Console.WriteLine(data);
    }

    public void Log()
    {
        System.Console.WriteLine();
    }
}