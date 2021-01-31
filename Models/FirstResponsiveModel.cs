using System;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppBurgett.Models
{
    public class FirstResponsiveModel
    {
        [Required(ErrorMessage = "Please enter a Year of birth.")]
        [Range(1900, 2020, ErrorMessage = "Year of birth must be between 1900 and 2020.")]
        public int? YearOfBirth { get; set; }

        [Required(ErrorMessage = "Please enter a Name.")]
        public string? name { get; set; }

        public int AgeThisYear()
        {
            DateTime now = DateTime.Today;
            int yearsOldToday = (int)(now.Year - YearOfBirth);
            return yearsOldToday;
        }
    }
}
