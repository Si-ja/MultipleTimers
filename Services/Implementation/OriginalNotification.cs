using MultipleTimers.Services.Interfaces;

namespace MultipleTimers.Services.Implementation;

public class OriginalNotification : IMessageNotification
{
    private readonly ConsoleColor _bgColor;
    private readonly ConsoleColor _textColor;

    public OriginalNotification(
        ConsoleColor? bgColor = null,
        ConsoleColor? textColor = null)
    {
        _bgColor = bgColor ?? ConsoleColor.Black;
        _textColor = textColor ?? ConsoleColor.Green;
    }

    public void NotifyUser()
    {
        ConsoleModifier.CustomConsole(_bgColor, _textColor);
        Console.WriteLine(Settings.Messages.WelcomeMessage);
        ConsoleModifier.DefaultConsole();
    }
}
