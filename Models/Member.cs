using System;
using System.ComponentModel.DataAnnotations;

namespace Corona_System.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "ID Number")]
        public string IdNumber { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Street")]
        public string Street { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Number")]
        public string Number { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Mobile Phone")]
        public string MobilePhone { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "First Vaccine Date")]
        public DateTime? Vaccine1Date { get; set; }

        [Required(ErrorMessage = "If the vaccination was not received, click 'NONE'")]
        [Display(Name = "First Vaccine Manufacturer")]
        public string Vaccine1Manufacturer { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Second Vaccine Date")]
        public DateTime? Vaccine2Date { get; set; }

        [Required(ErrorMessage = "If the vaccination was not received, click 'NONE'")]
        [Display(Name = "Second Vaccine Manufacturer")]
        public string Vaccine2Manufacturer { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Third Vaccine Date")]
        public DateTime? Vaccine3Date { get; set; }

        [Required(ErrorMessage = "If the vaccination was not received, click 'NONE'")]
        [Display(Name = "Third Vaccine Manufacturer")]
        public string Vaccine3Manufacturer { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fourth Vaccine Date")]
        public DateTime? Vaccine4Date { get; set; }

        [Required(ErrorMessage = "If the vaccination was not received, click 'NONE'")]
        [Display(Name = "Fourth Vaccine Manufacturer")]
        public string Vaccine4Manufacturer { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Positive Result Date")]
        public DateTime? PositiveResultDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Recovery Date")]
        public DateTime? RecoveryDate { get; set; }
    }
}

