using System.ComponentModel.DataAnnotations;

namespace CredentialingProfileAPI.Models
{
    public class ClientProviderInfo
    {
        [Key]
        public int ClientProviderId { get; set; }
        public int? ClientId { get; set; }
        public int? ProviderId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? ModUserId { get; set; }
    }
}
