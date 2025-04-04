using System; // Required for DateTime (implicitly via base class usage)

// Represents a Lecture event, inheriting from the base Event class.
public class Lecture : Event
{
    // Private fields specific to Lecture events.
    private string _speaker;
    private int _capacity;

    // Constructor for Lecture.
    // It takes all base Event parameters plus speaker and capacity.
    // It uses 'base(...)' to call the base class (Event) constructor.
    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address) // Call the Event constructor
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Overrides the GetFullDetails method from the Event class.
    // Appends Lecture-specific details (Type, Speaker, Capacity) to the standard details.
    public override string GetFullDetails()
    {
        // Calls the base class's GetStandardDetails() method first.
        return $"{base.GetStandardDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    // Overrides the GetShortDescription method from the Event class.
    // Specifies the event Type as "Lecture".
    public override string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}