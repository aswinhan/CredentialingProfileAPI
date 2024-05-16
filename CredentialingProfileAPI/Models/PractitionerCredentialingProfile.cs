using System.ComponentModel.DataAnnotations;

namespace CredentialingProfileAPI.Models
{
    public class PractitionerCredentialingProfile
    {
        [Key]
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string? CredentialingProfileId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public long MedicareNumber { get; set; }
        public long PractitionerNPI { get; set; }
        public string? HomeAddressStreet1 { get; set; }
        public string? HomeAddressStreet2 { get; set; }
        public string? HomeAddressCity { get; set; }
        public string? HomeAddressZipcode { get; set; }
        public string? HomeAddressState { get; set; }
        public string? HomeAddressCounty { get; set; }
        public string? OtherSpecialty { get; set; }
        public bool CertificateofLiability { get; set; }
        public DateTime CertificateofLiabilityExpirationDate { get; set; }
        public string? CurrentMalpracticeInsuranceCoverage { get; set; }
        public string? ExplanationCurrentMalpractice { get; set; }
        public bool FileMalpracticeInsuranceCoverage { get; set; }
        public DateTime MalpracticeInsuranceCoverageExpiration { get; set; }
        public string? LanguagesSpoken { get; set; }
        public string? CulturalCompetences { get; set; }
        public bool Fiveyearworkhistory { get; set; }
        public AccreditationActionPending X6monthgapinemploymentsinceprofess { get; set; }
        public DateTime X6MonthGapStartDate { get; set; }
        public DateTime X6MonthGapEndDate { get; set; }
        public string? X6MonthGapActivity { get; set; }
        public string? X6MonthGapReason { get; set; }
        public bool Canyouperformtheessentialdutiesof { get; set; }
        public string? Reasonforinabilitytoperformessentia { get; set; }
        public bool Lackofpresentillegaldruguse { get; set; }
        public string? ExplanationLackofpresentillegaldrug { get; set; }
        public bool Historyoflossoflicense { get; set; }
        public string? ExplanationHistoryoflossoflicense { get; set; }
        public string? Historyoffelonyconvictions { get; set; }
        public string? ExplanationHistoryoffelonyconvictions { get; set; }
        public string? Historyoflossorlimitationsofprivil { get; set; }
        public string? ExplanationHistoryofloss { get; set; }
        public CulturalCompetenciesPickList CulturalCompetenciesPicklist { get; set; }
        public string? OfficeAddressStreet1 { get; set; }
        public string? OfficeAddressStreet2 { get; set; }
        public string? OfficeAddressCity { get; set; }
        public string? OfficeAddressZipcode { get; set; }
        public string? OfficeAddressState { get; set; }
        public string? OfficeAddressCounty { get; set; }
        public bool PleaseacknowledgeIfdeniedcredential { get; set; }
        public string? SummaryofChanges { get; set; }
        public DateTime SubmissionDate { get; set; }
    }
}
