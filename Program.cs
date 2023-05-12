using MultipleTimers.Services;
using MultipleTimers.Services.Implementation;

namespace MultipleTimers;

public class Program
{
    static void Main(string[] args)
    {
        // Initialize the application
        var services = new ServicesAccumulator();
        
        var backgroundService = new IndependentBackgroundService();
        backgroundService.StartAsync(CancellationToken.None);

        // Perform several main actions
        Thread.Sleep(Settings.Time.DelayIntSeconds * 1000);
        services.TriggerService(ServicesList.OriginalNotification);

        Thread.Sleep(Settings.Time.DelayIntSeconds * 1000);
        services.TriggerService(ServicesList.ReminderNotification);

        Thread.Sleep(Settings.Time.DelayIntSeconds * 1000);
        services.TriggerService(ServicesList.ReminderNotification);

        Thread.Sleep(Settings.Time.DelayIntSeconds * 1000);
        services.TriggerService(ServicesList.ReminderNotification);
    }
}