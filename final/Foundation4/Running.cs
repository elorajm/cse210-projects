using System;

// Represents a Running activity, inheriting from the base Activity class.
public class Running : Activity
{
    // Private field specific to Running: distance covered.
    private double _distance; // Distance is stored in km

    // Constructor for Running.
    // Takes date, duration, and distance as input.
    // Calls the base class constructor using 'base(...)'.
    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes) // Pass date and minutes to the Activity constructor
    {
        _distance = distance;
    }

    // Override abstract methods from the Activity base class.

    /// <summary>
    /// Returns the stored distance.
    /// </summary>
    /// <returns>Distance in km.</returns>
    public override double GetDistance()
    {
        return _distance;
    }

    /// <summary>
    /// Calculates speed based on distance and duration.
    /// Speed (kph) = (Distance (km) / Time (min)) * 60 (min/hr)
    /// </summary>
    /// <returns>Speed in kph.</returns>
    public override double GetSpeed()
    {
        // Avoid division by zero if length is 0.
        if (LengthInMinutes == 0) return 0;
        return (_distance / LengthInMinutes) * 60.0;
    }

    /// <summary>
    /// Calculates pace based on duration and distance.
    /// Pace (min/km) = Time (min) / Distance (km)
    /// </summary>
    /// <returns>Pace in min/km.</returns>
    public override double GetPace()
    {
        // Avoid division by zero if distance is 0.
        if (_distance == 0) return 0;
        return LengthInMinutes / _distance;
    }

    // Override the GetSummary method to provide a running-specific title.
    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Running ({LengthInMinutes} min): " +
               $"Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
               // Using :F2 for 2 decimal places formatting.
    }
}