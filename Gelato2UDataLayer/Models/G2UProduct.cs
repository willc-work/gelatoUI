using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoDataLayer.Models
    {
       [Table("Products")]

        public partial class G2UProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public G2UProduct()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }

        public int ProductNumber { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal RecommendedRetailPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}

