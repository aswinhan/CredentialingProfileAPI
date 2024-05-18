﻿using System;
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
    public class PostGraduateMedicalTrainingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<PostGraduateMedicalTrainingsController> _logger;

        public PostGraduateMedicalTrainingsController(ApplicationDbContext context, ProviderService providerService, ILogger<PostGraduateMedicalTrainingsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: services/PostGraduateMedicalTraining/5
        [HttpGet("services/PostGraduateMedicalTraining/{credentialingProfileId}")]
        public async Task<ActionResult<PostGraduateMedicalTraining>> GetPostGraduateMedicalTraining(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var postGraduateMedicalTraining = await _context.PostGraduateMedicalTrainings
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (postGraduateMedicalTraining == null)
                    {
                        return NotFound();
                    }

                    return Ok(postGraduateMedicalTraining);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching the account.");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
