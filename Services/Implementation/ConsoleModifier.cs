namespace MultipleTimers.Services.Implementation;

public static class ConsoleModifier
{
    public static void DefaultConsole()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void CustomConsole(
        ConsoleColor backgroundColor,
        ConsoleColor textColor)
    {
        Console.BackgroundColor = backgroundColor;
        Console.ForegroundColor = textColor;
    }
}
