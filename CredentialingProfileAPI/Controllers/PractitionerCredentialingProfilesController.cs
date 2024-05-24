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
    public class PractitionerCredentialingProfilesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<PractitionerCredentialingProfilesController> _logger;

        public PractitionerCredentialingProfilesController(ApplicationDbContext context, ProviderService providerService, ILogger<PractitionerCredentialingProfilesController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: PractitionerCredentialingProfile/5
        [HttpGet("PractitionerCredentialingProfile/{credentialingProfileId}")]
        public async Task<ActionResult<PractitionerCredentialingProfile>> GetPractitionerCredentialingProfile(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var practitionerCredentialingProfile = await _context.PractitionerCredentialingProfiles
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (practitionerCredentialingProfile == null)
                    {
                        return NotFound();
                    }

                    return Ok(practitionerCredentialingProfile);
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

        // POST: PractitionerCredentialingProfile
        [HttpPost("PractitionerCredentialingProfile")]
        public async Task<ActionResult<PractitionerCredentialingProfile>> PostPractitionerCredentialingProfile(PractitionerCredentialingProfile practitionerCredentialingProfile)
        {
            try
            {
                if (practitionerCredentialingProfile == null)
                {
                    return BadRequest("PractitionerCredentialingProfile data is null.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _context.PractitionerCredentialingProfiles.Add(practitionerCredentialingProfile);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetProviderId", new { providerId = practitionerCredentialingProfile.ProviderId }, practitionerCredentialingProfile);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request.");
            }
        }
    }
}
