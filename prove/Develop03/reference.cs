public class Reference
{
    public string Book { get; private set; }
    public int StartChapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndChapter { get; private set; }
    public int? EndVerse { get; private set; }

    public Reference(string book, int startChapter, int startVerse)
    {
        Book = book;
        StartChapter = startChapter;
        StartVerse = startVerse;
        EndChapter = null;
        EndVerse = null;
    }

    public Reference(string book, int startChapter, int startVerse, int endChapter, int endVerse)
    {
        Book = book;
        StartChapter = startChapter;
        StartVerse = startVerse;
        EndChapter = endChapter;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (EndChapter.HasValue && EndVerse.HasValue)
        {
            return $"{Book} {StartChapter}:{StartVerse}-{EndChapter}:{EndVerse}";
        }
        else
        {
            return $"{Book} {StartChapter}:{StartVerse}";
        }
    }
}
