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
        public string getRatingString()
        {
            string path = "";
            switch (Rating)
            {
                case 1:
                    path = "/Assets/Icons/Rating/One_Star.svg";
                    break;
                case 2:
                    path = "/Assets/Icons/Rating/Two_Star.svg";
                    break;
                case 3:
                    path = "/Assets/Icons/Rating/Three_Star.svg";
                    break;
                case 4:
                    path = "/Assets/Icons/Rating/Four_Star.svg";
                    break;
                case 5:
                    path = "/Assets/Icons/Rating/Five_Star.svg";
                    break;
                default:
                    path = "~/Assets/Icons/Rating/Five_Star.svg";
                    break;
            }

            return path;
        }
        public string DishTitle { get; set; }
        public string ImgUrl { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }
}