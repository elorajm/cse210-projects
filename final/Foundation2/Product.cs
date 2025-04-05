using System; // Required for decimal

/// <summary>
/// Represents a product with details like name, ID, price, and quantity.
/// </summary>
public class Product
{
    // Private fields for product details.
    private string _name;
    private string _productId;
    private decimal _price; // Using decimal for currency is generally preferred over float/double
    private int _quantity;

    /// <summary>
    /// Initializes a new instance of the Product class.
    /// </summary>
    /// <param name="name">The name of the product.</param>
    /// <param name="productId">The unique identifier for the product.</param>
    /// <param name="price">The price per unit of the product.</param>
    /// <param name="quantity">The quantity of this product.</param>
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price; // Store the unit price
        _quantity = quantity;
    }

    /// <summary>
    /// Gets the name of the product.
    /// </summary>
    /// <returns>The product name.</returns>
    public string GetName() // Renamed from getname
    {
        return _name;
    }

    /// <summary>
    /// Gets the product ID.
    /// </summary>
    /// <returns>The product ID.</returns>
    public string GetProductId() // Renamed from getproductId
    {
        return _productId;
    }

    /// <summary>
    /// Calculates the total price for this product line item (unit price * quantity).
    /// </summary>
    /// <returns>The total price for the specified quantity of this product.</returns>
    public decimal GetTotalPrice() // Renamed from getprice and changed return type to decimal
    {
        // Calculate total price based on unit price and quantity.
        return _price * _quantity;
    }

    /// <summary>
    /// Gets the quantity of the product.
    /// </summary>
    /// <returns>The product quantity.</returns>
    public int GetQuantity() // Renamed from getquantity
    {
        return _quantity;
    }

    /// <summary>
    /// Gets the unit price of the product.
    /// </summary>
    /// <returns>The price per single unit of the product.</returns>
    public decimal GetUnitPrice()
    {
        return _price;
    }
}