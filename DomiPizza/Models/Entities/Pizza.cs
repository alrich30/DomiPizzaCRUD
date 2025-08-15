using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DomiPizza.Models.Entities
{
    public class Pizza
    {

        [Key] 
        public int PizzaId { get; set; }

        [Required(ErrorMessage = "El nombre de la pizza es obligatorio.")] 
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")] 
        [Display(Name = "Nombre de la Pizza")] 
        public string Name { get; set; }

        [StringLength(250, ErrorMessage = "La descripción no puede exceder los 250 caracteres.")]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, 9999.99, ErrorMessage = "El precio debe estar entre 0.01 y 9999.99.")] 
        [Column(TypeName = "decimal(18, 2)")] 
        [Display(Name = "Precio")]
        public decimal BasePrice { get; set; }

        [Required(ErrorMessage = "El tamaño de la pizza es obligatorio.")]
        [StringLength(50)]
        [Display(Name = "Tamaño")]
        public string Size { get; set; }

        [Display(Name = "URL de la Imagen")]
        public string UrlImagen { get; set; }
        [ValidateNever]
        public List<Ingredient> Ingredients { get; set; }

    }
}
