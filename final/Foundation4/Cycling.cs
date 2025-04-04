using System;

// Represents a Cycling activity, inheriting from the base Activity class.
public class Cycling : Activity
{
    // Private field specific to Cycling: average speed.
    private double _speed; // Speed is stored in kph

    // Constructor for Cycling.
    // Takes date, duration, and speed as input.
    // Calls the base class constructor using 'base(...)'.
    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes) // Pass date and minutes to the Activity constructor
    {
        _speed = speed;
    }

    // Override abstract methods from the Activity base class.

    /// <summary>
    /// Calculates distance based on speed and duration.
    /// Distance = (Speed * Time_in_hours)
    /// </summary>
    /// <returns>Distance in km.</returns>
    public override double GetDistance()
    {
        // Convert minutes to hours by dividing by 60.
        return (_speed * LengthInMinutes) / 60.0;
    }

    /// <summary>
    /// Returns the stored average speed.
    /// </summary>
    /// <returns>Speed in kph.</returns>
    public override double GetSpeed()
    {
        return _speed;
    }

    /// <summary>
    /// Calculates pace based on speed.
    /// Pace (min/km) = 60 / Speed (km/hr)
    /// </summary>
    /// <returns>Pace in min/km.</returns>
    public override double GetPace()
    {
        // Avoid division by zero if speed is 0.
        if (_speed == 0) return 0;
        return 60.0 / _speed;
    }

    // Override the GetSummary method to provide a cycling-specific title,
    // although the base class virtual method could also achieve this dynamically.
    // This override ensures the type is explicitly stated as "Cycling".
    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Cycling ({LengthInMinutes} min): " +
               $"Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
               // Using :F2 for 2 decimal places formatting.
    }
}