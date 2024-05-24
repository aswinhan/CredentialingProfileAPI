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
    public class CredentialingContactsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<CredentialingContactsController> _logger;

        public CredentialingContactsController(ApplicationDbContext context , ProviderService providerService, ILogger<CredentialingContactsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: CredentialingContact/5
        [HttpGet("CredentialingContact/{credentialingProfileId}")]
        public async Task<ActionResult<CredentialingContact>> GetCredentialingContact(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var credentialingContact = await _context.CredentialingContacts
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (credentialingContact == null)
                    {
                        return NotFound();
                    }

                    return Ok(credentialingContact);
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

        [HttpPost("CredentialingContact")]
        public async Task<ActionResult<CredentialingContact>> PostCredentialingContact(CredentialingContact credentialingContact)
        {
            try
            {
                if (credentialingContact == null)
                {
                    return BadRequest("Credentialing contact data is null.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.CredentialingContacts.Add(credentialingContact);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetProviderId", new { providerId = credentialingContact.ProviderId }, credentialingContact);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request.");
            }
        }


    }
}
