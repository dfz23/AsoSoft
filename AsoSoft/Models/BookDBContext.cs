using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Configuration;
using System.Data.Entity;

namespace AsoSoft.Models
{
    public class BookDBContext : DbContext
    {
        public DbSet<Book> book { get; set; }
    }
}