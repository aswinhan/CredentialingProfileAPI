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
    public class EducationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EducationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/Education/5
        [HttpGet("services/data/v60.0/sobjects/Education/{providerId}")]
        public async Task<ActionResult<Education>> GetEducation(int providerId)
        {
            var education = await _context.Educations.FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (education == null)
            {
                return NotFound();
            }

            return education;
        }
    }
}
