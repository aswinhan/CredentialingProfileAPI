using System.ComponentModel.DataAnnotations;

namespace CredentialingProfileAPI.Models
{
    public class PractitionerLicenseCertification
    {
        [Key]
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string? RecordTypeId { get; set; }
        public LicenseCertificationType LicenseCertificationType { get; set; }
        public LicenseTypeLARA LicenseTypesLARA { get; set; }
        public string? OtherLicenseType { get; set; }
        public BoardCertifications BoardCertifications { get; set; }
        public string? OtherBoardCertification { get; set; }
        public NursingCertifications NursingCertifications { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool FileUploaded { get; set; }
        public LicenseCertificationStatus LicenseCertificationStatus { get; set; }
    }
}
