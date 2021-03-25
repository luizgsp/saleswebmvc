using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class User
    {
        public int Id{ get; set; }
        public string Login{ get; set; }
        public string Password{ get; set; }
        public int EmployeeId{ get; set; }
        public string Name{ get; set; }
        public bool Status{ get; set; }
        public int Allowed{ get; set; }

        [Display(Name = "Histórico")]
        public ICollection<History> History { get; set; } = new List<History>();

        public User()
        {
        }

        public User(int id, string login, string password, int employeeId, string name, bool status, int allowed)
        {
            Id = id;
            Login = login;
            Password = password;
            EmployeeId = employeeId;
            Name = name;
            Status = status;
            Allowed = allowed;
        }
    }
}
