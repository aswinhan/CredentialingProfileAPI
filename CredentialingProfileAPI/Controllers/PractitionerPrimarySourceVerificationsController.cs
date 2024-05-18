using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CredentialingProfileAPI.Models;
using CredentialingProfileAPI.Data;
using CredentialingProfileAPI.Controllers.Services;

namespace CredentialingProfileAPI.Controllers
{
    [ApiController]
    public class PractitionerPrimarySourceVerificationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<PractitionerPrimarySourceVerificationsController> _logger;

        public PractitionerPrimarySourceVerificationsController(ApplicationDbContext context, ProviderService providerService, ILogger<PractitionerPrimarySourceVerificationsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: services/PractitionerPrimarySourceVerification/5
        [HttpGet("services/PractitionerPrimarySourceVerification/{credentialingProfileId}")]
        public async Task<ActionResult<PractitionerPrimarySourceVerification>> GetPractitionerPrimarySourceVerification(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var practitionerPSV = await _context.PractitionerPrimarySourceVerifications
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (practitionerPSV == null)
                    {
                        return NotFound();
                    }

                    return Ok(practitionerPSV);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching the account.");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
