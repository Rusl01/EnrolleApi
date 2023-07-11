using EnrolleApi.Model;
using EnrolleApi.Model.BD_Model;
using Enrollee.DB_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnrolleApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AllProfilesOfDirectionsController : ControllerBase
    {
        private readonly ILogger<AllProfilesOfDirectionsController> _logger;
        readonly DbService db;
        public AllProfilesOfDirectionsController(ILogger<AllProfilesOfDirectionsController> logger, DbService dbService) 
        {

            _logger = logger;
            this.db = dbService;
        }

        [HttpGet]
        public async Task<List<string>> Programs(string LevelTraining, string FormStudy,string Napravlenie)
        {
            var Profils = await db.ListEnrolle.Where(x => x.FormStudy == FormStudy && x.Napravlenie == Napravlenie).Select(x=>x.Profil).Distinct().ToListAsync();
       
            return Profils;
        }
       
    }
}
