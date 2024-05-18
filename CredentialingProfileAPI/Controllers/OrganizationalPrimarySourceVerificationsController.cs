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
    public class OrganizationalPrimarySourceVerificationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<OrganizationalPrimarySourceVerificationsController> _logger;
        public OrganizationalPrimarySourceVerificationsController(ApplicationDbContext context, ProviderService providerService, ILogger<OrganizationalPrimarySourceVerificationsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: services/OrganizationalPSV/5
        [HttpGet("services/OrganizationalPSV/{credentialingProfileId}")]
        public async Task<ActionResult<OrganizationalPrimarySourceVerification>> GetOrganizationalPrimarySourceVerification(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var organizationalPSV = await _context.OrganizationalPrimarySourceVerifications
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (organizationalPSV == null)
                    {
                        return NotFound();
                    }

                    return Ok(organizationalPSV);
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
