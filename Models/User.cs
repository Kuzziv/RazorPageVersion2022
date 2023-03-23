using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageVersion2022.Models
{
    public class User
    {
        [Key]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

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
