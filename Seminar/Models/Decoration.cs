using System;
using System.ComponentModel.DataAnnotations;

namespace Seminar.Models
{
    public class Decoration
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "* Ime je obavezno")]
        [Display(Name = "Ime")]
        [StringLength(100, ErrorMessage = "* Ime je prdeugačko")]
        public string Name { get; set; }

        [Display(Name = "Opis")]
        [StringLength(250, ErrorMessage = "* Opis je predugačak")]
        public string Description { get; set; }

        [Required(ErrorMessage = "* Tip je obavezan")]
        [Display(Name = "Tip")]
        public string Type { get; set; }

        [Required(ErrorMessage = "* Boja je obavezna")]
        [Display(Name = "Boja")]
        public string Color { get; set; }

        [Required(ErrorMessage = "* Kolićina je obavezna")]
        [Display(Name = "Kolićina")]
        [Range(0, int.MaxValue, ErrorMessage = "* Potrebno je upisati valjanu vrijednost kolićine")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "* Kolićina u paketu je obavezna")]
        [Display(Name = "Kol u paketu")]
        [Range(1, int.MaxValue, ErrorMessage = "* Potrebno je upisati valjanu vrijednost komada u paketu")]
        public int PackageSize { get; set; }

        [Required(ErrorMessage = "* Materijal je obavezan")]
        [Display(Name = "Materijal")]
        public string Material { get; set; }

        [Required(ErrorMessage = "* Cijena je obavezna")]
        [Display(Name = "Cijena")]
        [Range(0, float.MaxValue, ErrorMessage = "* Potrebno je upisati valjanu vrijednost cijene")]
        public float Price { get; set; }

    }
}
