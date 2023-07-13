using EnrolleApi.Model;
using EnrolleApi.Model.BD_Model;
using Enrollee.DB_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnrolleApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AllDataForEnrolleController : ControllerBase
    {
        private readonly ILogger<AllDataForEnrolleController> _logger;
        readonly DbService db;
        public AllDataForEnrolleController(ILogger<AllDataForEnrolleController> logger, DbService dbService)
        {

            _logger = logger;
            this.db = dbService;
        }

        [HttpPost]
        public async Task<List<EnrolleModel>> Programs([FromBody] EnrolleSnils snils)
        {

            List<EnrolleModel> Enrolles = await db.ListEnrolle.Where(x => x.Snils == snils.Snils).OrderBy(x=>x.Priority).ToListAsync();

            return Enrolles;
        }
    }
}
