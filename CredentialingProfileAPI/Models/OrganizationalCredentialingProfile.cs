using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace CredentialingProfileAPI.Models
{
    public class OrganizationalCredentialingProfile
    {
        [Key]
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string? CredentialingProfileId { get; set; }
        public bool CVOCredentialingProfile { get; set; }
        public DateTime AccreditationEnd { get; set; }
        public DateTime AccreditationStart { get; set; }
        public string? AccreditingBodyOther { get; set; }
        public AccreditingBody AccreditingBody { get; set; }
        public AccreditationActionPending Actionpendingcurrentaccreditation { get; set; }
        public ActionPendingOrgLicence Actionpendingorglicense { get; set; }
        public string? Atleastfiveyearhistoryoforganizati { get; set; }
        public string? Attestationbytheapplicantofthecorr { get; set; }
        public DateTime CommercialLiabilityExpiration { get; set; }
        public bool CommercialLiability { get; set; }
        public CommercialLiabilityStatus CommercialLiabilityStatus { get; set; }
        public DateTime CyberLiabilityExpirationifapplicab { get; set; }
        public bool CyberLiabilityifapplicable { get; set; }
        public CyberLiabilityStatus CyberLiabilityStatusifapplicable { get; set; }
        public DateTime DisclosureFormExpiration { get; set; }
        public bool DisclosureForm { get; set; }
        public DisclosureFormStatus DisclosureFormStatus { get; set; }
        public string? Email { get; set; }
        public bool EnrollmentinMedicaid { get; set; }
        public bool EnrollmentinMedicare { get; set; }
        public string? Explanationcurrentaccreditation { get; set; }
        public string? Explanationfiveyearhistory { get; set; }
        public OrgAccreditationLimited Explanationorgaccreditationlimited { get; set; }
        public string? ExplanationorgdefendantSUDpayment { get; set; }
        public string? Explanationorginsuranceinitiallyrefu { get; set; }
        public string? Explanationorglicense { get; set; }
        public string? ExplanationorgmalpracticeclaimsSUD { get; set; }
        public string? Explanationorgmedicaidsanctions { get; set; }
        public string? Explanationorgmedicaresanctions { get; set; }
        public string? Fiveyearhistoryorgliability { get; set; }
        public string? GroupAffiliation { get; set; }
        public string? Hastheorganizationeverhaditsaccred { get; set; }
        public bool Istheorganizationaccredited { get; set; }
        public long NPI { get; set; }
        public string? OfficeFaxNumber { get; set; }
        public string? OfficePhoneNumber { get; set; }
        public string? OfficeSecondaryPhoneNumber { get; set; }
        public OrgAccreditationLimited Orgaccreditationlimited { get; set; }
        public OrgDefendantSUDPayment OrgdefendantSUDpayment { get; set; }
        public OrgInsuranceInitiallyRefused Orginsuranceinitiallyrefused { get; set; }
        public OrgMalpracticeClaimsSUD OrgmalpracticeclaimsSUD { get; set; }
        public OrgMedicaidSanctions Orgmedicaidsanctions { get; set; }
        public OrgMedicareSanctions Orgmedicaresanctions { get; set; }
        public bool Pleaseindicateifyouhaveaspeciality { get; set; }
        public bool Pleaseindicatewhetherinterpretations { get; set; }
        public DateTime ProfessionalLiabilityExpiration { get; set; }
        public bool ProfessionalLiability { get; set; }
        public ProfessionalLiabilityStatus ProfessionalLiabilityStatus { get; set; }
        public DateTime ProofofAccreditationExpiration { get; set; }
        public bool ProofofAccreditation { get; set; }
        public string? Specialties { get; set; }
        public string? SpecialtyOther { get; set; }
        public long TaxID { get; set; }
        public bool W9 { get; set; }
        public DateTime W9Expiration { get; set; }
        public W9Status W9Status { get; set; }
        public DateTime Whenwasthelastaccreditationsurvey { get; set; }
        public DateTime WorkersCompensationExpiration { get; set; }
        public bool WorkersCompensation { get; set; }
        public WorkersCompensationStatus WorkersCompensationStatus { get; set; }
    }
    
}
