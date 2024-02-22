using System.ComponentModel.DataAnnotations;

namespace CustomerDatabase_API.Server.Models
{
    public class CustomerCalls
    {
        public int CallId { get; set; }
        [Required]
        public int CallAttempts { get; set; }
        [Required]
        public string CallNotes { get; set; }
        public int CustomerId { get; set; }
    }
}
