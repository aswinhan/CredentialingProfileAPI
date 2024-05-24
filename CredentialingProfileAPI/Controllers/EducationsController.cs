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
    public class EducationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<EducationsController> _logger;

        public EducationsController(ApplicationDbContext context, ProviderService providerService, ILogger<EducationsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: Education/5
        [HttpGet("Education/{credentialingProfileId}")]
        public async Task<ActionResult<Education>> GetEducation(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var education = await _context.Educations
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (education == null)
                    {
                        return NotFound();
                    }

                    return Ok(education);
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

        [HttpPost("Education")]
        public async Task<ActionResult<Education>> PostEducation(Education education)
        {
            try
            {
                if (education == null)
                {
                    return BadRequest("Education data is null.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.Educations.Add(education);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetEducationInfoById), new { providerId = education.ProviderId }, education);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request.");
            }
        }

        [HttpGet("GetEducationInfoById/{id}")]
        public async Task<ActionResult<Education>> GetEducationInfoById(int id)
        {
            var education = await _context.Educations.FindAsync(id);

            if (education == null)
            {
                return NotFound();
            }
            return education;
        }

    }
}
