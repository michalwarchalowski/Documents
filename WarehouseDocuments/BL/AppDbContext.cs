using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDocuments.BL
{
    class AppDbContext:DbContext
    {
        public AppDbContext():base(@"Data Source =(localdb)\MSSQLLocalDB; Initial Catalog=WarehouseDocuments1; Integrated Security=True")
        {

        }
        DbSet<Customer> Customers { get; set; }
        DbSet<Article> Articles { get; set; }
        DbSet<Document> Documents { get; set; }
    }
}
