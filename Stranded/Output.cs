namespace Stranded
{
    public class Output
    {
        public void error (string message)
        {
            say(message, ConsoleColor.Red);
        }

        public void message (string message)
        {
            say(message, ConsoleColor.Blue);
        }

        public void action (string message)
        {
            say(message, ConsoleColor.Green);
        }

        public void notification (string message)
        {
            say(message, ConsoleColor.Yellow);
        }

        public void say (string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
