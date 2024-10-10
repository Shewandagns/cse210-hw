using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // Create 3-4 videos with comments
        Video video1 = new Video("Learn C# Basics", "John Doe", 120);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));
        videos.Add(video1);

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 150);
        video2.AddComment(new Comment("Dave", "Loved the in-depth explanations."));
        video2.AddComment(new Comment("Eva", "Can you cover more examples?"));
        videos.Add(video2);

        Video video3 = new Video("C# for Beginners", "Tom Brown", 90);
        video3.AddComment(new Comment("Frank", "Perfect for getting started!"));
        video3.AddComment(new Comment("Grace", "Could use more visuals."));
        video3.AddComment(new Comment("Hank", "Enjoyed the pacing."));
        videos.Add(video3);

        // Display the video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            // List comments
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(); // Blank line for spacing
        }
    }
}
