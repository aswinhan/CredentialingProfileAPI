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
    public class PractitionerLicenseCertificationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<PractitionerLicenseCertificationsController> _logger;

        public PractitionerLicenseCertificationsController(ApplicationDbContext context, ProviderService providerService, ILogger<PractitionerLicenseCertificationsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: PractitionerLicenseCertification/5
        [HttpGet("PractitionerLicenseCertification/{credentialingProfileId}")]
        public async Task<ActionResult<PractitionerLicenseCertification>> GetPractitionerLicenseCertification(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var practitionerLicenseCertification = await _context.PractitionerLicenseCertifications
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (practitionerLicenseCertification == null)
                    {
                        return NotFound();
                    }

                    return Ok(practitionerLicenseCertification);
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

        // POST: PractitionerLicenseCertification
        [HttpPost("PractitionerLicenseCertification")]
        public async Task<ActionResult<PractitionerLicenseCertification>> PostPractitionerLicenseCertification(PractitionerLicenseCertification practitionerLicenseCertification)
        {
            try
            {
                if (practitionerLicenseCertification == null)
                {
                    return BadRequest("Account data is null.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _context.PractitionerLicenseCertifications.Add(practitionerLicenseCertification);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetProviderId", new { providerId = practitionerLicenseCertification.ProviderId }, practitionerLicenseCertification);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request.");
            }
        }
    }
}
