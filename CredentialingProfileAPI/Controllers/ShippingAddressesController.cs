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
    [Route("services/[controller]")]
    [ApiController]
    public class ShippingAddressesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShippingAddressesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public int? GetShippingAddressIdAsync(int providerid)
        {
            return  _context.ShippingAddress
            .AsNoTracking()
            .Where(x => x.ProviderId == providerid)
            .Select(x => x.Id)
            .FirstOrDefault();
        }

        // GET: services/ShippingAddresses/5
        [HttpGet("{providerid}")]
        public async Task<ActionResult<ShippingAddress>> GetShippingAddress(int providerid)
        {
            int? id = GetShippingAddressIdAsync(providerid);
            if(id == null)
            {
                return NotFound();
            }

            var shippingAddress = await _context.ShippingAddress.FindAsync(id);

            if (shippingAddress == null)
            {
                return NotFound();
            }

            return shippingAddress;
        }

        //// PUT: api/ShippingAddresses/5
        //[HttpPut("{providerid}")]
        //public async Task<IActionResult> PutShippingAddress(int providerid, ShippingAddress shippingAddress)
        //{
        //    int? id = GetShippingAddressIdAsync(providerid);
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    if (id != shippingAddress.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(shippingAddress).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ShippingAddressExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/ShippingAddresses

        [HttpPost]
        public async Task<ActionResult<ShippingAddress>> PostShippingAddress(ShippingAddress shippingAddress)
        {
            _context.ShippingAddress.Add(shippingAddress);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShippingAddress", new { id = shippingAddress.Id }, shippingAddress);
        }

        //// DELETE: api/ShippingAddresses/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteShippingAddress(int id)
        //{
        //    var shippingAddress = await _context.ShippingAddress.FindAsync(id);
        //    if (shippingAddress == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.ShippingAddress.Remove(shippingAddress);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ShippingAddressExists(int? id)
        //{
        //    return _context.ShippingAddress.Any(e => e.Id == id);
        //}
    }
}
