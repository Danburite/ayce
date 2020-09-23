using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ButterCMSPage.Controllers;
using ayce.Models.Components;
using ButterCMS;

namespace ayce.Models.Pages
{
    public class DishFeedPage
    {
        public Seo SEO { get; set; }
        public int DishCount { get; set; }
        public List<DishPage> Dishes { get; set; }
    }
}