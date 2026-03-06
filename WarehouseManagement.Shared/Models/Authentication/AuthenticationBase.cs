using System.ComponentModel.DataAnnotations;

namespace WarehouseManagement.Shared.Models.Authentication
{
    public class AuthenticationBase
    {
        [EmailAddress, Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
