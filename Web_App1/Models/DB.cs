using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_App1.Models.Data
{
    public class DB : DbContext
    {
        public DbSet<PagesDTO> Pages { get; set; }

        //public DbSet<comics> Comicst { get; set; }
        //public DbSet<SidebarDTO> Sidebars { get; set; }
    }
}