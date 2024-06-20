using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Models.Enums
{
    public enum FloorOptions
    {
        [Display(Name = "1-5")]
        OneToFive,
        [Display(Name = "6-10")]
        SixToTen,
        [Display(Name = "11-15")]
        ElevenToFifteen,
        [Display(Name = "16-20")]
        SixteenToTwenty,
        [Display(Name = "21-25")]
        TwentyOneToTwentyFive,
        [Display(Name = "26-30")]
        TwentySixToThirty,
        [Display(Name = "31-34")]
        ThirtyOneToThirtyFour
    }

}
