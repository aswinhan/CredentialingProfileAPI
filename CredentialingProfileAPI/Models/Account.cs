﻿using System.ComponentModel.DataAnnotations;

namespace CredentialingProfileAPI.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string? Name { get; set; }
        public bool IsAgency { get; set; }
        public bool IsSite { get; set; }
        public bool IsCMHSP { get; set; }
        public ShippingAddress? ShippingAddress { get; set; }
    }
}
