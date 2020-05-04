using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDocuments.BL
{
    class AppDbContext:DbContext
    {
        static string connString =  ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public AppDbContext() : base(connString)
        {

        }
        DbSet<Customer> Customers { get; set; }
        DbSet<Article> Articles { get; set; }
        DbSet<Document> Documents { get; set; }
    }
}
