using System;

namespace MySolution.DataAccess.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime FirstOrder { get; set; }
        public string Email { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
