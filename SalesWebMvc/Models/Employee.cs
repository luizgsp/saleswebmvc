using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Employee
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "{0} requerido")]
        public string Cpf { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} requerido")]
        public string Name { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "{0} requerido")]
        public int Status { get; set; }

        [Display(Name = "CI")]
        public string Identification { get; set; }

        [Display(Name = "Carteira de Trabalho")]
        public string WorkRegistration { get; set; }

        [Display(Name = "PIS")]
        public string Pis { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [EmailAddress(ErrorMessage = "Informe um {0} válido")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Foto")]
        public string Image { get; set; }

        [Display(Name = "Num. Banco")]
        public string NumBank { get; set; }

        [Display(Name = "Nome Banco")]
        public string BankName { get; set; }

        [Display(Name = "Agência")]
        public string AgencyBank { get; set; }

        [Display(Name = "Conta")]
        public string Account { get; set; }

        [Display(Name = "Limite de Crédito")]
        [Required(ErrorMessage = "{0} requerido")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
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

        [Display(Name = "Departamento")]
        public Departament Departament { get; set; }
        [Display(Name = "Departamento")]
        public int DepartamentId { get; set; }

        [Display(Name = "Cargo")]
        public int PositionsId { get; set; }
        [Display(Name = "Cargo")]
        public Positions Position { get; set; }

        [Display(Name = "Observações")]
        public ICollection<Notes> Notes { get; set; } = new List<Notes>();

        [Display(Name = "Histórico")]
        public ICollection<History> History { get; set; } = new List<History>();
    }
}
