using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB2EntityFrameworkPractie
{
    public class Tax
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaxID { get; set; }
        public decimal Porcentage { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}