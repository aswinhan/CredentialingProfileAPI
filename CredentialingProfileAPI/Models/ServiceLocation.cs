using System.ComponentModel.DataAnnotations;

namespace CredentialingProfileAPI.Models
{
    public class ServiceLocation
    {
        [Key]
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string? AccountSite { get; set; }
        public string? Account { get; set; }        
        public bool FacilityLicenseifapplicable { get; set; }
        public DateTime? FacilityLicenseExpirationifapplicab { get; set; }
        public string? FacilityLicenseNumberifapplicable { get; set; }
        public string? FacilityLicenseStatusifapplicable { get; set; }
        public string? HoursofOperation { get; set; }
        public AccommodationsAccessibility AccomodationsAccessibility { get; set; }
        public string? AccomodationsAccessibilityOther { get; set; }
        public bool LicensedFacility { get; set; }
    }
}
