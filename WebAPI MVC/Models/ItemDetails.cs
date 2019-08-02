using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_MVC.Models
{
    public class ItemDetails
    {
        public string product { get; set; }
        public int qty { get; set; }
        public decimal Price { get; set; }
    }
}