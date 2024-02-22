using System.ComponentModel.DataAnnotations;

namespace CustomerDatabase_API.Server.Models
{
    public class CustomerInfo
    {
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
    }
}
