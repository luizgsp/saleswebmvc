using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }

        public Phone() { }

        public Phone(int id, string number)
        {
            Id = id;
            Number = number;
        }
    }
}
