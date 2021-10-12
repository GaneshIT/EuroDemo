using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementDataLayer
{
   public class ProductDbContext:DbContext
    {
        public ProductDbContext()
            : base("ProductDbEntities")
        {
        }
        public virtual DbSet<Salesman> salesmen { get; set; }
    }
}
