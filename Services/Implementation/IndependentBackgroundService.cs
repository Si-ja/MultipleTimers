using Microsoft.Extensions.Hosting;

namespace MultipleTimers.Services.Implementation;

public class IndependentBackgroundService : IHostedService, IDisposable
{
    private readonly ReminderNotification _reminderNotification;
    private Timer? _timer = null;

    public IndependentBackgroundService()
    {
        _reminderNotification = new ReminderNotification();
    }

    private void TimerEventProxy(object? state)
    {
        _reminderNotification.NotifyUser();
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(
            TimerEventProxy,
            null,
            TimeSpan.Zero,
            TimeSpan.FromSeconds(Settings.Time.DelayDoubleSeconds / 2));

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);

        return Task.CompletedTask;
    }

    public void Dispose() => _timer?.Dispose();
}
