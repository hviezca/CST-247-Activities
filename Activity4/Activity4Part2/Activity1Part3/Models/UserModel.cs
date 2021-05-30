using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Activity1Part3.Models
{
    [DataContract]
    public class UserModel
    {
        [DataMember]
        [Required]
        [DisplayName("Id")]
        [DefaultValue("")]
        public int Id { get; set; }

        [DataMember]
        [Required]
        [DisplayName("User Name")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]
        public string Username { get; set; }

        [DataMember]
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