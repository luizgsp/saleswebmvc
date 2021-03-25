using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Customer
    {
        [Display(Name = "Código")]
        public int Id{ get; set; }

        [Display(Name = "Tipo Pessoa")]
        [Required(ErrorMessage = "{0} requerido")]
        public TypePersonEnum PersonType { get; set; }

        [Display(Name = "CNPJ/CPF")]
        [Required(ErrorMessage = "{0} requerido")]
        public string CnpjCpf { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} requerido")]
        public string Name { get; set; }

        [Display(Name = "Nome Fantasia")]
        public string NickName{ get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "{0} requerido")]
        public bool Status{ get; set; }

        [Display(Name = "CI")]
        public string Identification { get; set; }

        [Display(Name = "Inscrição Estadual")]
        public string StateRegistration { get; set; }

        [Display(Name = "Inscrição Municipal")]
        public string MunicipalRegistration { get; set; }

        [Display(Name = "Contato")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [EmailAddress(ErrorMessage = "Informe um {0} válido")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }

        [Display(Name = "Website")]
        public string Website{ get; set; }

        [Display(Name = "Logomarca/Foto")]
        public string Image{ get; set; }

        [Display(Name = "Num. Banco")]
        public string NumBank{ get; set; }

        [Display(Name = "Nome Banco")]
        public string BankName{ get; set; }

        [Display(Name = "Agência")]
        public string AgencyBank{ get; set; }

        [Display(Name = "Conta")]
        public string Account{ get; set; }

        [Display(Name = "Limite de Crédito")]
        [Required(ErrorMessage = "{0} requerido")]
        [DisplayFormat(DataFormatString ="{0:C2}")]
        public decimal CreditLimit { get; set; }

        [Display(Name = "Telefone")]
        public ICollection<Phone> Phones { get; set; } = new List<Phone>();

        [Display(Name = "Endereço")]
        public ICollection<Address> Addresses { get; set; } = new List<Address>();

        [Display(Name = "Data de Inclusão")]
        [Required(ErrorMessage = "{0} requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")] 
        public DateTime CreateDate { get; set; }

        [Display(Name = "Data de Alteração")]
        [Required(ErrorMessage = "{0} requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime UptadeDate { get; set; }

        [Display(Name = "Observações")]
        public ICollection<string> Notes { get; set; } = new List<string>();

        [Display(Name = "Histórico")]
        public ICollection<string> History { get; set; } = new List<string>();

        public Customer() { }

        public Customer(int id, TypePersonEnum personType, string cnpjCpf, string name, string nickName, bool status, string identification, string stateRegistration, string municipalRegistration, string contact, string email, string website, string image, string numBank, string bankName, string agencyBank, string account, decimal creditLimit, DateTime createDate, DateTime uptadeDate)
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

        public void AddAddress(Address obj)
        {
            Addresses.Add(obj);
        }
    }
}
