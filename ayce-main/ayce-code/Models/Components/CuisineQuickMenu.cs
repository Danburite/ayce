using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ayce.Models.Components
{
    public class CuisineQuickMenu
    {

        public string MenuTitle { get; set; }
        public string Color { get; set; }
        public List<CuisineQuickMenuItems> CuisineItems { get; set; }

    }

    public class CuisineQuickMenuItems
    {
        public string getIconString()
        {
            string path = "";
            switch(Icon)
            {
                case "american":
                    path = "/Assets/Icons/Food/Hamburger.svg";
                    break;
                case "chinese":
                    path = "/Assets/Icons/Food/Chinese_Bowl.svg";
                    break;
                case "italian":
                    path = "/Assets/Icons/Food/Bowtie.svg";
                    break;
                case "mexican":
                    path = "/Assets/Icons/Food/Taco.svg";
                    break;
                case "japanese":
                    path = "/Assets/Icons/Food/Sushi.svg";
                    break;
                case "french":
                    path = "/Assets/Icons/Food/Croissant.svg";
                    break;
                case "drinks":
                    path = "/Assets/Icons/Food/Coffee.svg";
                    break;
                case "dessert":
                    path = "/Assets/Icons/Food/Ice_Cream.svg";
                    break;
                default:
                    path = "~/Assets/Icons/Food/Hamburger.svg";
                    break;
            }

            return path;
        }
        public string MenuTitle { get; set; }
        public string Icon { get; set; }
    }
}