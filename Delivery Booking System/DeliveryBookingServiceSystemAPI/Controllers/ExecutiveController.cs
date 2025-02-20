﻿using DeliveryBookingServiceSystemAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingServiceSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExecutiveController : ControllerBase
    {
        private readonly Context _context;

        public ExecutiveController(Context context)
        {
            _context = context;
        }

        // GET: api/Executives
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Executive>>> GetExecutives()
        {
            return await _context.Executives.ToListAsync();
        }

        // GET: api/Executives/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Executive>> GetExecutive(int id)
        {
            var executive = await _context.Executives.FindAsync(id);

            if (executive == null)
            {
                return NotFound();
            }

            return executive;
        }
        [HttpGet]
        [Route("WithVerifiedStatus")]

        public async Task<ActionResult<IEnumerable<Executive>>> GetCustomersWithVerifiedStatus()
        {
            var executives = _context.Executives.Where(e => e.IsVerified == true).ToList();
            if (executives == null)
            {
                return NotFound();
            }

            return executives;
        }
        [HttpGet]
        [Route("WithoutVerifiedStatus")]

        public async Task<ActionResult<IEnumerable<Executive>>> GetCustomersWithoutVerifiedStatus()
        {
            var executives = _context.Executives.Where(e => e.IsVerified == false).ToList();
            if (executives == null)
            {
                return NotFound();
            }

            return executives;
        }
        [HttpGet]
        [Route("WithStatusCheck")]
        public async Task<ActionResult<IEnumerable<Executive>>> GetExecutiveIdWithStatusCheck()
        {
            var executive = _context.Executives.Where(e => e.ExecutiveStatus == "Available" && e.IsVerified==true ).ToList();
            if (executive == null)
            {
                return NotFound();
            }

            return executive;
        }
        [HttpGet]
        [Route("WithCity")]
        public async Task<ActionResult<IEnumerable<Executive>>> GetExecutiveIdWithCity(string city)
        {
            var executive = _context.Executives.Where(e => e.ExecutiveStatus == "Available" && e.IsVerified == true && e.City==city).ToList();
            if (executive == null)
            {
                return NotFound();
            }

            return executive;

        }
        // PUT: api/Executives/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<Executive>> PutExecutive(int id, Executive executive)
        {
            if (id != executive.ExecutiveId)
            {
                return BadRequest();
            }

            _context.Entry(executive).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExecutiveExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return executive;
        }
        [Route("UpdatePassword")]
        [HttpPut]
        public async Task<IActionResult> UpdatePassword(int id, string password)
        {
            Executive executive = new Executive();
            executive = _context.Executives.Where(e => e.ExecutiveId == id).SingleOrDefault();
            executive.Password = password;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        // POST: api/Executives
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("PostExecutive")]
        public async Task<ActionResult<Executive>> PostExecutive(Executive executive)
        {
            var check = _context.Executives.Where(e => e.ExecutiveEmail == executive.ExecutiveEmail).SingleOrDefault();
            if(check.ExecutiveEmail !=executive.ExecutiveEmail)
            {
                _context.Executives.Add(executive);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetExecutive", new { id = executive.ExecutiveId }, executive);
            }
            return NoContent();
        }

        // DELETE: api/Executives/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExecutive(int id)
        {
            var executive = await _context.Executives.FindAsync(id);
            if (executive == null)
            {
                return NotFound();
            }

            _context.Executives.Remove(executive);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [Route("LoginExecutive")]
        [HttpPost]
        public async Task<ActionResult<Executive>> LoginExecutive(Executive executive)
        {
            if (Verification(executive))
            {
                try
                {
                    executive = _context.Executives.SingleOrDefault(u => u.ExecutiveEmail == executive.ExecutiveEmail && u.Password == executive.Password);
                    if (executive == null)
                        return NotFound();
                    return executive;
                }
                catch (Exception)
                {
                    return NotFound();
                }
            }
            return NotFound();
        }   
        private bool ExecutiveExists(int id)
        {
            return _context.Executives.Any(e => e.ExecutiveId == id);
        }
        private bool Verification(Executive executive)
        {
            try
            {
                executive = _context.Executives.SingleOrDefault(u => u.ExecutiveEmail == executive.ExecutiveEmail);
                if (executive == null)
                    return false;
                else
                {
                    if (executive.IsVerified)
                        return true;
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
