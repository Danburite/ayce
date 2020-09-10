using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ButterCMSPage.Controllers;
using ayce.Models.Components;
using ButterCMS;

namespace ayce.Models.Pages
{
    public class MainPage
    {
        public void copyData(ButterCMS.Models.PageResponse<MainPage> mainPage)
        {
            this.SEO = mainPage.Data.Fields.SEO;
            this.Hero = mainPage.Data.Fields.Hero;
            this.CuisineQuickMenu = mainPage.Data.Fields.CuisineQuickMenu;
            this.CookingFeed = mainPage.Data.Fields.CookingFeed;
        }

        public Seo SEO { get; set; }
        public Hero Hero { get; set; }
        public CuisineQuickMenu CuisineQuickMenu { get; set; }
        public CookingFeed CookingFeed { get; set; }
    }
}