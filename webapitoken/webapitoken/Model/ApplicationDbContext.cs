using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webapitoken.Model
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext() : base("ProductCs")
        {

        }
        public DbSet<Products> products { get; set; }
    }
}