namespace CredentialingProfileAPI.Models
{
    public class ProviderKey
    {

        public int ProviderId { get; set; }
        public Guid? PractitionerGUID { get; set; }
        public string? EncompassID { get; set; }
        public string? CredentialingProfileId { get; set; }
    }
}
