using MultipleTimers.Services.Interfaces;

namespace MultipleTimers.Services.Implementation;

public class ReminderNotification : IMessageNotification
{
    private readonly ConsoleColor _bgColor;
    private readonly ConsoleColor _textColor;

    public ReminderNotification(
        ConsoleColor? bgColor = null,
        ConsoleColor? textColor = null)
    {
        _bgColor = bgColor ?? ConsoleColor.Black;
        _textColor = textColor ?? ConsoleColor.Red;
    }

    public void NotifyUser()
    {
        ConsoleModifier.CustomConsole(_bgColor, _textColor);
        Console.WriteLine(Settings.Messages.DailyReminder);
        ConsoleModifier.DefaultConsole();
    }
}
