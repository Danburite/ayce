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
        public void copyData(ButterCMS.Models.Page<MainPage> mainPage)
        {
            this.SEO = mainPage.Fields.SEO;
            this.Hero = mainPage.Fields.Hero;
            this.CuisineQuickMenu = mainPage.Fields.CuisineQuickMenu;
            this.CookingFeed = mainPage.Fields.CookingFeed;
        }

        public Seo SEO { get; set; }
        public Hero Hero { get; set; }
        public CuisineQuickMenu CuisineQuickMenu { get; set; }
        public CookingFeed CookingFeed { get; set; }
    }
}