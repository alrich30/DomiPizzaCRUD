using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DomiPizza.Models.Entities
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }

        [Required(ErrorMessage = "El nombre del ingrediente es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        [Display(Name = "Nombre del Ingrediente")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El precio adicional es obligatorio.")]
        [Range(0.00, 999.99, ErrorMessage = "El precio debe estar entre 0.00 y 999.99.")]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Precio Adicional")]
        public decimal AdditionalPrice { get; set; }
        [ValidateNever]
        public List<Pizza> Pizzas { get; set; }
    }
}
