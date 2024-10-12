using System;



public class Comment
{

    public string _commentUser;
    public string _comments;

    public Comment(string user, string comments)
    {
        _commentUser = user;
        _comments = comments;

    }

    public string DisplayAll()
    {
        string commenting = $"{_commentUser} - {_comments}";
        return commenting;


    }

}