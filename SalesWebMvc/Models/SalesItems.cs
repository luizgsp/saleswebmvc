using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SalesItems
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public string Note { get; set; }
        public int SalesRecordId { get; set; }
        public SalesRecord SalesRecord { get; set; }

        public SalesItems() { }

        public SalesItems(int id, Product product, decimal price, decimal quantity, string note, SalesRecord salesRecord)
        {
            Id = id;
            Product = product;
            Price = price;
            Quantity = quantity;
            Note = note;
            SalesRecord = salesRecord;
        }

        public decimal SubTotal()
        {
            return Price * Quantity;
        }
    }
}
