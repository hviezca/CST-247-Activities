using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Activity1Part3.Models
{
    public class UserModel
    {
        [Required]
        [DisplayName("User Name")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Password")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]
        public string Password { get; set; }

        public string toString()
        {
            return "Name: " + Username + " Password: " + Password;
        }
    }
}