namespace CredentialingProfileAPI.Models
{
    public class CompositeRequest
    {

        public bool AllOrNone { get; set; }
        public required List<CompositeSubRequest> CompositeSubRequestList { get; set; }
    }
}
