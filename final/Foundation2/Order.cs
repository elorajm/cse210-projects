public class Order
{
      
      List<Product> products = new List<Product>();
      private Customer customer;
      private float ShippingCost;
    

    public Order(List<Product> products,Customer customer)
    {
        this.products = products;
        this.customer = customer;
        
        
    }

    public double total(double total = 0)
    {
        foreach(Product product in products){
            total+= product.getprice();
        }
        total += customer.isinUSA() ? 5 : 35;
        return total;
    }

    public string p_label(){
        string package_label = "";
        foreach(Product product in products){
            package_label += product.getname() + "-";
            package_label += product.getproductId() + $"\n";
        }

        return package_label;
    }
    
    public string s_label()
    {
        return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}\n";
    }
    


}