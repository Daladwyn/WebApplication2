using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Belonging
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string TypeName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public Person Owner { get; set; }
        public Person LentBy { get; set; }
    }
}