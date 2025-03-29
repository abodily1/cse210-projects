using System;

public class Video
{
    private List<Comment> _comments = new List<Comment>();
    private string _title = "";
    private string _author = ""; 
    private int _length = 0;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length; 
    }
    public void AddComment(string name, string text)
    {
        Comment c = new Comment(name, text);
        _comments.Add(c);
    }
    private int GetNumberOfComments()
    {
        return _comments.Count();
    }
    public string GetDisplayText()
    {
        return $"Title: {_title} Author: {_author} Length: {_length} Number of Comments: {GetNumberOfComments()}";
    }
    public void GetComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplayText());
        }
    }
}