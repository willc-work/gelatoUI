using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoDataLayer.Models
{     // not in use - issues with overridign the conection to the Product model created by the IDE
    [Table("Products")]

        public partial class G2UProduct
    {
        
        public G2UProduct()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }

        public int ProductNumber { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal RecommendedRetailPrice { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}

