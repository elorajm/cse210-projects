public class Rectangle : Shape{
    private double _lenght;
    private double _width;
    public Rectangle(double length, double width, string _color) : base(_color){
        _lenght = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _width * _lenght;
    }
}