using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models.Enums
{
    public enum ProductStatus : int
    {
        [Display(Name = "Ativo")]
        Active,
        [Display(Name = "Inativo")]
        Inactive,
        [Display(Name = "Suspenso")]
        Suspended
    }
}
