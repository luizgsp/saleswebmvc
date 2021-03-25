using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class History
    {
        public int Id { get; set; }
        public string Event { get; set; }
        public DateTime EventDate { get; set; }
        public User User { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int SellerId { get; set; }
        public int DepartamentId { get; set; }
        public int UserId { get; set; }

        public History()
        {
        }

        public History(int id, string @event, DateTime eventDate, User user)
        {
            Id = id;
            Event = @event;
            EventDate = eventDate;
            User = user;
        }
    }
}
