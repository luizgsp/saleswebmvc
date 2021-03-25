using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Positions
    {
        public int Id { get; set; }
        public string Description { get; set; }

        [Display(Name = "Funcionários")]
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public Positions() { }
        public Positions(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public void AddEmployee(Employee obj)
        {
            Employees.Add(obj);
        }

        public void RemoveEmployee(Employee obj)
        {
            Employees.Remove(obj);
        }
    }
}
