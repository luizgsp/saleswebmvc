using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models.Enums
{
    public enum TypeAddress : int
    {
        [Display(Name = "Residencial")]
        Residential,
        [Display(Name = "Comercial")]
        Commercial,
        [Display(Name = "Entrega")]
        Delivery,
        [Display(Name = "Cobrança")]
        Charge
    }
}
