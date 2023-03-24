using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageVersion2022.Models
{
    public class Item
    {
        [Display(Name = "Item ID")]
        [Required(ErrorMessage = "Der skal angives et ID til Item")]
        [Range(typeof(int), "0", "10000", ErrorMessage = "ID skal være mellem (1) og (2)")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Display(Name = "Item Navn")]
        [Required(ErrorMessage = "Item skal have et navn")]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Pris")]
        [Required(ErrorMessage = "Der skal angives en pris")]
        public decimal? Price { get; set; }

        public int CompereTo(Item order)
        {
            return Id - order.Id;
        }
        public Item()
        {
            
        }

        public Item(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
