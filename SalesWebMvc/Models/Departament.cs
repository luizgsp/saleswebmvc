﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Departament
    {
        [Display(Name = "Código")]
        public int  Id { get; set; }

        [Display(Name = "Departamento")]
        public string  Name { get; set; }

        [Display(Name = "Vendedores")]
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

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

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
