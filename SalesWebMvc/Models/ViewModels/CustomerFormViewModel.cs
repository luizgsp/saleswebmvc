using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewModels
{
    public class CustomerFormViewModel
    {
        public Customer Customer { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Phone> Phones { get; set; }
    }
}
