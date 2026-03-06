using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Shared.Models.Authentication
{
    public class CreateUser : AuthenticationBase
    {
        [Required]
        public string? FullName { get; set; }

        [Required, Compare(nameof(Password))]
        public string? ConfirmPassword { get; set; }
    }
}
