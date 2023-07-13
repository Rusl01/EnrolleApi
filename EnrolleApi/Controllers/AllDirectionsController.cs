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
    public class AllDirectionsController : ControllerBase
    {
        private readonly ILogger<AllDirectionsController> _logger;
        readonly DbService db;
        public AllDirectionsController(ILogger<AllDirectionsController> logger, DbService dbService) 
        {

            _logger = logger;
            this.db = dbService;
        }

        [HttpPost]
        public async Task<List<string>> Programs([FromBody] DataLevStudy Data)
        {
            var ListNaprav = await db.ListEnrolle
                .Where(x => x.FormStudy == Data.LevelTraining).Select(x => x.Napravlenie).Distinct().ToListAsync();

            return ListNaprav;
        }
       
    }
}
