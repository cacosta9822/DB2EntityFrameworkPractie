using System.ComponentModel.DataAnnotations;

namespace DB2EntityFrameworkPractie
{
    public class SalesPerson
    {
        public int SalesPersonID { get; set; }
        public bool IsManager { get; set; }
        public Entity Entity { get; set; }
    }
}