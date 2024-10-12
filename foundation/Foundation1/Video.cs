using System;


public class Video
{
    public string _title;
    public string _author;
    public int _videoLength;

    public string _comment;

    public List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int videoLenght, string comment)
    {
        

        _comment = comment;
        _title = title;
        _author = author;
        _videoLength = videoLenght;

        string[] commentList = _comment.Split(" , ");

        foreach (string item in commentList)
        {
            string[] commentAndUser = item.Split(" - ");
            _comments.Add(new Comment(commentAndUser[0], commentAndUser[1]));
        }

    }
    public int CountComments()
    {

        int count = _comments.Count;
        return count; //returning number of comments from the comment section

    }


    public string DisplayAll()
    {
        // displaying video details and comment details  as requested

        string _videoText = "";
        foreach (Comment comment in _comments)
        {
            string getText = comment.DisplayAll();
            _videoText = _videoText + $"\n{getText}";
        }

        int count = CountComments();
        string video1 = $"{_title} - {_author} - {_videoLength} seconds - \nComments({count}): {_videoText}";// \n comments in another line- 
        return video1;
        //displays the video title, author name, video lenght in seconds.
    }


}