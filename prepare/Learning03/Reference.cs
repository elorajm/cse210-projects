public class Reference
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int VerseStart { get; set; }
    public int VerseEnd { get; set; }

    public Reference(string book, int chapter, int verseStart, int verseEnd = -1)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verseStart;
        VerseEnd = verseEnd;

    }

    public override string ToString()
    {
        if (VerseEnd > VerseStart)
            return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
        else
            return $"{Book} {Chapter}:{VerseStart}";
    }
}