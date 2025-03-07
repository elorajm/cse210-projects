public class Circle : Shape
{
    private double _radius;

    public Circle(double radius , string _color) : base(_color){
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
}