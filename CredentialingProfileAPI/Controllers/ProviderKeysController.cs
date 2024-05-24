using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CredentialingProfileAPI.Data;
using CredentialingProfileAPI.Models;

namespace CredentialingProfileAPI.Controllers
{
    [ApiController]
    public class ProviderKeysController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProviderKeysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProviderKey/5
        [HttpGet("ProviderKey/{id}")]
        public async Task<ActionResult<ProviderKey>> GetProviderKey(int id)
        {
            var providerKey = await _context.ProviderKeys.FindAsync(id);

            if (providerKey == null)
            {
                return NotFound();
            }

            return providerKey;
        }

        // POST: ProviderKey
        [HttpPost("ProviderKey/")]
        public async Task<ActionResult<ProviderKey>> PostProviderKey(ProviderKey providerKey)
        {
            _context.ProviderKeys.Add(providerKey);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProviderKeyInfoById), new { providerId = providerKey.ProviderId }, providerKey);
        }

        [HttpGet("GetProviderKeyInfoById/{id}")]
        public async Task<ActionResult<ProviderKey>> GetProviderKeyInfoById(int id)
        {
            var providerKey = await _context.ProviderKeys.FindAsync(id);

            if (providerKey == null)
            {
                return NotFound();
            }
            return providerKey;
        }

    }
}
