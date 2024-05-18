using System.ComponentModel.DataAnnotations;

namespace CredentialingProfileAPI.Models
{
    public class OrganizationalPrimarySourceVerification
    {
        [Key]
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string? Name { get; set; }
        public PSVStatus PSVStatus { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public VerifierCredentialingOrganization VerifiersCredentialingOrganization { get; set; }
        public string? OtherAccred { get; set; }
        public string? ProviderName { get; set; }
        public string? PrimarySourceVerifier { get; set; }
        public string? CredentialingProfile { get; set; }
        public string? OwnerId { get; set; }
        public LARALicense LARALicense { get; set; }
        public bool MDHHSSanctionedProviderCheck { get; set; }
        public bool OfficeofInspectorGeneralCheck { get; set; }
        public bool SAMgovCheck { get; set; }
        public bool ProofofAccreditation { get; set; }
        public bool Disciplinarystatuswithregulatoryboar { get; set; }
        public bool Atleastfiveyearhistoryoforganizati { get; set; }
        public bool OnSiteQualityAssessmentRecredential { get; set; }
    }
}
