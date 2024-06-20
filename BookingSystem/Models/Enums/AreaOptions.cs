using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Models.Enums
{
    public enum AreaOptions
    {
        [Display(Name = "2300 Sqft T")]
        Sqft2300,
        [Display(Name = "2800 Sqft T")]
        Sqft2800,
        [Display(Name = "3500 Sqft T")]
        Sqft3500
    }
}
