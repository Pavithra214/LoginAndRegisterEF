using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FlipLoginAndRegister.Models
{
    public class UserData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        [Required(ErrorMessage ="Customer Name is requried")]
        [Display(Name="Customer Name")]
        public string Name { get; set; }


       
    public string Email { get; set; }

        public string Password { get; set; }
    }
}
