namespace MultipleTimers.Settings;

/// <summary>
/// All actions and events are delayed by the magnitude of 10 by default.
/// </summary>
public static class Time
{
    public static double DelayDoubleSeconds { get; } = 10;

    public static int DelayIntSeconds { get; } = 10;
}
