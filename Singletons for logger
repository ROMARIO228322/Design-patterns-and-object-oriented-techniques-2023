using System;

// I made the Logger class so that it can't be extended by other classes.
// You can only have one Logger, and it stops anyone from making a new one accidentally.

public sealed class Logger
{
    // I made a special spot to keep the one and only Logger.
    private static Logger _instance;

    // I made a rule that only the Logger can make a Logger.
    private Logger()
    {
    }

    // I made a way for you to get the one and only Logger.
    public static Logger GetInstance()
    {
        // If there isn't a Logger yet, I'll make one. Otherwise, I'll give you the one that already exists.
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    // This is how you can tell the Logger to write something down.
    public void Log(string message)
    {
        // I'm telling the computer to show your message on the screen, like a note.
        Console.WriteLine($"[Log]: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // I'm getting the Logger so I can use it.
        Logger logger = Logger.GetInstance();
        
        // I'm telling the Logger to write a message.
        logger.Log("This is a log message from the Logger.");

        // I'm checking if the Logger I got before is the same one I get now. 
        Logger anotherLogger = Logger.GetInstance();
        // If they are the same, I'll tell you.
        Console.WriteLine($"Are logger and anotherLogger the same instance? {ReferenceEquals(logger, anotherLogger)}");
    }
}
