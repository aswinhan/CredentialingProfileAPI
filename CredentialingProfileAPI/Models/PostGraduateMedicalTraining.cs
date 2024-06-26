﻿using System.ComponentModel.DataAnnotations;

namespace CredentialingProfileAPI.Models
{
    public class PostGraduateMedicalTraining
    {
        [Key]
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string? MedicalTrainingHospitalAddress { get; set; }
        public string? MedicalTrainingHospitalName { get; set; }
        public MedicalTrainingType MedicalTrainingType { get; set; }
        public string? Specialty { get; set; }
        public DateTime TrainingEndDate { get; set; }
        public DateTime TrainingStartDate { get; set; }
    }
    
}
