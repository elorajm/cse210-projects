/// <summary>
/// Represents a customer with a name and an address.
/// </summary>
public class Customer
{
    // Private fields for customer's name and address.
    private string _name;
    private Address _address; // Composition: Customer "has an" Address.

    /// <summary>
    /// Initializes a new instance of the Customer class.
    /// </summary>
    /// <param name="name">The name of the customer.</param>
    /// <param name="address">The Address object associated with the customer.</param>
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    /// <summary>
    /// Gets the customer's name.
    /// </summary>
    /// <returns>The name of the customer.</returns>
    public string GetName()
    {
        return _name;
    }

    /// <summary>
    /// Checks if the customer's address is in the USA by delegating to the Address object.
    /// </summary>
    /// <returns>True if the customer's address is in the USA, false otherwise.</returns>
    public bool IsInUSA() // Renamed from isinUSA for C# naming conventions
    {
        // Delegates the check to the Address object's method.
        return _address.IsInUSA();
    }

    /// <summary>
    /// Gets the customer's Address object.
    /// </summary>
    /// <returns>The Address object associated with the customer.</returns>
    public Address GetAddress()
    {
        return _address;
    }
}