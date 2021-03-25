using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Departament
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "{0} requerido")]
        public string Name { get; set; }

        [Display(Name = "Vendedores")]
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        [Display(Name = "Funcionários")]
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        [Display(Name = "Histórico")]
        public ICollection<History> History { get; set; } = new List<History>();

        public Departament() { }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public void AddEmployee(Employee obj)
        {
            Employees.Add(obj);
        }

        public void RemoveEmployee(Employee obj)
        {
            Employees.Remove(obj);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }

        public void AddHistory(History hr)
        {
            History.Add(hr);
        }
    }
}
