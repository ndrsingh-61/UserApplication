using System.ComponentModel.DataAnnotations;

namespace UserApp.Models.VM
{
    public class VMRegister
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required (ErrorMessage ="Email is Required.")]
        [RegularExpression(".+\\@.+\\..+")]
        
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Phoneno { get; set; }
    }
}
