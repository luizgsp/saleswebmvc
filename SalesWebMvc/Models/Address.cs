using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Address
    {
        public int Id { get; set; }
        public TypeAddress Type { get; set; }
        public string Location { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Block { get; set; }
        public string City { get; set; }
        public string UF { get; set; }
        public string PostalCode { get; set; }

        public int CustomerId { get; set; }
        public int SupplierId { get; set; }

        public Address() { }

        public Address(int id, TypeAddress type, string location, string number, string complement, string block, string city, string uF, string postalCode)
        {
            Id = id;
            Type = type;
            Location = location;
            Number = number;
            Complement = complement;
            Block = block;
            City = city;
            UF = uF;
            PostalCode = postalCode;
        }
    }
}
