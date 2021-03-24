using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Category
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O {0} deve conter entre {2} e {1} caracteres!")]

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Produtos")]
        public ICollection<Product> Products { get; set; } = new List<Product>();


        public Category(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public void AddProducts(Product obj)
        {
            Products.Add(obj); 
        }
    }
}
