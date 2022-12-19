using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodOrderApp.Models
{
    public class Message
    {
        [Key]
        [Required]
        public int MessageId { get; set; }

        [Required]
        [DisplayName("Sender Name")]
        public string MessageName { get; set;}

        [Required]
        [DisplayName("Sender Email")]
        public string MessageEmail { get; set;}

        [Required]
        [DisplayName("Sender Subject")]
        public string MessageSubject { get; set;}

        [Required]
        [DisplayName("Sender Message")]
        public string MessageBody { get; set;}

    }
}
