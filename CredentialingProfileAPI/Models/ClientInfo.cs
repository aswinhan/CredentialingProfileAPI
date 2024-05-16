using System.ComponentModel.DataAnnotations;

namespace CredentialingProfileAPI.Models
{
    public class ClientInfo
    {
        [Key]
        public int ClientId { get; set; }
        public int? ParentClientId { get; set; }
        public string? ClientCode { get; set; }
        public Guid? ClientGuid { get; set; }
        public string? ClientName { get; set; }
        public string? DBAName { get; set; }
        public string? TaxID { get; set; }
        public string? ClientType { get; set; }
        public byte? ActiveInd { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? ModUserId { get; set; }
        public string? PanelSize { get; set; }
        public string? CredPeriod { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? ContactName { get; set; }
        public byte? Selectable { get; set; }
        public DateTime? SignatureDate { get; set; }
    }
}
