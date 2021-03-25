
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models.Enums
{
    public enum TypePersonEnum : int
    {
        [Display(Name = "Física")]
        Physics = 1,
        [Display(Name = "Jurídica")]
        Legal = 2
    }
}
