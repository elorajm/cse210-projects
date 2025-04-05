/// <summary>
/// Represents a physical address.
/// </summary>
public class Address
{
    // Private fields to store address components.
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    /// <summary>
    /// Initializes a new instance of the Address class.
    /// </summary>
    /// <param name="street">The street address line.</param>
    /// <param name="city">The city name.</param>
    /// <param name="state">The state or province name.</param>
    /// <param name="country">The country name.</param>
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    /// <summary>
    /// Checks if the address is located within the USA.
    /// </summary>
    /// <returns>True if the country is "USA", false otherwise.</returns>
    public bool IsInUSA()
    {
        // Simple check against the country field. Case-sensitive.
        return _country == "USA";
    }

    /// <summary>
    /// Generates a formatted string representation of the full address.
    /// </summary>
    /// <returns>A multi-line string containing the full address.</returns>
    public string GetFullAddress()
    {
        // Uses string interpolation for clean formatting.
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}