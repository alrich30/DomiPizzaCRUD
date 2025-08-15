using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace DomiPizza.Models.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El apellido del cliente es obligatorio.")]
        [StringLength(50)]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "La dirección de entrega es obligatoria.")]
        [StringLength(200)]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Required(ErrorMessage = "El número de teléfono es obligatorio.")]
        [Phone(ErrorMessage = "El formato del teléfono no es válido.")]
        [Display(Name = "Teléfono")]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        [StringLength(100)]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        [ValidateNever]
        public List<Order> Orders { get; set; }

        public string DisplayInfo
        {
            get
            {
                return $"{FirstName} {LastName} ({Email})"; // Ej: "Juan Pérez (jperez@correo.com)"
            }
        }
    }
}
