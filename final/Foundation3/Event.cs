using System; // Required for DateTime

// Base class for all types of events.
// Contains common properties like title, description, date, time, and address.
public class Event
{
    // Protected fields are accessible by this class and any derived classes.
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected string _time;
    protected Address _address; // Composition: Event 'has an' Address.

    // Constructor for the base Event class.
    // Initializes common event properties.
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Returns a string with the standard details common to all events.
    // Includes title, description, date, time, and the full address.
    public string GetStandardDetails()
    {
        // Calls GetFullAddress() on the _address object.
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress:\n{_address.GetFullAddress()}";
    }

    // Returns a string with full details specific to the event type.
    // Marked as 'virtual' so derived classes can override it with their specific details.
    // By default, it returns the standard details.
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    // Returns a short description of the event (type, title, date).
    // Marked as 'virtual' so derived classes can override it to specify their type.
    public virtual string GetShortDescription()
    {
        return $"Type: Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}