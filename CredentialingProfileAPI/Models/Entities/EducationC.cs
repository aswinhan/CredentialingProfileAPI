using System.ComponentModel.DataAnnotations;

namespace CredentialingProfileAPI.Models.Entities
{
    public class EducationC
    {
        [Key]
        public int Id { get; set; }
        public string? Credentialing_Profile_Id__c { get; set; }
        public string? Degree__c { get; set; }
        public string? College_University_Program_Name__c { get; set; }
        public string? Graduation_Date__c { get; set; }
    }
}
