using MySolution.DataAccess.Models;
using System;
using System.Collections.Generic;

namespace MySolution
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartedDate { get; set; }
        public int ClientId { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Client> clients { get; set; } = new List<Client>();
        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
