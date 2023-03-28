using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageVersion2022.Models
{
    public class User
    {        
        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public User()
        {
            
        }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;            
        }
    }
}
