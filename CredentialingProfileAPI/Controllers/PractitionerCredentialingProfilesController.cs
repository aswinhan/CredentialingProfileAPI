using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CredentialingProfileAPI.Models;
using CredentialingProfileAPI.Data;

namespace CredentialingProfileAPI.Controllers
{
    [ApiController]
    public class PractitionerCredentialingProfilesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PractitionerCredentialingProfilesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/PractitionerCredentialingProfile/5
        [HttpGet("services/data/v60.0/sobjects/PractitionerCredentialingProfile/{providerId}")]
        public async Task<ActionResult<PractitionerCredentialingProfile>> GetPractitionerCredentialingProfile(int providerId)
        {
            var practitionerCredentialingProfile = await _context.PractitionerCredentialingProfiles.FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (practitionerCredentialingProfile == null)
            {
                return NotFound();
            }

            return practitionerCredentialingProfile;
        }
    }
}
