using System;

// Represents a Swimming activity, inheriting from the base Activity class.
public class Swimming : Activity
{
    // Private field specific to Swimming: number of laps completed.
    private int _laps;

    // Constant defining the length of one lap in meters.
    private const double MetersPerLap = 50.0;

    // Constructor for Swimming.
    // Takes date, duration, and number of laps as input.
    // Calls the base class constructor using 'base(...)'.
    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes) // Pass date and minutes to the Activity constructor
    {
        _laps = laps;
    }

    // Override abstract methods from the Activity base class.

    /// <summary>
    /// Calculates distance based on the number of laps.
    /// Assumes each lap is 50 meters. Converts total meters to kilometers.
    /// </summary>
    /// <returns>Distance in km.</returns>
    public override double GetDistance()
    {
        // Distance (km) = (Laps * Meters_per_Lap) / 1000 (m/km)
        return (_laps * MetersPerLap) / 1000.0;
    }

    /// <summary>
    /// Calculates speed based on distance (from laps) and duration.
    /// Speed (kph) = (Distance (km) / Time (min)) * 60 (min/hr)
    /// </summary>
    /// <returns>Speed in kph.</returns>
    public override double GetSpeed()
    {
        double distance = GetDistance(); // Calculate distance first
        // Avoid division by zero if length is 0.
        if (LengthInMinutes == 0) return 0;
        return (distance / LengthInMinutes) * 60.0;
    }

    /// <summary>
    /// Calculates pace based on duration and distance (from laps).
    /// Pace (min/km) = Time (min) / Distance (km)
    /// </summary>
    /// <returns>Pace in min/km.</returns>
    public override double GetPace()
    {
        double distance = GetDistance(); // Calculate distance first
        // Avoid division by zero if distance is 0.
        if (distance == 0) return 0;
        return LengthInMinutes / distance;
    }

    // Override the GetSummary method to provide a swimming-specific title.
    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Swimming ({LengthInMinutes} min): " +
               $"Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
               // Using :F2 for 2 decimal places formatting.
    }
}