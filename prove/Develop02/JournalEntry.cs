public class Entry
{
    // Properties to store the date, prompt, and user's response
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    // Constructor to initialize an entry with a date, prompt, and response
    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    // Override the ToString() method to return the entry as a formatted string
    public override string ToString()
    {
        // Format: "Date | Prompt: Response"
        return $"{Date} | {Prompt}: {Response}";
    }
}
