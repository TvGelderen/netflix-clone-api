using System.ComponentModel.DataAnnotations;

namespace NetflixCloneAPI.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; internal set; }
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = Array.Empty<byte>();
        public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();
        public DateTime Created { get; internal set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }
}
