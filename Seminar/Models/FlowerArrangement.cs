using System;
using System.ComponentModel.DataAnnotations;

namespace Seminar.Models
{
    public class FlowerArrangement
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="* Ime je obavezno")]
        [Display(Name = "Ime")]
        [StringLength(100, ErrorMessage = "* Ime je prdeugačko")]
        public string Name { get; set; }

        [Required(ErrorMessage ="* Opis je obavezan")]
        [Display(Name = "Opis")]
        [StringLength(500, ErrorMessage = "* Opis je predugačak")]
        public string Description { get; set; }

        [Required(ErrorMessage ="* Tip je obavezan")]
        [Display(Name = "Tip")]
        public string Type { get; set; }

        [Required(ErrorMessage ="* Kolićina je obavezna")]
        [Display(Name = "Kolićina")]
        [Range(0, int.MaxValue, ErrorMessage = "* Potrebno je upisati valjanu vrijednost kolićine")]
        public int Quantity { get; set; }

        [Required(ErrorMessage ="* Umjetan je obavezan")]
        [Display(Name = "Umjetan")]
        public string Arificial { get; set; }

        [Required(ErrorMessage ="* Cijena je obavezna")]
        [Display(Name = "Cijena")]
        [Range(0, float.MaxValue, ErrorMessage = "* Potrebno je upisati valjanu vrijednost cijene")]
        public float Price { get; set; }
    }
}
