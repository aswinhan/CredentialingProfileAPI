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
    [Route("api/[controller]")]
    [ApiController]
    public class CredentialingContactsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CredentialingContactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/CredentialingContact/5
        [HttpGet("services/data/v60.0/sobjects/CredentialingContact/{providerId}")]
        public async Task<ActionResult<CredentialingContact>> GetCredentialingContact(int providerId)
        {
            var credentialingContact = await _context.CredentialingContacts.FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (credentialingContact == null)
            {
                return NotFound();
            }

            return credentialingContact;
        }
    }
}
