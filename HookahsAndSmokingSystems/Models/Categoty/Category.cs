using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HookahsAndSmokingSystems.Models.Interfaces;

namespace HookahsAndSmokingSystems.Models.Categoty
{
    public class Category : ICategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required] public string Name { get; set; }
    }
}