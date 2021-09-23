using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953505_Bystrov.Controllers
{
    public class HomeController : Controller
    {
        private List<ListDemo> _listDemos = new List<ListDemo>() {
            new ListDemo{ ListItemText="тридцать три" ,ListItemValue=33},
            new ListDemo{ ListItemText="двенадцать" ,ListItemValue=12},
            new ListDemo{ ListItemText="пять" ,ListItemValue=5}
        };
        public IActionResult Index()
        {
            ViewData["DemoList"] = new SelectList(_listDemos, "ListItemValue", "ListItemText");
            ViewData["Text"] = "Лабораторная работа 2";
            return View();
        }
    }
    public class ListDemo
    {
        public int ListItemValue { get; set; }
        public string ListItemText { get; set; }
    }
}
