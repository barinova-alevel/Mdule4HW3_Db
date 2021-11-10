using System.Collections.Generic;

namespace Mdule4HW3_Db
{
    public class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }
        public List<Employee> employees { get; set; } = new List<Employee>();
    }
}
