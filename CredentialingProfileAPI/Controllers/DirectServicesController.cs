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
    public class DirectServicesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<DirectServicesController> _logger;

        public DirectServicesController(ApplicationDbContext context, ProviderService providerService, ILogger<DirectServicesController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: DirectService/5
        [HttpGet("DirectService/{credentialingProfileId}")]
        public async Task<ActionResult<DirectService>> GetDirectService(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var directService = await _context.DirectServices
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (directService == null)
                    {
                        return NotFound();
                    }

                    return Ok(directService);
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

        // POST: DirectService
        [HttpPost("DirectService")]
        public async Task<ActionResult<DirectService>> PostDirectService(DirectService directService)
        {
            try
            {
                if (directService == null)
                {
                    return BadRequest("Direct service data is null.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.DirectServices.Add(directService);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetProviderId", new { providerId = directService.ProviderId }, directService);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request.");
            }
        }

    }
}
