using System.ComponentModel.DataAnnotations;

namespace BookManagement.ViewModels
{
    public class AddRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
