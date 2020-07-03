using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB2EntityFrameworkPractie
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public IEnumerable<Product> Products { get; set; }

    }
}