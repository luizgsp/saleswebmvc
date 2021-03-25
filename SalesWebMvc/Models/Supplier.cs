using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public int PersonType { get; set; }
        public string CnpjCpf { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public bool Status { get; set; }
        public string Identification { get; set; }
        public string StateRegistration { get; set; }
        public string MunicipalRegistration { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Image { get; set; }
        public string NumBank { get; set; }
        public string BankName { get; set; }
        public string AgencyBank { get; set; }
        public string Account { get; set; }
        public decimal CreditLimit { get; set; }
        public ICollection<Phone> Phones { get; set; } = new List<Phone>();
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
        public DateTime CreateDate { get; set; }
        public DateTime UptadeDate { get; set; }

        [Display(Name = "Observações")]
        public ICollection<Notes> Notes { get; set; } = new List<Notes>();

        [Display(Name = "Histórico")]
        public ICollection<History> History { get; set; } = new List<History>();

        [Display(Name = "Produtos")]
        public ICollection<Product> Products { get; set; } = new List<Product>();

        public Supplier() { }

        public Supplier(int id, int personType, string cnpjCpf, string name, string nickName, bool status, string identification, string stateRegistration, string municipalRegistration, string contact, string email, string website, string image, string numBank, string bankName, string agencyBank, string account, decimal creditLimit, DateTime createDate, DateTime uptadeDate)
        {
            Id = id;
            PersonType = personType;
            CnpjCpf = cnpjCpf;
            Name = name;
            NickName = nickName;
            Status = status;
            Identification = identification;
            StateRegistration = stateRegistration;
            MunicipalRegistration = municipalRegistration;
            Contact = contact;
            Email = email;
            Website = website;
            Image = image;
            NumBank = numBank;
            BankName = bankName;
            AgencyBank = agencyBank;
            Account = account;
            CreditLimit = creditLimit;
            CreateDate = createDate;
            UptadeDate = uptadeDate;
        }

        public void AddPhones(Phone obj)
        {
            Phones.Add(obj);
        }

        public void RemovePhones(Phone obj)
        {
            Phones.Remove(obj);
        }

        public void AddAddress(Address obj)
        {
            Addresses.Add(obj);
        }

        public void RemoveAddress(Address obj)
        {
            Addresses.Remove(obj);
        }

        public void AddNote(Notes note)
        {
            Notes.Add(note);
        }

        public void RemoveNote(Notes note)
        {
            Notes.Remove(note);
        }

        public void AddHistory(History hr)
        {
            History.Add(hr);
        }
    }
}
