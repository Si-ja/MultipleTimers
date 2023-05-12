using MultipleTimers.Services.Interfaces;

namespace MultipleTimers.Services.Implementation;

public class OriginalNotification : IMessageNotification
{
    private readonly ConsoleColor _bgColor;
    private readonly ConsoleColor _textColor;

    private readonly ConsoleColor _defaultBgColor;
    private readonly ConsoleColor _defaultTextColor;

    public OriginalNotification(
        ConsoleColor? bgColor = null,
        ConsoleColor? textColor = null)
    {
        _bgColor = bgColor ?? ConsoleColor.Black;
        _textColor = textColor ?? ConsoleColor.Green;

        _defaultBgColor = ConsoleColor.Black;
        _defaultTextColor = ConsoleColor.White;
    }

    public void NotifyUser()
    {
        RePrepareTheConsoleColor();
        Console.WriteLine(Settings.Messages.WelcomeMessage);
        ReSetTheConsoleColor();
    }

    private void RePrepareTheConsoleColor()
    {
        Console.BackgroundColor = _bgColor;
        Console.ForegroundColor = _textColor;
    }

    private void ReSetTheConsoleColor()
    {
        Console.BackgroundColor = _defaultBgColor;
        Console.ForegroundColor = _defaultTextColor;
    }
}
