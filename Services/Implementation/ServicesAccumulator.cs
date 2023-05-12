namespace MultipleTimers.Services.Implementation;

public class ServicesAccumulator
{
    private readonly OriginalNotification _originalNotification;
    private readonly ReminderNotification _reminderNotification;

    public ServicesAccumulator()
    {
        _originalNotification = new OriginalNotification();
        _reminderNotification = new ReminderNotification();
    }

    public void TriggerService(ServicesList service)
    {
        switch (service)
        {
            case ServicesList.OriginalNotification:
                PublishDate();
                _originalNotification.NotifyUser();
                break;

            case ServicesList.ReminderNotification:
                PublishDate();
                _reminderNotification.NotifyUser();
                break;

            default:
                throw new ArgumentException("Usage of the service is unclear");
        }
    }

    private void PublishDate()
    {
        Console.Write("Publicasion date [{0}]: ", DateTime.Now);
    }
}
