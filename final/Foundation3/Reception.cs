using System; // Required for DateTime (implicitly via base class usage)

// Represents a Reception event, inheriting from the base Event class.
public class Reception : Event
{
    // Private field specific to Reception events.
    private string _rsvpEmail;

    // Constructor for Reception.
    // Takes all base Event parameters plus the RSVP email.
    // Uses 'base(...)' to call the base class (Event) constructor.
    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address) // Call the Event constructor
    {
        _rsvpEmail = rsvpEmail;
    }

    // Overrides the GetFullDetails method from the Event class.
    // Appends Reception-specific details (Type, RSVP Email) to the standard details.
    public override string GetFullDetails()
    {
        // Calls the base class's GetStandardDetails() method first.
        return $"{base.GetStandardDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }

    // Overrides the GetShortDescription method from the Event class.
    // Specifies the event Type as "Reception".
    public override string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}