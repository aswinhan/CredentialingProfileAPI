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
    public class OrganizationalPrimarySourceVerificationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrganizationalPrimarySourceVerificationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/OrganizationalPrimarySourceVerification/5
        [HttpGet("services/data/v60.0/sobjects/OrganizationalPrimarySourceVerification/{providerId}")]
        public async Task<ActionResult<OrganizationalPrimarySourceVerification>> GetOrganizationalPrimarySourceVerification(int providerId)
        {
            var organizationalPrimarySourceVerification = await _context.OrganizationalPrimarySourceVerifications.FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (organizationalPrimarySourceVerification == null)
            {
                return NotFound();
            }

            return organizationalPrimarySourceVerification;
        }
    }
}
