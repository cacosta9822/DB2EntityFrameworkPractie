using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB2EntityFrameworkPractie
{
    public class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EntityID { get; set; }
        public string Description { get; set; }
        //public Client Client { get; set; }
        //public SalesPerson SalesPerson { get; set; }
    }
}