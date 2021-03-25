using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Notes
    {
        public int Id { get; set; }
        public string Note { get; set; }

        public Notes()
        {
        }

        public Notes(int id, string note)
        {
            Id = id;
            Note = note;
        }
    }
}
