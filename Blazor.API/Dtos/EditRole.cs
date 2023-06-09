using Blazor.API.Enum;
using System.ComponentModel.DataAnnotations;

namespace Blazor.API.Dtos
{
    public class EditRole
    {
        [Required]
        public RoleEnum Role { get; set; }
    }
}
