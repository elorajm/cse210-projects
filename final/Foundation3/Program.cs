using System;
using System.Collections.Generic; // Required for using List<T>

// Main program class to demonstrate the event system.
public class Program
{
    // Entry point of the application.
    public static void Main()
    {
        // --- Create Address Objects ---
        // Instantiate Address objects with new US-based examples.
        Address address1 = new Address("1600 Amphitheatre Parkway", "Mountain View", "CA", "USA"); // New US address
        Address address2 = new Address("1 Infinite Loop", "Cupertino", "CA", "USA");          // New US address
        Address address3 = new Address("350 5th Ave", "New York", "NY", "USA");            // New US address

        // --- Create Event Objects ---
        // Instantiate different types of events, using the US addresses created above.
        // Event details are kept similar for context.
        Event lecture = new Lecture("Tech Innovations Summit", "Exploring the future of AI and Computing", new DateTime(2024, 10, 25), "09:00 AM", address1, "Dr. Evelyn Reed", 300);
        Event reception = new Reception("Silicon Valley Networking", "Connect with tech industry leaders", new DateTime(2024, 11, 15), "6:30 PM", address2, "rsvp-sv@example.com");
        Event outdoorGathering = new OutdoorGathering("Central Park Concert", "Live music under the stars", new DateTime(2025, 06, 10), "7:00 PM", address3, "Clear skies expected");

        // --- Store Events in a List ---
        // Create a list that can hold objects of type Event (or any class derived from Event).
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // --- Iterate and Display Event Details ---
        // Loop through each event in the list.
        foreach (var ev in events) // 'ev' will hold a Lecture, Reception, or OutdoorGathering object, treated as an Event.
        {
            // --- Standard Details ---
            // Calls the GetStandardDetails() method. This method is defined in the base Event class
            // and provides details common to all events.
            Console.WriteLine("--- Standard Details ---");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine(); // Blank line for separation

            // --- Full Details ---
            // Calls the GetFullDetails() method. Because this method is 'virtual' in Event and
            // 'override'n in the derived classes (Lecture, Reception, OutdoorGathering),
            // the specific version for the actual object type (Lecture, Reception, etc.) is executed.
            // This demonstrates polymorphism.
            Console.WriteLine("--- Full Details ---");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine(); // Blank line for separation

            // --- Short Description ---
            // Calls the GetShortDescription() method. Similar to GetFullDetails, this uses polymorphism
            // to call the overridden version from the specific derived class.
            Console.WriteLine("--- Short Description ---");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("---------------------------\n"); // Separator for the next event
        }
    }
}