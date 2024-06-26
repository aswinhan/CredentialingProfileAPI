﻿namespace CredentialingProfileAPI.Models
{
    public class Enum
    {
    }

    public enum PSVStatus
    {
        InProgress,
        Complete,
        ExpiredLicensureCertification,
        Expired,
        CVOInProgress
    }
    public enum VerifierCredentialingOrganization
    {
        COA,
        NCQA,
        JointCommission,
        URAC,
        Other,
        CARF,
        None
    }
    public enum LARALicense
    {
        Acupuncture,
        Audiology,
        AddictionMedicine,
        BehaviorAnalysts,
        Counseling,
        GeneticCounseling,
        MarriageAndFamilyTherapy,
        MassageTherapy,
        Medicine,
        Nursing,
        NursingHomeAdministrator,
        OccupationalTherapy,
        OsteopathicMedicineSurgery,
        Pharmacy,
        PhysicalTherapy,
        PhysicianAssistantPA,
        Psychology,
        RespiratoryCare,
        SocialWorker,
        SpeechLanguagePathology,
        NursePractitionerNP,
        Other
    }
    public enum ContactPersonRole
    {
        PrimaryContact,
        ComplianceOfficer,
        QualityImprovementOfficer,
        CredentialingContact,
        ProgramManager,
        RecipientRightsOfficer,
        CEO,
        CFO,
        CustomerService
    }
    public enum AccreditingBody
    {
        MDCH,
        CARF,
        TJC,
        NCQA,
        URAC,
        CHAP,
        COA,
        AOA,
        Other
    }
    public enum ProfessionalLiabilityStatus
    {
        Active,
        Expired
    }
    public enum ActionPendingOrgLicence
    {
        Yes,
        No
    }
    public enum CommercialLiabilityStatus
    {
        Active,
        Expired
    }
    public enum CyberLiabilityStatus
    {
        Active,
        Expired
    }
    public enum DisclosureFormStatus
    {
        Active,
        Expired
    }
    public enum OrgAccreditationLimited
    {
        Yes,
        No,
        NA
    }
    public enum OrgDefendantSUDPayment
    {
        Yes,
        No
    }
    public enum OrgInsuranceInitiallyRefused
    {
        Yes,
        No
    }
    public enum OrgMalpracticeClaimsSUD
    {
        Yes,
        No
    }
    public enum OrgMedicaidSanctions
    {
        Yes,
        No
    }
    public enum OrgMedicareSanctions
    {
        Yes,
        No
    }
    public enum W9Status
    {
        Active,
        Expired
    }
    public enum WorkersCompensationStatus
    {
        Active,
        Expired
    }
    public enum MedicalTrainingType
    {
        Internship,
        Residencies,
        Fellowships,
        Preceptorships
    }
    public enum AccreditationActionPending
    {
        Yes,
        No,
        NA
    }
    public enum CulturalCompetenciesPickList
    {
        Yes,
        No
    }
    public enum LicenseCertificationType
    {
        License,
        Certification,
        NursingCertification
    }
    public enum LicenseTypeLARA
    {
        Acupuncture,
        Audiology,
        AddictionMedicine,
        BehaviorAnalysts,
        Counseling,
        GeneticCounseling,
        MarriageAndFamilyTherapy,
        MassageTherapy,
        Medicine,
        Nursing,
        NursingHomeAdministrator,
        OccupationalTherapy,
        OsteopathicMedicineAndSurgery,
        Pharmacy,
        PhysicalTherapy,
        PhysicianAssistant,
        Psychology,
        RespiratoryCare,
        SocialWorker,
        SpeechLanguagePathology,
        NursePractitioner,
        Other,
        Psychiatry
    }
    public enum BoardCertifications
    {
        MCBAP_MI_Certification_Board_for_Addiction_Professionals,
        AMA_American_Medical_Association,
        ABPM_American_Board_of_Preventative_Medicine,
        BACB_Behavior_Analyst_Certification_Board,
        ABPN_American_Board_of_Psychiatry_and_Neurology,
        ABFM_American_Board_of_Family_Medicine,
        ABIM_American_Board_of_Internal_Medicine,
        ABNS_American_Board_of_Neurological_Surgery,
        ABEM_American_Board_of_Emergency_Medicine,
        NBCOT_National_Board_for_Certification_in_Occupational_Therapy,
        AOA_American_Osteopathic_Association_Board_Certification,
        BPS_Board_of_Pharmacy_Specialties,
        APTA_MI_American_Physical_Therapy_Association_MI,
        NCCPA_National_Commission_for_Certifying_Physician_Assistants,
        ABPP_American_Board_of_Professional_Psychology,
        NBRC_National_Board_for_Respiratory_Care,
        BCD_Board_Certified_Diplomate_in_Clinical_Social_Work,
        ANCDS_Academy_of_Neurologic_Communication_Disorders_and_Sciences,
        AANPCB_American_Academy_of_Nurse_Practitioners_Certification_Board,
        Other
    }
    public enum NursingCertifications
    {
        Adult_Gerontology_Primary_Care_Nurse_Practitioner,
        Advanced_HIV_AIDS_Certified_Registered_Nurse,
        Clinical_Nurse_Specialist_Wellness_through_Acute_Care_Adult_Gerontology,
        Clinical_Nurse_Specialist_Wellness_through_Acute_Care_Neonatal,
        Clinical_Nurse_Specialist_Wellness_through_Acute_Care_Pediatric,
        Advanced_Certified_Hospice_and_Palliative_Nurse,
        Acute_Care_Nurse_Practitioner,
        Acute_Care_Nurse_Practitioner_Adult_Gerontology,
        Adult_Health_Clinical_Nurse_Specialist,
        HIV_AIDS_Certified_Registered_Nurse,
        Advanced_Diabetes_Management_specialty_certification_retired_exam,
        Advanced_Diabetes_Management,
        Certified_Asthma_Educator,
        Advanced_Forensic_Nursing,
        Adult_Gerontology_Acute_Care_Nurse_Practitioner,
        Adult_Gerontology_Clinical_Nurse_Specialist,
        Genetics_Nursing_Advanced,
        Advanced_Holistic_Nurse_Board_Certified,
        Adult_Nurse_Practitioner,
        Acute_Care_Nurse_Practitioner_Adult,
        Advanced_Oncology_Certified_Nurse,
        Advanced_Oncology_Certified_Nurse_Practitioner,
        Advanced_Oncology_Certified_Clinical_Nurse_Specialist,
        Advanced_Practice_Holistic_Nurse,
        Board_Certified_Advanced_Diabetes_Management,
        Blood_Marrow_Transplant_Certified_Nurse,
        Electronic_Fetal_Monitoring,
        Neonatal_Pediatric_Transport,
        Certified_Aesthetic_Nurse_Specialist,
        Certified_Ambulatory_Perianesthesia_Nurse,
        Certified_Addictions_Registered_Nurse,
        Certified_Addictions_Registered_Nurse_Advanced_Practice,
        Certified_Breast_Feeding_Counselor,
        Certified_Breast_Care_Nurse,
        Correctional_Behavioral_Health_Certification,
        Certified_Continence_Care_Nurse,
        Certified_Continence_Care_Nurse_Advanced_Practice,
        Certified_Childbirth_Educator,
        Certified_Correctional_Health_Professional_Advanced,
        Certified_Correctional_Health_Professional_RN,
        Certified_Clinical_Hemodialysis_Technician,
        Certified_Clinical_Hemodialysis_Technician_Advanced,
        Acute_Critical_Care_Clinical_Nurse_Specialist_Adult_Pediatric_and_Neonatal,
        Certified_Clinical_Research_Associate,
        Certified_Clinical_Research_Coordinator,
        Acute_Critical_Care_Nursing_Adult_Pediatric_and_Neonatal,
        Tele_ICU_Acute_Critical_Care_Nursing_Adult,
        Acute_Critical_Care_Knowledge_Professional_Adult_Pediatric_and_Neonatal,
        Certified_Clinical_Research_Professional,
        Certified_in_Care_Coordination_and_Transition_Management,
        Certified_Dialysis_Licensed_Practical_Nurse,
        Certified_Dialysis_Licensed_Vocational_Nurse,
        Certified_Diabetes_Educator,
        Certified_Dialysis_Nurse,
        Certified_Emergency_Nurse,
        Certified_in_Executive_Nursing_Practice,
        Certified_Foot_Care_Nurse,
        Certified_Flight_Registered_Nurse,
        Certified_Gastroenterology_Registered_Nurse,
        Certified_Heart_Failure_Nurse,
        Non_Clinical_HeartFailure_Nurse,
        Certified_Hospice_and_Palliative_Care_Administrator,
        Certified_Hospice_and_Palliative_Licensed_Nurse,
        Certified_Hospice_and_Palliative_Nurse,
        Certified_Hospice_and_Palliative_Nursing_Assistant,
        Certified_Hospice_and_Palliative_Pediatric_Nurse,
        Certified_Health_Service_Administrator,
        Certified_Lactation_Counselor,
        Certified_in_Infection_Control,
        Occupational_Health_Nursing_Case_Management,
        Cardiac_Medicine_Adult,
        Certification_in_Managed_Care_Nursing,
        Certified_Medical_Surgical_Registered_Nurse,
        Certified_Ambulatory_Surgery_Nurse,
        Certified_Nurse_Educator,
        Certified_Academic_Clinical_Nurse_Educator,
        Clinical_Nurse_Leader,
        Nurse_Manager_and_Leader,
        Certified_Nurse_Manager_and_Leader,
        Certified_Corrections_Nurse,
        Certified_Nephrology_Nurse,
        Certified_Nephrology_Nurse_Nurse_Practitioner,
        Certified_Corrections_Nurse_Manager,
        Certified_Perioperative_Nurse,
        Certified_Neuroscience_Registered_Nurse,
        Clinical_Nurse_Specialist_Core,
        Certified_Clinical_Nurse_Specialist_Perioperative,
        Certified_Ostomy_Care_Nurse,
        Certified_Ostomy_Care_Nurse_Advanced_Practice,
        Certified_Occupational_Health_Nurse,
        Certified_Occupational_Health_Nurse_Specialist,
        Certified_Otorhinolaryngology_Nurse,
        Certified_Post_Anesthesia_Nurse,
        Certified_Pediatric_Emergency_Nurse,
        Certified_Pediatric_Hematology_Oncology_Nurse,
        Certified_Professional_in_Healthcare_Quality,
        Certified_Professional_in_Healthcare_Risk_Management,
        Certified_in_Perinatal_Loss_Care,
        Certified_Pediatric_Nurse,
        Certified_Pediatric_Nurse_Practitioner_Primary_Care,
        Certified_Pediatric_Oncology_Nurse,
        Certified_Pediatric_Nurse_Practitioner_Acute_Care,
        Certified_Plastic_Surgical_Nurse,
        Certified_Radiologic_Nurse,
        Certified_Registered_Nurse_Anesthetist,
        Certified_Registered_Nurse_First_Assistant,
        Certified_Registered_Nurse_Infusion,
        Certification_for_Registered_Nurses_of_Ophthalmology,
        Certified_Rehabilitation_Registered_Nurse,
        Cardiac_Surgery_Adult,
        Certified_Surgical_Services_Manager,
        Certified_Transport_Registered_Nurse,
        Urologic_Associate,
        Certified_Urologic_Nurse_Practitioner,
        Certified_Urologic_Registered_Nurse,
        Certified_Wound_Care_Nurse,
        Certified_Wound_Care_Nurse_Advanced_Practice,
        Certified_Wound_Ostomy_Continence_Nurse,
        Certified_Wound_Ostomy_Continence_Nurse_Advanced_Practice,
        Certified_Wound_Ostomy_Nurse,
        Certified_Wound_Ostomy_Nurse_Advanced_Practice,
        Dermatology_Certified_Nurse_Practitioner,
        Dermatology_Nurse_Certified,
        Emergency_Nurse_Practitioner_specialty_certification,
        Family_Nurse_Practitioner,
        Gerontological_Nurse_Practitioner,
        Holistic_Nurse_Board_Certified,
        Holistic_Baccalaureate_Nurse_Board_Certified,
        Health_and_Wellness_Nurse_Coach_Board_Certified,
        International_Board_Certified_Lactation_Consultant,
        Legal_Nurse_Consultant_Certified,
        Nurse_Coach_Board_Certified,
        National_Certified_School_Nurse,
        Nurse_Executive,
        Nurse_Executive_Advanced,
        NNP_BC_Neonatal_Nurse_Practitioner,
        Adult_Nurse_Practitioner_2,
        Oncology_Certified_Nurse,
        Orthopaedic_Clinical_Nurse_Specialist_Certified,
        Orthopaedic_Nurse_Certified,
        Orthopaedic_Nurse_Practitioner_Certified,
        Progressive_Care_Nursing_Adult,
        Progressive_Care_Knowledge_Professional_Adult,
        Pediatric_Clinical_Nurse_Specialist,
        Public_Community_Health_Clinical_Nurse_Specialist_retired_exam,
        Pediatric_Primary_Care_Mental_Health_Specialist,
        Public_Health_Nursing_Advanced,
        Adult_Psychiatric_Mental_Health_Clinical_Nurse_Specialist,
        Child_Adolescent_Psychiatric_Mental_Health_Clinical_Nurse_Specialist,
        Adult_Psychiatric_Mental_Health_Nurse_Practitioner,
        Psychiatric_Mental_Health_Nurse_Practitioner_across_the_life_span,
        Pediatric_Primary_Care_Nurse_Practitioner,
        Ambulatory_Care_Nursing,
        Cardiac_Vascular_Nursing,
        Certified_Vascular_Nurse_retired_exam,
        College_Health_Nursing_retired_exam,
        Community_Health_Nursing_retired_exam,
        Faith_Community_Nursing,
        Genetics_Nursing_Advanced_2,
        General_Nursing_Practice_retired_exam,
        Gerontological_Nursing,
        Hemostasis_Nursing,
        High_Risk_Perinatal_Nursing_retired_exam,
        Home_Health_Nursing_retired_exam,
        Informatics_Nursing,
        Medical_Surgical_Nursing,
        Nursing_Case_Management,
        Nursing_Professional_Development,
        Pain_Management_Nursing,
        Pediatric_Nursing,
        Perinatal_Nursing_retired_exam,
        Psychiatric_Mental_Health_Nursing,
        Public_Health_Nursing_Advanced_2,
        Rheumatology_Nursing,
        School_Nursing_retired_exam,
        RNC_LRN_Low_Risk_Neonatal_Nursing,
        RNC_MNN_Maternal_Newborn_Nursing,
        RNC_NIC_Neonatal_Intensive_Care_Nursing,
        RNC_OB_Inpatient_Obstetric_Nursing,
        Sexual_Assault_Nurse_Examiner_Adult_Adolescent,
        Sexual_Assault_Nurse_Examiner_Pediatric,
        Stroke_Certified_Registered_Nurse,
        School_Nurse_Practitioner_retired_exam,
        Trauma_Certified_Registered_Nurse,
        WHNP_BC_Womens_Health_Care_Nurse_Practitioner
    }
    public enum LicenseCertificationStatus
    {
        Active,
        Expired
    }
    public enum AccommodationsAccessibility
    {
        AccessibleAlarms,
        AccessibleDrinkingFountains,
        AccessibleEntrance,
        AccessibleParking,
        AccessibleRoute,
        AccessibleTelephones,
        Accessibletreatmentrooms,
        Accessiblerestrooms,
        Automaticdoorsdoorbell,
        ElevatorornoSteps,
        Grabbarsinrestrooms,
        Handicapaccessibleofficebuilding,
        HearingImpaired,
        Intercomsinresidentialbathrooms,
        Interpretersavailable,
        Reasonableaccommodations,
        SpeechImpaired,
        VisuallyImpaired,
        Wheelchair,
        None,
        Other
    }

}
