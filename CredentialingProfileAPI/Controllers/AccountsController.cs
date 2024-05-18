using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CredentialingProfileAPI.Models;
using CredentialingProfileAPI.Data;
using CredentialingProfileAPI.Controllers.Services;

namespace CredentialingProfileAPI.Controllers
{
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(ApplicationDbContext context, ProviderService providerService, ILogger<AccountsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: services/Account/5
        [HttpGet("services/Account/{credentialingProfileId}")]
        public async Task<ActionResult<Account>> GetAccount(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var account = await _context.Accounts
                        .AsNoTracking()
                        .Include(a => a.ShippingAddress)
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (account == null)
                    {
                        return NotFound();
                    }

                    return Ok(account);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                // Log the exception (use a logging framework like Serilog, NLog, etc.)
                _logger.LogError(ex, "An error occurred while fetching the account.");

                // Return a generic error message
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
