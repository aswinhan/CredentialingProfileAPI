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
    public class OrganizationalCredentialingProfilesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<OrganizationalCredentialingProfilesController> _logger;
        public OrganizationalCredentialingProfilesController(ApplicationDbContext context, ProviderService providerService, ILogger<OrganizationalCredentialingProfilesController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: services/OrganizationalCredentialingProfile/5
        [HttpGet("services/OrganizationalCredentialingProfile/{credentialingProfileId}")]
        public async Task<ActionResult<OrganizationalCredentialingProfile>> GetOrganizationalCredentialingProfile(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var organizationalCredentialingProfile = await _context.OrganizationalCredentialingProfiles
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (organizationalCredentialingProfile == null)
                    {
                        return NotFound();
                    }

                    return Ok(organizationalCredentialingProfile);
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
