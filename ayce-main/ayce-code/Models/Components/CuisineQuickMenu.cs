using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ayce.Models.Components
{
    public class CuisineQuickMenu
    {

        public string CuisineMenuTitle { get; set; }
        public string Color { get; set; }
        public List<CuisineQuickMenuItems> CuisineItems { get; set; }

    }

    public class CuisineQuickMenuItems
    {
        public string MenuTitle { get; set; }
        public string Icon { get; set; }
    }
}