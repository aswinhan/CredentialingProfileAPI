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
    public class ServiceLocationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ServiceLocationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/ServiceLocation/5
        [HttpGet("services/data/v60.0/sobjects/ServiceLocation/{providerId}")]
        public async Task<ActionResult<ServiceLocation>> GetServiceLocation(int providerId)
        {
            var serviceLocation = await _context.ServiceLocations.FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (serviceLocation == null)
            {
                return NotFound();
            }

            return serviceLocation;
        }
    }
}
