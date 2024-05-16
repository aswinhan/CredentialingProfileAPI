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
    public class PostGraduateMedicalTrainingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PostGraduateMedicalTrainingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: services/data/v60.0/sobjects/PostGraduateMedicalTraining/5
        [HttpGet("services/data/v60.0/sobjects/PostGraduateMedicalTraining/{providerId}")]
        public async Task<ActionResult<PostGraduateMedicalTraining>> GetPostGraduateMedicalTraining(int providerId)
        {
            var postGraduateMedicalTraining = await _context.PostGraduateMedicalTrainings.FirstOrDefaultAsync(x => x.ProviderId == providerId);

            if (postGraduateMedicalTraining == null)
            {
                return NotFound();
            }

            return postGraduateMedicalTraining;
        }
    }
}
