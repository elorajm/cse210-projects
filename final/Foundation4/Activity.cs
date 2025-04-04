using System;

// Abstract base class representing a generic physical activity.
// Cannot be instantiated directly, must be inherited by specific activity types.
public abstract class Activity
{
    // Private fields to store common activity data.
    private DateTime _date;
    private int _lengthInMinutes;

    // Constructor for the base Activity class.
    // Initializes the date and duration of the activity.
    // Called by constructors in derived classes.
    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // Public properties to access the private fields (read-only).
    // Using expression-bodied syntax for brevity.
    public DateTime Date => _date;
    public int LengthInMinutes => _lengthInMinutes;

    // Abstract methods: Must be implemented (overridden) by derived classes.
    // These methods define the contract for calculating activity-specific metrics.

    /// <summary>
    /// Gets the distance of the activity in kilometers.
    /// </summary>
    /// <returns>Distance in km.</returns>
    public abstract double GetDistance();

    /// <summary>
    /// Gets the average speed of the activity in kilometers per hour.
    /// </summary>
    /// <returns>Speed in kph.</returns>
    public abstract double GetSpeed();

    /// <summary>
    /// Gets the pace of the activity in minutes per kilometer.
    /// </summary>
    /// <returns>Pace in min/km.</returns>
    public abstract double GetPace();

    // Virtual method: Provides a default implementation that can be overridden by derived classes.
    // Generates a summary string containing common information and calculated metrics.
    public virtual string GetSummary()
    {
        // Note: Derived classes currently override this, but this provides a fallback.
        // It uses the abstract methods (which will call the derived class implementations).
        // GetType().Name dynamically gets the name of the derived class (e.g., "Running").
        return $"{_date.ToShortDateString()} {GetType().Name} ({_lengthInMinutes} min): " +
               $"Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
               // Using :F2 to format numbers to 2 decimal places for cleaner output.
    }
}