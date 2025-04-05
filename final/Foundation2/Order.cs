using System; // Required for decimal
using System.Collections.Generic; // Required for List
using System.Text; // Required for StringBuilder

/// <summary>
/// Represents a customer's order containing a list of products.
/// Calculates costs and generates labels.
/// </summary>
public class Order
{
    // Constants for shipping costs
    private const decimal ShippingCostUSA = 5.00m;
    private const decimal ShippingCostInternational = 35.00m;

    // Private fields for the list of products, the customer, and calculated shipping cost.
    private List<Product> _products; // Renamed from products for naming convention
    private Customer _customer; // Renamed from customer for naming convention
    private decimal _shippingCost; // Use decimal, store calculated cost

    /// <summary>
    /// Initializes a new instance of the Order class.
    /// </summary>
    /// <param name="products">A list of Product objects included in the order.</param>
    /// <param name="customer">The Customer who placed the order.</param>
    public Order(List<Product> products, Customer customer)
    {
        _products = products ?? new List<Product>(); // Ensure list is not null
        _customer = customer;

        // Calculate and store shipping cost upon order creation.
        CalculateShippingCost();
    }

    /// <summary>
    /// Calculates the shipping cost based on the customer's address location.
    /// </summary>
    private void CalculateShippingCost()
    {
        // Use the IsInUSA method from the Customer (which delegates to Address)
        // and assign the appropriate constant shipping cost.
        _shippingCost = _customer.IsInUSA() ? ShippingCostUSA : ShippingCostInternational;
    }

    /// <summary>
    /// Calculates the total cost of the order, including products and shipping.
    /// </summary>
    /// <returns>The total cost of the order as a decimal.</returns>
    public decimal CalculateTotalCost() // Renamed from total, changed return type to decimal
    {
        decimal productTotal = 0;
        // Sum the total price for each product line item in the order.
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalPrice(); // Use the updated method name
        }

        // Add the pre-calculated shipping cost.
        return productTotal + _shippingCost;
    }

    /// <summary>
    /// Generates a string representing the packing label for the order.
    /// Lists each product's name and ID.
    /// </summary>
    /// <returns>A formatted string for the packing label.</returns>
    public string GetPackingLabel() // Renamed from p_label
    {
        // Use StringBuilder for efficient string concatenation in a loop.
        StringBuilder packingLabelBuilder = new StringBuilder();
        packingLabelBuilder.AppendLine("--- Packing Label ---");
        foreach (Product product in _products)
        {
            // Append product name and ID for each item in the order.
            packingLabelBuilder.AppendLine($"  Product: {product.GetName()} (ID: {product.GetProductId()})"); // Use updated method names
        }
        packingLabelBuilder.AppendLine("---------------------");
        return packingLabelBuilder.ToString();
    }

    /// <summary>
    /// Generates a string representing the shipping label for the order.
    /// Includes the customer's name and full address.
    /// </summary>
    /// <returns>A formatted string for the shipping label.</returns>
    public string GetShippingLabel() // Renamed from s_label
    {
        // Use StringBuilder for consistency and potential future complexity.
        StringBuilder shippingLabelBuilder = new StringBuilder();
        shippingLabelBuilder.AppendLine("--- Shipping Label ---");
        // Append customer name and the full address obtained from the Address object.
        shippingLabelBuilder.AppendLine($"To: {_customer.GetName()}"); // Use updated method name
        shippingLabelBuilder.AppendLine($"{_customer.GetAddress().GetFullAddress()}"); // Correctly gets full address
        shippingLabelBuilder.AppendLine("----------------------");
        return shippingLabelBuilder.ToString();
    }

     /// <summary>
    /// Gets the calculated shipping cost for the order.
    /// </summary>
    public decimal GetShippingCost()
    {
        return _shippingCost;
    }
}