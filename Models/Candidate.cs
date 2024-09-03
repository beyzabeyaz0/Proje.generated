using System;
using System.ComponentModel.DataAnnotations;


namespace Proje.Models
{
    public class Candidate
    {

        [Required(ErrorMessage = "E-mail is required.")] // doldurmak zorunlu uyarrısı
        public String? Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "FirstName is required.")] // doldurmak zorunlu uyarrısı
        public String? FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "LastName is required.")]  // doldurmak zorunlu uyarrısı
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}"; // read only ifade

        [Required(ErrorMessage = "Birthday is required.")]  // doldurmak zorunlu uyarrısı
        public DateOnly Birthday { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;


        public DateTime ApplyAt { get; set; }
        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}