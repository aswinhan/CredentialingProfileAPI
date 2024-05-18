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
    public class HospitalAffiliationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<HospitalAffiliationsController> _logger;

        public HospitalAffiliationsController(ApplicationDbContext context, ProviderService providerService, ILogger<HospitalAffiliationsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: services/HospitalAffiliation/5
        [HttpGet("services/HospitalAffiliation/{credentialingProfileId}")]
        public async Task<ActionResult<HospitalAffiliation>> GetHospitalAffiliation(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var hospitalAffiliation = await _context.HospitalAffiliations
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (hospitalAffiliation == null)
                    {
                        return NotFound();
                    }

                    return Ok(hospitalAffiliation);
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
