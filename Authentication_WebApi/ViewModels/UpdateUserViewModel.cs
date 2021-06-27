using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication_WebApi.ViewModels
{
    public class UpdateUserViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }

        [Required]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Required]
        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = "New Password and Confirmation Password do not match!")]
        public string ConfirmNewPassword { get; set; }
    }
}
