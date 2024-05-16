using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CredentialingProfileAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientInfos",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentClientId = table.Column<int>(type: "int", nullable: true),
                    ClientCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DBAName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveInd = table.Column<byte>(type: "tinyint", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanelSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CredPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Selectable = table.Column<byte>(type: "tinyint", nullable: true),
                    SignatureDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientInfos", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "ClientProviderInfos",
                columns: table => new
                {
                    ClientProviderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    ProviderId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientProviderInfos", x => x.ClientProviderId);
                });

            migrationBuilder.CreateTable(
                name: "CredentialingContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersonRole = table.Column<int>(type: "int", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryContact = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredentialingContacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Operator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCertification = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollegeUniversityProgramName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollegeUniversityProgramAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HospitalAffiliations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryofMembership = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalAffiliationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalAffiliationAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDateofAffiliation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateofAffiliation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalAffiliations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationalCredentialingProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVOCredentialingProfile = table.Column<bool>(type: "bit", nullable: false),
                    AccreditationEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccreditationStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccreditingBodyOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccreditingBody = table.Column<int>(type: "int", nullable: false),
                    Actionpendingcurrentaccreditation = table.Column<int>(type: "int", nullable: false),
                    Actionpendingorglicense = table.Column<int>(type: "int", nullable: false),
                    Atleastfiveyearhistoryoforganizati = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attestationbytheapplicantofthecorr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommercialLiabilityExpiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommercialLiability = table.Column<bool>(type: "bit", nullable: false),
                    CommercialLiabilityStatus = table.Column<int>(type: "int", nullable: false),
                    CyberLiabilityExpirationifapplicab = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CyberLiabilityifapplicable = table.Column<bool>(type: "bit", nullable: false),
                    CyberLiabilityStatusifapplicable = table.Column<int>(type: "int", nullable: false),
                    DisclosureFormExpiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisclosureForm = table.Column<bool>(type: "bit", nullable: false),
                    DisclosureFormStatus = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrollmentinMedicaid = table.Column<bool>(type: "bit", nullable: false),
                    EnrollmentinMedicare = table.Column<bool>(type: "bit", nullable: false),
                    Explanationcurrentaccreditation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanationfiveyearhistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanationorgaccreditationlimited = table.Column<int>(type: "int", nullable: false),
                    ExplanationorgdefendantSUDpayment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanationorginsuranceinitiallyrefu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanationorglicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExplanationorgmalpracticeclaimsSUD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanationorgmedicaidsanctions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanationorgmedicaresanctions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiveyearhistoryorgliability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupAffiliation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hastheorganizationeverhaditsaccred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Istheorganizationaccredited = table.Column<bool>(type: "bit", nullable: false),
                    NPI = table.Column<long>(type: "bigint", nullable: false),
                    OfficeFaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeSecondaryPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Orgaccreditationlimited = table.Column<int>(type: "int", nullable: false),
                    OrgdefendantSUDpayment = table.Column<int>(type: "int", nullable: false),
                    Orginsuranceinitiallyrefused = table.Column<int>(type: "int", nullable: false),
                    OrgmalpracticeclaimsSUD = table.Column<int>(type: "int", nullable: false),
                    Orgmedicaidsanctions = table.Column<int>(type: "int", nullable: false),
                    Orgmedicaresanctions = table.Column<int>(type: "int", nullable: false),
                    Pleaseindicateifyouhaveaspeciality = table.Column<bool>(type: "bit", nullable: false),
                    Pleaseindicatewhetherinterpretations = table.Column<bool>(type: "bit", nullable: false),
                    ProfessionalLiabilityExpiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfessionalLiability = table.Column<bool>(type: "bit", nullable: false),
                    ProfessionalLiabilityStatus = table.Column<int>(type: "int", nullable: false),
                    ProofofAccreditationExpiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProofofAccreditation = table.Column<bool>(type: "bit", nullable: false),
                    Specialties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialtyOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxID = table.Column<long>(type: "bigint", nullable: false),
                    W9 = table.Column<bool>(type: "bit", nullable: false),
                    W9Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    W9Status = table.Column<int>(type: "int", nullable: false),
                    Whenwasthelastaccreditationsurvey = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkersCompensationExpiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkersCompensation = table.Column<bool>(type: "bit", nullable: false),
                    WorkersCompensationStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationalCredentialingProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationalPrimarySourceVerifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PSVStatus = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerifiersCredentialingOrganization = table.Column<int>(type: "int", nullable: false),
                    OtherAccred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimarySourceVerifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CredentialingProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LARALicense = table.Column<int>(type: "int", nullable: false),
                    MDHHSSanctionedProviderCheck = table.Column<bool>(type: "bit", nullable: false),
                    OfficeofInspectorGeneralCheck = table.Column<bool>(type: "bit", nullable: false),
                    SAMgovCheck = table.Column<bool>(type: "bit", nullable: false),
                    ProofofAccreditation = table.Column<bool>(type: "bit", nullable: false),
                    Disciplinarystatuswithregulatoryboar = table.Column<bool>(type: "bit", nullable: false),
                    Atleastfiveyearhistoryoforganizati = table.Column<bool>(type: "bit", nullable: false),
                    OnSiteQualityAssessmentRecredential = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationalPrimarySourceVerifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostGraduateMedicalTrainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalTrainingHospitalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalTrainingHospitalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalTrainingType = table.Column<int>(type: "int", nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainingStartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostGraduateMedicalTrainings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PractitionerCredentialingProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicareNumber = table.Column<long>(type: "bigint", nullable: false),
                    PractitionerNPI = table.Column<long>(type: "bigint", nullable: false),
                    HomeAddressStreet1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddressStreet2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddressCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddressZipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddressState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddressCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherSpecialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateofLiability = table.Column<bool>(type: "bit", nullable: false),
                    CertificateofLiabilityExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentMalpracticeInsuranceCoverage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExplanationCurrentMalpractice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileMalpracticeInsuranceCoverage = table.Column<bool>(type: "bit", nullable: false),
                    MalpracticeInsuranceCoverageExpiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LanguagesSpoken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CulturalCompetences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiveyearworkhistory = table.Column<bool>(type: "bit", nullable: false),
                    X6monthgapinemploymentsinceprofess = table.Column<int>(type: "int", nullable: false),
                    X6MonthGapStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    X6MonthGapEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    X6MonthGapActivity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X6MonthGapReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Canyouperformtheessentialdutiesof = table.Column<bool>(type: "bit", nullable: false),
                    Reasonforinabilitytoperformessentia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lackofpresentillegaldruguse = table.Column<bool>(type: "bit", nullable: false),
                    ExplanationLackofpresentillegaldrug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Historyoflossoflicense = table.Column<bool>(type: "bit", nullable: false),
                    ExplanationHistoryoflossoflicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Historyoffelonyconvictions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExplanationHistoryoffelonyconvictions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Historyoflossorlimitationsofprivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExplanationHistoryofloss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CulturalCompetenciesPicklist = table.Column<int>(type: "int", nullable: false),
                    OfficeAddressStreet1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAddressStreet2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAddressCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAddressZipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAddressState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAddressCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PleaseacknowledgeIfdeniedcredential = table.Column<bool>(type: "bit", nullable: false),
                    SummaryofChanges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PractitionerCredentialingProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PractitionerLicenseCertifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordTypeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseCertificationType = table.Column<int>(type: "int", nullable: false),
                    LicenseTypesLARA = table.Column<int>(type: "int", nullable: false),
                    OtherLicenseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoardCertifications = table.Column<int>(type: "int", nullable: false),
                    OtherBoardCertification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NursingCertifications = table.Column<int>(type: "int", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileUploaded = table.Column<bool>(type: "bit", nullable: false),
                    LicenseCertificationStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PractitionerLicenseCertifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PractitionerPrimarySourceVerifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PSVStatus = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerifiersCredentialingOrganization = table.Column<int>(type: "int", nullable: false),
                    OtherAccred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimarySourceVerifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LARALicense = table.Column<int>(type: "int", nullable: false),
                    MDHHSSanctionedProviderCheck = table.Column<bool>(type: "bit", nullable: false),
                    OfficeofInspectorGeneralCheck = table.Column<bool>(type: "bit", nullable: false),
                    SAMgovCheck = table.Column<bool>(type: "bit", nullable: false),
                    IchatBackgroundCheck = table.Column<bool>(type: "bit", nullable: false),
                    WorkforceBackgroundCheck = table.Column<bool>(type: "bit", nullable: false),
                    MedicareBaseEnrollment = table.Column<bool>(type: "bit", nullable: false),
                    MedicareOptOut = table.Column<bool>(type: "bit", nullable: false),
                    LARAUploaded = table.Column<bool>(type: "bit", nullable: false),
                    OfficialTranscriptfromAccreditedScho = table.Column<bool>(type: "bit", nullable: false),
                    DegreeVerification = table.Column<bool>(type: "bit", nullable: false),
                    ECFMG = table.Column<bool>(type: "bit", nullable: false),
                    AMAVerification = table.Column<bool>(type: "bit", nullable: false),
                    AOAVerification = table.Column<bool>(type: "bit", nullable: false),
                    MCBAPVerification = table.Column<bool>(type: "bit", nullable: false),
                    MIPublicSexOffenderRegistryCheck = table.Column<bool>(type: "bit", nullable: false),
                    NationalSexOffenderRegistryCheck = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PractitionerPrimarySourceVerifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceLocationLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceLocations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceLicenseExpirationifapplicabl = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceLicenseNumberifapplicable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceLicenseStatusifapplicable = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLocationLicenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Account = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityLicenseifapplicable = table.Column<bool>(type: "bit", nullable: false),
                    FacilityLicenseExpirationifapplicab = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FacilityLicenseNumberifapplicable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityLicenseStatusifapplicable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoursofOperation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccomodationsAccessibility = table.Column<int>(type: "int", nullable: false),
                    AccomodationsAccessibilityOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensedFacility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    geocodeAccuracy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitude = table.Column<double>(type: "float", nullable: false),
                    longitude = table.Column<double>(type: "float", nullable: false),
                    postalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    CredentialingProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingAddressId = table.Column<int>(type: "int", nullable: true),
                    IsAgency = table.Column<bool>(type: "bit", nullable: false),
                    IsSite = table.Column<bool>(type: "bit", nullable: false),
                    IsCMHSP = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_ShippingAddress_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "ShippingAddress",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ShippingAddressId",
                table: "Accounts",
                column: "ShippingAddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ClientInfos");

            migrationBuilder.DropTable(
                name: "ClientProviderInfos");

            migrationBuilder.DropTable(
                name: "CredentialingContacts");

            migrationBuilder.DropTable(
                name: "DirectServices");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "HospitalAffiliations");

            migrationBuilder.DropTable(
                name: "OrganizationalCredentialingProfiles");

            migrationBuilder.DropTable(
                name: "OrganizationalPrimarySourceVerifications");

            migrationBuilder.DropTable(
                name: "PostGraduateMedicalTrainings");

            migrationBuilder.DropTable(
                name: "PractitionerCredentialingProfiles");

            migrationBuilder.DropTable(
                name: "PractitionerLicenseCertifications");

            migrationBuilder.DropTable(
                name: "PractitionerPrimarySourceVerifications");

            migrationBuilder.DropTable(
                name: "ServiceLocationLicenses");

            migrationBuilder.DropTable(
                name: "ServiceLocations");

            migrationBuilder.DropTable(
                name: "ShippingAddress");
        }
    }
}
