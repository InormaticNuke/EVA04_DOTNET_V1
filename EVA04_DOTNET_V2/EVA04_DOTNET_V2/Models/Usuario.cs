using Microsoft.AspNetCore.Identity;

namespace EVA04_DOTNET_V2.Models
{
    public class Usuario : IdentityUser
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    }
}
