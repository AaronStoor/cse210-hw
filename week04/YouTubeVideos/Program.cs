using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Program in C#", "John", 180);
        Video video2 = new Video("Learn C# in 30 minutes", "Jane", 150);
        Video video3 = new Video("Advanced C# Concepts", "James", 240);

        video1.AddComment(new Comment("Alice", "Great Video!"));
        video1.AddComment(new Comment("Bob", "Very clear explanation of the basics"));
        video1.AddComment(new Comment("Charlie", "Thank you, really helped me get started"));


        video2.AddComment(new Comment("David", "Nice overview!"));
        video2.AddComment(new Comment("Eva", "Very concise and informative."));
        video2.AddComment(new Comment("Jeff", "Could have explained a bit more about classes"));

        video3.AddComment(new Comment("Hank", "Excellent content"));
        video3.AddComment(new Comment("Grace", "Thanks for the help I really needed it"));
        video3.AddComment(new Comment("Jerry", "This is a bit too advanced for me but I still learned a lot"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments: ");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}