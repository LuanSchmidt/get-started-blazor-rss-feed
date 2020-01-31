using System;

public class Feed
{
    public string Link { get; set; }
    public string Title { get; set; }
    public string FeedType { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }
    public DateTime PublishDate { get; set; }
    public string DatePublishingString { get; set; }

    public Feed()
    {
        Link = "";
        Title = "";
        FeedType = "";
        Author = "";
        Content = "";
        PublishDate = DateTime.Today;
        DatePublishingString = $"{DateTime.Today:d-M-yyyy}";
    }
}