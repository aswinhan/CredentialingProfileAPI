using System.ComponentModel.DataAnnotations;

namespace CredentialingProfileAPI.Models
{
    public class CredentialingContact
    {
        [Key]
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string? CredentialingProfileId { get; set; }
        public string? ContactFirstName { get; set; }
        public string? ContactLastName { get; set; }
        public string? ContactEmail { get; set; }        
        public ContactPersonRole ContactPersonRole { get; set; }
        public string? ContactPhone { get; set; }
        public bool? PrimaryContact { get; set; }
        
    }
}
