using System.ComponentModel.DataAnnotations;

namespace DB2EntityFrameworkPractie
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Contact { get; set; }
        public Entity Entity { get; set; }
    }
}