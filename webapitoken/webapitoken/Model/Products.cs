using Microsoft.AspNet.Identity.EntityFramework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace webapitoken.Model
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
        public int  Quantity { get; set; }

    }
}