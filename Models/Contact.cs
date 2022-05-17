using System.ComponentModel.DataAnnotations;

namespace contact_manager_dot_net.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }

        public string Number { get; set; } 

        public string Address { get; set; }

        public string Email { get; set; }

    }
}
