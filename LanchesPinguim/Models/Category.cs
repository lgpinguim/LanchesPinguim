using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesPinguim.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please insert category name")]
        [StringLength(100, ErrorMessage = "max size is 100 characters")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please insert category description")]
        [StringLength(200, ErrorMessage = "max size is 200 characters")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public List<Snack> Snacks { get; set; }
    }
}
