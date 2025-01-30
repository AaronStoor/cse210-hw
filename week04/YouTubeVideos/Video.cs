using System;
using System.Diagnostics.Contracts;
using System.Runtime.Serialization;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
        this._comments = new List<Comment>();
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public void DisplayComments()
    {
        foreach (var comment in _comments)
        {
            Console.WriteLine($"Comment by {comment.GetCommenterName()}: {comment.GetText}");
        }
    }
}