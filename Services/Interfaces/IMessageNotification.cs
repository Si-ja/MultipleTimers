namespace MultipleTimers.Services.Interfaces;

public interface IMessageNotification
{
    /// <summary>
    /// An update message in the console environment should be raised.
    /// </summary>
    public void NotifyUser();
}
