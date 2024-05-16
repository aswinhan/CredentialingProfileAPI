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
    public class ServiceLocationLicensesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ServiceLocationLicensesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/ServiceLocationLicense/5
        [HttpGet("services/data/v60.0/sobjects/ServiceLocationLicense/{providerId}")]
        public async Task<ActionResult<ServiceLocationLicense>> GetServiceLocationLicense(int providerId)
        {
            var serviceLocationLicense = await _context.ServiceLocationLicenses.FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (serviceLocationLicense == null)
            {
                return NotFound();
            }

            return serviceLocationLicense;
        }
    }
}
