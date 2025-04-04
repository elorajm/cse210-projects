using System; // Required for DateTime (implicitly via base class usage)

// Represents an Outdoor Gathering event, inheriting from the base Event class.
// Note: The original filename was Outdoor.cs, but the class name is OutdoorGathering.
public class OutdoorGathering : Event
{
    // Private field specific to OutdoorGathering events.
    private string _weatherForecast;

    // Constructor for OutdoorGathering.
    // Takes all base Event parameters plus the weather forecast.
    // Uses 'base(...)' to call the base class (Event) constructor.
    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address) // Call the Event constructor
    {
        _weatherForecast = weatherForecast;
    }

    // Overrides the GetFullDetails method from the Event class.
    // Appends OutdoorGathering-specific details (Type, Weather Forecast) to the standard details.
    public override string GetFullDetails()
    {
        // Calls the base class's GetStandardDetails() method first.
        return $"{base.GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

    // Overrides the GetShortDescription method from the Event class.
    // Specifies the event Type as "Outdoor Gathering".
    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}