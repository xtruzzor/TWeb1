using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class UserData
    {
        public string Username { get; set; }

        public List<Product> Products { get; set; }

        public string SingleProduct { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }

    }
}