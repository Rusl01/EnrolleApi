using EnrolleApi.Model;
using Enrollee.DB_Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnrolleApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnrolleController : ControllerBase
    {


        private readonly ILogger<EnrolleController> _logger;
        readonly DbService db;
        public EnrolleController(ILogger<EnrolleController> logger, DbService dbService)
        {
            //var a = jjs;
            _logger = logger;
            this.db = dbService;
        }


        [HttpPost]
        public async Task<Boolean> Programs([FromBody] EnrolleSnils enrolleSnils)
        {
            var ExistEnrolle = await db.ListEnrolle.Where(x => x.Snils == enrolleSnils.Snils).FirstOrDefaultAsync();
            if(ExistEnrolle == null)
                return false;
            else
                return true;
        }
    }
}
