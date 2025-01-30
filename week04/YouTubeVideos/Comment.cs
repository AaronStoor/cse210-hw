using System;

public class Comment
{
    private string commenterName;
    private string text;

    public Comment(string commenterName, string text)
    {
        this.commenterName = commenterName;
        this.text = text;
    }
    public string GetCommenterName()
    {
        return commenterName;
    }
    public void SetCommenterName(string commenterName)
    {
        this.commenterName = commenterName;
    }
    public string GetText()
    {
        return text;
    }
    public void SetText(string text)
    {
        this.text = text;
    }
}