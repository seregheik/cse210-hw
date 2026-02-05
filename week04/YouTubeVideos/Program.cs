using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Understanding Abstraction", "CodeMaster", 300);
        video1.AddComment(new Comment("User1", "Great explanation!"));
        video1.AddComment(new Comment("User2", "Very clear, thanks."));
        video1.AddComment(new Comment("User3", "Abstraction is key."));
        videos.Add(video1);
        Video video2 = new Video("C# Classes Tutorial", "DevGuru", 600);
        video2.AddComment(new Comment("Coder123", "Helpful tutorial."));
        video2.AddComment(new Comment("NewbieDev", "I learned a lot."));
        video2.AddComment(new Comment("ExpertCoder", "Good basics covered."));
        videos.Add(video2);
        Video video3 = new Video("OOP Principles", "TechTeacher", 450);
        video3.AddComment(new Comment("StudentA", "Now I get it."));
        video3.AddComment(new Comment("StudentB", "Can you cover Inheritance next?"));
        video3.AddComment(new Comment("StudentC", "Nice video!"));
        videos.Add(video3);
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine("---------------------------------------------------");
        }
    }
}