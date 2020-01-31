using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

public class RssFeedService
{
    public async Task<List<Feed>> GetFeedsAsync()
    {
        CultureInfo culture = new CultureInfo("en-US");

        try
        {
            XDocument document = XDocument.Load("https://www.c-sharpcorner.com/rss/latestcontentall.aspx");
            var entries = from item in document.Root.Descendants().First(i => i.Name.LocalName == "channel").Elements().Where(i => i.Name.LocalName == "item")
                          select new Feed
                          {
                              Content = item.Elements().First(i => i.Name.LocalName == "description").Value,
                              Link = (item.Elements().First(i => i.Name.LocalName == "link").Value).StartsWith("/") ? "https://www.c-sharpcorner.com" + item.Elements().First(i => i.Name.LocalName == "link").Value : item.Elements().First(i => i.Name.LocalName == "link").Value,
                              PublishDate = Convert.ToDateTime(item.Elements().First(i => i.Name.LocalName == "pubDate").Value, culture),
                              DatePublishingString = Convert.ToDateTime(item.Elements().First(i => i.Name.LocalName == "pubDate").Value, culture).ToString("d-M-yyyy"),
                              Title = item.Elements().First(i => i.Name.LocalName == "title").Value,
                              FeedType = (item.Elements().First(i => i.Name.LocalName == "link").Value).ToLowerInvariant().Contains("blog") ? "Blog" : (item.Elements().First(i => i.Name.LocalName == "link").Value).ToLowerInvariant().Contains("news") ? "News" : "Article",
                              Author = item.Elements().First(i => i.Name.LocalName == "author").Value
                          };
            return await Task.FromResult(entries.OrderByDescending(o => o.PublishDate).ToList());
        }
        catch
        {
            var feeds = new List<Feed>();
            Feed feed = new Feed();
            feeds.Add(feed);
            return await Task.FromResult(feeds);
        }
    }
}