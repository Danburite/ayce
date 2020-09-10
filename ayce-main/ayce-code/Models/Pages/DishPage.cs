using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ayce.Models.Components;

namespace ayce.Models.Pages
{
    public class DishPage
    {
        public Seo SEO { get; set; }
        public string DishTitle { get; set; }
        public string DishImage { get; set; }
        public string DishDescription { get; set; }
        public Recipe DishRecipe { get; set; }
    }
}