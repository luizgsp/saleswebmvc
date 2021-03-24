using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Data Venda")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }



        public SaleStatus Status { get; set; }

        [Display(Name = "Vendedor")]
        public Seller Seller { get; set; }

        public Customer Customer { get; set; }

        public ICollection<SalesItems> Items { get; set; } = new List<SalesItems>();

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Status = status;
            Seller = seller;
        }

        public void AddItems(SalesItems obj)
        {
            Items.Add(obj);
        }

        [Display(Name = "Valor Venda")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double Amount
        {
            get { return (double)Items.Sum(x => x.SubTotal()); }
        }
    }
}
