using System;
using System.Diagnostics.Contracts;
using System.Runtime.Serialization;

public class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>();
    }
    public string GetTitle()
    {
        return title;
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }
    public string GetAuthor()
    {
        return author;
    }
    public void SetAuthor(string author)
    {
        this.author = author;
    }
    public int GetLength()
    {
        return length;
    }
    public void SetLength(int length)
    {
        this.length = length;
    }
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return comments.Count;
    }
    public void DisplayComments()
    {
        foreach (var comment in comments)
        {
            Console.WriteLine($"Comment by {comment.GetCommenterName()}: {comment.GetText}");
        }
    }
}