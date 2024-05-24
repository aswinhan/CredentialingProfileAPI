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
    public class ServiceLocationLicensesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<ServiceLocationLicensesController> _logger;

        public ServiceLocationLicensesController(ApplicationDbContext context, ProviderService providerService, ILogger<ServiceLocationLicensesController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: ServiceLocationLicense/5
        [HttpGet("ServiceLocationLicense/{credentialingProfileId}")]
        public async Task<ActionResult<ServiceLocationLicense>> GetServiceLocationLicense(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var serviceLocationLicense = await _context.ServiceLocationLicenses
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (serviceLocationLicense == null)
                    {
                        return NotFound();
                    }

                    return Ok(serviceLocationLicense);
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

        // POST: ServiceLocationLicense
        [HttpPost("ServiceLocationLicense")]
        public async Task<ActionResult<ServiceLocationLicense>> PostServiceLocationLicense(ServiceLocationLicense serviceLocationLicense)
        {
            try
            {
                if (serviceLocationLicense == null)
                {
                    return BadRequest("ServiceLocationLicense data is null.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _context.ServiceLocationLicenses.Add(serviceLocationLicense);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetServiceLocationLicenseInfoById), new { providerId = serviceLocationLicense.ProviderId }, serviceLocationLicense);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request.");
            }
        }

        [HttpGet("GetServiceLocationLicenseInfoById/{id}")]
        public async Task<ActionResult<ServiceLocationLicense>> GetServiceLocationLicenseInfoById(int id)
        {
            var serviceLocationLicense = await _context.ServiceLocationLicenses.FindAsync(id);

            if (serviceLocationLicense == null)
            {
                return NotFound();
            }
            return serviceLocationLicense;
        }
    }
}
