using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ayce.Models.Components
{
    public class CookingFeed
    {
        public string FeedTitle { get; set; }
        public string TitleTag { get; set; }
        public string Orientation { get; set; }
        public List<CookingFeedItems> CookingFeedItemList { get; set; }

    }

    public class CookingFeedItems
    {
        public string DishTitle { get; set; }
        public string ImgUrl { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }
}