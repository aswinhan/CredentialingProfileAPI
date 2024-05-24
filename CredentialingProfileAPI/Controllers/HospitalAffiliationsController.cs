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

        // GET: HospitalAffiliation/5
        [HttpGet("HospitalAffiliation/{credentialingProfileId}")]
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

        // POST: HospitalAffiliation
        [HttpPost("HospitalAffiliation")]
        public async Task<ActionResult<HospitalAffiliation>> PostHospitalAffiliation(HospitalAffiliation hospitalAffiliation)
        {
            try
            {
                if (hospitalAffiliation == null)
                {
                    return BadRequest("HospitalAffiliation data is null.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _context.HospitalAffiliations.Add(hospitalAffiliation);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetHospitalAffiliationInfoById), new { id = hospitalAffiliation.Id }, hospitalAffiliation);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request.");
            }
        }

        [HttpGet("GetHospitalAffiliationInfoById/{id}")]
        public async Task<ActionResult<HospitalAffiliation>> GetHospitalAffiliationInfoById(int id)
        {
            var hospitalAffiliation = await _context.HospitalAffiliations.FindAsync(id);

            if (hospitalAffiliation == null)
            {
                return NotFound();
            }
            return hospitalAffiliation;
        }
    }
}
