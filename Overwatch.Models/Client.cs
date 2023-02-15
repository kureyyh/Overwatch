using System.ComponentModel.DataAnnotations;

namespace Overwatch.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]  
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedDateTime { get; set; }
    }
}
