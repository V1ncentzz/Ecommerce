using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class users
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
