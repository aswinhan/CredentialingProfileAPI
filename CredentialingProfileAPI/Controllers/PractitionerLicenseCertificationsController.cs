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
    public class PractitionerLicenseCertificationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PractitionerLicenseCertificationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/PractitionerLicenseCertification/5
        [HttpGet("services/data/v60.0/sobjects/PractitionerLicenseCertification/{providerId}")]
        public async Task<ActionResult<PractitionerLicenseCertification>> GetPractitionerLicenseCertification(int providerId)
        {
            var practitionerLicenseCertification = await _context.PractitionerLicenseCertifications.FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (practitionerLicenseCertification == null)
            {
                return NotFound();
            }

            return practitionerLicenseCertification;
        }
    }
}
