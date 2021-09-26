using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_953505_Bystrov.Models
{
    public class MenuItem
    {
        public string Controller { get; set; }
        public string Method { get; set; }
        public string Action { get; set; }
        public string Area { get; set; }
        public string Page { get; set; }
        public string Text { get; set; }
        public string ActiveStyle { get; set; }
        public bool IsPage { get; set; }

    }
}
