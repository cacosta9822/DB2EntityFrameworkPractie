using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB2EntityFrameworkPractie
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceID { get; set; }
        public decimal Tax { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public Client Client { get; set; }
        public SalesPerson SalesPerson { get; set; }
        public IEnumerable<InvoiceDetail> InvoiceDetails { get; set; }
    }
}