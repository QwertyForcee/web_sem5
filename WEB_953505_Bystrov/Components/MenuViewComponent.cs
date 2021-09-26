using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB_953505_Bystrov.Models;

namespace WEB_953505_Bystrov.Components
{
    public class MenuViewComponent:ViewComponent
    {
        private List<MenuItem> _menuItems = new List<MenuItem>
        {
        new MenuItem{ Controller="Home", Action="Index", Text="Lab 2"},
        new MenuItem{ Controller="Product", Action="Index",
        Text="Каталог"},
        new MenuItem{ IsPage=true, Area="Admin", Page="/Index",
        Text="Администрирование"}
        };
        public IViewComponentResult Invoke()
        {
            var controller = ViewContext.RouteData.Values["controller"];
            var page = ViewContext.RouteData.Values["page"];
            var area = ViewContext.RouteData.Values["area"];

            foreach (var item in _menuItems)
            {
                if ( (controller?.Equals(item.Controller)??false) || (area?.Equals(item.Area)??false))
                {
                    item.ActiveStyle = "active";    
                }
            }

            return View(_menuItems);
        }
    }
}
