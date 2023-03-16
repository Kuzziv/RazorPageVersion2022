using System.ComponentModel.DataAnnotations;

namespace RazorPageVersion2022.Models
{
    public class Item
    {
        [Display(Name = "Item ID")]
        [Required(ErrorMessage = "Der skal angives et Id til Item")]
        [Range(typeof(int), minimum:"0", maximum:"10000", ErrorMessage = "ID Skal være mellem {1} og {2}")]
        public int? Id { get; set; }

        [Display(Name = "Item Navn")]
        [Required(ErrorMessage = "Item skal have et navn"), MaxLength(20)]
        public string Name { get; set; }

        [Display(Name = "Pris")]
        [Required(ErrorMessage = "Der skal angives en pris")]
        [Range(typeof(double), minimum:"0", maximum:"100000", ErrorMessage = "Prisen skal være mellem {1} og {2}")]
        public double? Price { get; set; }

        public Item()
        {
            
        }

        public Item(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
