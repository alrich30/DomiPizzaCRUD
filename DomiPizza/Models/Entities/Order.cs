using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DomiPizza.Models.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        [Display(Name = "Fecha del Pedido")]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "El monto total es obligatorio.")]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Monto Total")]
        public decimal TotalAmount { get; set; }

        [Required(ErrorMessage = "El estado del pedido es obligatorio.")]
        [StringLength(50)]
        [Display(Name = "Estado del Pedido")]
        public string Status { get; set; } // Examples: "En preparación", "En camino", "Entregado"

        [Display(Name = "¿Es para Delivery?")]
        public bool IsDelivery { get; set; }

        [StringLength(200)]
        [Display(Name = "Dirección de Entrega")]
        public string DeliveryAddress { get; set; }

        // --- Llaves foraneas para el cliente ---
        [Required]
        public int CustomerId { get; set; }
        [ValidateNever]
        public Customer Customer { get; set; }

        [ValidateNever]
        public List<OrderDetail> OrderDetails { get; set; }
    }

}
