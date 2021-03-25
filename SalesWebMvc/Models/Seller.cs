using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="O {0} deve conter entre {2} e {1} caracteres!")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [EmailAddress(ErrorMessage = "Informe um {0} válido")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [Range(100.0, 100000.0, ErrorMessage ="O {0} deve estar na faixa de {1} a {2}")]
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString ="{0:C2}")]
        public double BaseSalary { get; set; }

        [Display(Name = "Departamento")]
        public Departament Departament { get; set; }

        [Display(Name = "Departamento")]
        public int DepartamentId { get; set; }

        [Display(Name = "Observações")]
        public ICollection<string> Notes { get; set; } = new List<string>();

        [Display(Name = "Histórico")]
        public ICollection<string> History { get; set; } = new List<string>();

        [Display(Name = "Vendas")]
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
