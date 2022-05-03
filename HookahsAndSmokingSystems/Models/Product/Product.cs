using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HookahsAndSmokingSystems.Models.Categoty;

namespace HookahsAndSmokingSystems.Models.Product
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        
        [Required] public string Name { get; set; }
        [Required] public SubCategory SubCategory { get; set; }
        
        [Required] public string DisplayingImageUrl { get; set; }
        
        [Required] public string Price { get; set; }

        [Required] public string Description { get; set; }
        
    }
}