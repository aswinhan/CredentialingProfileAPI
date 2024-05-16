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
    public class DirectServicesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DirectServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/DirectService/5
        [HttpGet("services/data/v60.0/sobjects/DirectService/{providerId}")]
        public async Task<ActionResult<DirectService>> GetDirectService(int providerId)
        {
            var directService = await _context.DirectServices.FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (directService == null)
            {
                return NotFound();
            }

            return directService;
        }
    }
}
