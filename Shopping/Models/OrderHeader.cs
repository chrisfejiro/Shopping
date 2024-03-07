using Shopping.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    public class OrderHeader
    {
        [Key]
        public int OrderHeaderId { get; set; }
        [Required]
        public string PickupName { get; set; }
        [Required]
        public string PickupPhoneNumber { get; set; }
        [Required]
        public string PickupEmail { get; set; }

        public string ApplicationUserId { get; set; }//only if a user is registered before an order can be placed thats why i am putting it as a foreign key to the user table.
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser User { get; set; }
        public double OrderTotal { get; set; }


        public DateTime OrderDate { get; set; }
        public string StripePaymentIntentID { get; set; }
        public string Status { get; set; }
        public int TotalItems { get; set; }

        public IEnumerable<OrderDetails> OrderDetails { get; set; }
    }
}
