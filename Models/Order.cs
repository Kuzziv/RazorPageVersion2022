using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageVersion2022.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public Item Item { get; set; }

        [Required]
        public int Count { get; set; }

        public Order()
        {
            
        }

        public Order(int orderId, int userId, User user, int itemId, Item item, int count)
        {
            OrderId = orderId;
            Date = DateTime.Now;
            UserId = userId;
            User = user;
            ItemId = itemId;
            Item = item;
            Count = count;
        }
    }
}
