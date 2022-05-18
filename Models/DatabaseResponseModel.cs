using System.ComponentModel.DataAnnotations;

namespace contact_manager_dot_net.Models
{
    public class DatabaseResponseModel
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string Number { get; set; } 

        public string Address { get; set; }

        public string Email { get; set; }

    }
}
