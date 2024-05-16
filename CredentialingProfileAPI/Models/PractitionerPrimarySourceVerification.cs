using System.ComponentModel.DataAnnotations;

namespace CredentialingProfileAPI.Models
{
    public class PractitionerPrimarySourceVerification
    {
        [Key]
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string? CredentialingProfileId { get; set; }
        public string? Name { get; set; }
        public PSVStatus PSVStatus { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public VerifierCredentialingOrganization VerifiersCredentialingOrganization { get; set; }
        public string? OtherAccred { get; set; }
        public string? ProviderName { get; set; }
        public string? PrimarySourceVerifier { get; set; }        
        public string? OwnerId { get; set; }
        public LARALicense LARALicense { get; set; }
        public bool MDHHSSanctionedProviderCheck { get; set; }
        public bool OfficeofInspectorGeneralCheck { get; set; }
        public bool SAMgovCheck { get; set; }
        public bool IchatBackgroundCheck { get; set; }
        public bool WorkforceBackgroundCheck { get; set; }
        public bool MedicareBaseEnrollment { get; set; }
        public bool MedicareOptOut { get; set; }
        public bool LARAUploaded { get; set; }
        public bool OfficialTranscriptfromAccreditedScho { get; set; }
        public bool DegreeVerification { get; set; }
        public bool ECFMG { get; set; }
        public bool AMAVerification { get; set; }
        public bool AOAVerification { get; set; }
        public bool MCBAPVerification { get; set; }
        public bool MIPublicSexOffenderRegistryCheck { get; set; }
        public bool NationalSexOffenderRegistryCheck { get; set; }
    }
}
