﻿using System;
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

        // GET: api/ProviderKeys/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProviderKey>> GetProviderKey(int id)
        {
            var providerKey = await _context.ProviderKeys.FindAsync(id);

            if (providerKey == null)
            {
                return NotFound();
            }

            return providerKey;
        }

        // POST: services/ProviderKeys
        [HttpPost("services/ProviderKeys/")]
        public async Task<ActionResult<ProviderKey>> PostProviderKey(ProviderKey providerKey)
        {
            _context.ProviderKeys.Add(providerKey);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProviderId", new { providerId = providerKey.ProviderId }, providerKey);
        }

    }
}
