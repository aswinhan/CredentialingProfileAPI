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
    public class PractitionerPrimarySourceVerificationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PractitionerPrimarySourceVerificationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/PractitionerPrimarySourceVerification/5
        [HttpGet("services/data/v60.0/sobjects/PractitionerPrimarySourceVerification/{providerId}")]
        public async Task<ActionResult<PractitionerPrimarySourceVerification>> GetPractitionerPrimarySourceVerification(int providerId)
        {
            var practitionerPrimarySourceVerification = await _context.PractitionerPrimarySourceVerifications.FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (practitionerPrimarySourceVerification == null)
            {
                return NotFound();
            }

            return practitionerPrimarySourceVerification;
        }
    }
}
