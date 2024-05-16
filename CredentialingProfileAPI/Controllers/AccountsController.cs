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
    public class AccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AccountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/Account/5
        [HttpGet("services/data/v60.0/sobjects/Account/{providerId}")]
        public async Task<ActionResult<Account>> GetAccount(int providerId)
        {
            var account = await _context.Accounts.Include(a => a.ShippingAddress).FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (account == null)
            {
                return NotFound();
            }

            return account;
        }
    }
}
