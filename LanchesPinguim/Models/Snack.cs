using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesPinguim.Models
{
    [Table("Snacks")]
    public class Snack
    {
        [Key]
        public int SnackId { get; set; }

        [Required(ErrorMessage = "The snack must have a name!")]
        [DisplayName("Snack Name")]
        [StringLength(80,MinimumLength = 10)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The snack must have a description")]
        [DisplayName("Snack Description")]
        [MinLength(20,ErrorMessage = "Description must have at least 20 characters")]
        [MaxLength(200,ErrorMessage = "Description too long, 200 characters max.")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "The snack must have a complete description")]
        [DisplayName("Snack complete Description")]
        [MinLength(20, ErrorMessage = "Description must have at least 20 characters")]
        [MaxLength(200, ErrorMessage = "Description too long, 200 characters max.")]
        public string DetailedDescription { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99)]
        public decimal Price { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(200)]
        public string ImageThumbnailUrl { get; set; }


        public bool IsFavoriteSnack { get; set; }
        public bool IsInStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
