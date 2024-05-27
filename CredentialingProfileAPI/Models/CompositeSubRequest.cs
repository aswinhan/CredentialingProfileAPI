using CredentialingProfileAPI.Models.Entities;

namespace CredentialingProfileAPI.Models
{
    public class CompositeSubRequest
    {
        public string Method { get; set; }
        public string Url { get; set; }
        public string ReferenceId { get; set; }
        public EducationC Body { get; set; }
    }
}
