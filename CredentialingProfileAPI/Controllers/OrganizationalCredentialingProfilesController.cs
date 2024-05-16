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
    public class OrganizationalCredentialingProfilesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrganizationalCredentialingProfilesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/OrganizationalCredentialingProfile/5
        [HttpGet("services/data/v60.0/sobjects/OrganizationalCredentialingProfile/{providerId}")]
        public async Task<ActionResult<OrganizationalCredentialingProfile>> GetOrganizationalCredentialingProfile(int providerId)
        {
            var organizationalCredentialingProfile = await _context.OrganizationalCredentialingProfiles.FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (organizationalCredentialingProfile == null)
            {
                return NotFound();
            }

            return organizationalCredentialingProfile;
        }
    }
}
