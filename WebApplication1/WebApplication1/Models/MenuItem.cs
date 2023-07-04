using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MenuItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public List<MenuItem> Children { get; set; }
    }
}