public abstract class Shape{
    private string _color;
    public string GetColor(){
        return _color;
    }
    public Shape(string _color){
        SetColor(_color);
    }
    public void SetColor(string color){
        _color = color;
    }

    public abstract double GetArea();
}