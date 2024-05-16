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
    public class HospitalAffiliationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HospitalAffiliationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/HospitalAffiliation/5
        [HttpGet("services/data/v60.0/sobjects/HospitalAffiliation/{providerId}")]
        public async Task<ActionResult<HospitalAffiliation>> GetHospitalAffiliation(int providerId)
        {
            var hospitalAffiliation = await _context.HospitalAffiliations.FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (hospitalAffiliation == null)
            {
                return NotFound();
            }

            return hospitalAffiliation;
        }
    }
}
