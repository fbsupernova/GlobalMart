using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalMartWeb.VMModels
{
    public class ClientVM
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage ="Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="E-Mail is required.")]
        [EmailAddress]
        [Display(Name ="E-mail")]
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}