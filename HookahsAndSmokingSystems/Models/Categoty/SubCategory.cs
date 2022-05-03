using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HookahsAndSmokingSystems.Models.Interfaces;

namespace HookahsAndSmokingSystems.Models.Categoty
{
    public class SubCategory : ICategory
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; private set; }
        
        [Required] public string Name { get; set; }
        
        [Required] public Category ParentCategory { get; set; }
    }
}