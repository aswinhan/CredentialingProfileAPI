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
    public class ServiceLocationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<DirectServicesController> _logger;

        public ServiceLocationsController(ApplicationDbContext context, ProviderService providerService, ILogger<DirectServicesController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: ServiceLocation/5
        [HttpGet("ServiceLocation/{credentialingProfileId}")]
        public async Task<ActionResult<ServiceLocation>> GetServiceLocation(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var serviceLocation = await _context.ServiceLocations
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (serviceLocation == null)
                    {
                        return NotFound();
                    }

                    return Ok(serviceLocation);
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

        // POST: ServiceLocation
        [HttpPost("ServiceLocation")]
        public async Task<ActionResult<ServiceLocation>> PostServiceLocation(ServiceLocation serviceLocation)
        {
            try
            {
                if (serviceLocation == null)
                {
                    return BadRequest("ServiceLocation data is null.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _context.ServiceLocations.Add(serviceLocation);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetServiceLocationInfoById), new { id = serviceLocation.Id }, serviceLocation);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request.");
            }
        }

        [HttpGet("GetServiceLocationInfoById/{id}")]
        public async Task<ActionResult<ServiceLocation>> GetServiceLocationInfoById(int id)
        {
            var serviceLocation = await _context.ServiceLocations.FindAsync(id);

            if (serviceLocation == null)
            {
                return NotFound();
            }
            return serviceLocation;
        }
    }
}
