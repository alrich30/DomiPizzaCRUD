using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace DomiPizza.Models.Entities
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatoria.")]
        [Range(1, 100, ErrorMessage = "La cantidad debe ser al menos 1.")]
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "El precio unitario es obligatorio.")]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Precio Unitario")]
        public decimal UnitPrice { get; set; }

        // --- Foreign Keys ---

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int PizzaId { get; set; }


        // --- Navigation Properties ---
        [ValidateNever]
        public Order Order { get; set; }
        [ValidateNever]
        public Pizza Pizza { get; set; }

    }
}
