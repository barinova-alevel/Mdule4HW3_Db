using System.Collections.Generic;

namespace MySolution
{
    public class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }
        public List<Employee> employees { get; set; } = new List<Employee>();
    }
}
