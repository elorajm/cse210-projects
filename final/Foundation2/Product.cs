public class Product
{
      private string _name;
      private string _productId;
      private float _price;
      private int _quantity;

    public Product(string name, string productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string getname(){

        return _name;
    }

    public string getproductId(){

        return _productId;
    }

    public float getprice(){

        return _price * _quantity;
    }

    public int getquantity(){
        return  _quantity;
    }
}

    