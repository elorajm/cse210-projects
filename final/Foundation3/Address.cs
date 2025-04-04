// Represents a physical address with street, city, state/province, and country.
public class Address
{
    // Private fields to store address components. Encapsulation principle.
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor to initialize a new Address object.
    // Takes street, city, state/province, and country as arguments.
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Returns a formatted string representation of the full address.
    // Uses string interpolation for clean formatting.
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}