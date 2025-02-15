public class Scripture
{
    public string Text { get; set; }
    public Reference Ref { get; set; }

    public Scripture(string text, Reference reference)
    {
        Text = text;
        Ref = reference;
    }

    public override string ToString()
    {
        return $"{Ref}: {Text}";
    }
}