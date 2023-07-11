using EnrolleApi.Model;
using EnrolleApi.Model.BD_Model;
using Enrollee.DB_Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace EnrolleApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    // Allow CORS for all origins. (Caution!)
    /*[EnableCors]*/
    public class AllDataController : ControllerBase
    {
        private readonly ILogger<AllDataController> _logger;
        readonly DbService db;
        public AllDataController(ILogger<AllDataController> logger, DbService dbService)
        {
            //var a = jjs;
            _logger = logger;
            this.db = dbService;
        }

        //[HttpPost]
        //public async Task<List<OneEnrolleListModel>> Programs([FromBody] DataLevStudy Data)
        //{
        //    List<OneEnrolleListModel> Enrolles = await db.ListEnrolle.Where(x => x.LevelTraining == Data.LevelTraining && x.FormStudy == Data.FormStudy).Select(x=> new OneEnrolleListModel
        //    {
        //        Snils = x.Snils,
        //        AdmissionCategory = x.AdmissionCategory,
        //        FoundationReceipts = x.FoundationReceipts,
        //        HaveDiplomInVus = x.HaveDiplomInVus,
        //        IdEnrolle = x.IdEnrolle,
        //        LevelTraining = x.LevelTraining,    
        //        Napravlenie = x.Napravlenie,
        //        Naprav_Group = x.Naprav_Group,
        //        Prioritet = x.Prioritet,
        //        Profil = x.Profil,
        //        Soglasie = x.Soglasie,
        //        SumBall = x.SumBall,
        //        SumBall_ID = x.SumBall_ID,
        //        TypeIsp = x.TypeIsp
        //    }).ToListAsync();
           
        //    return Enrolles;
        //}
    }
}
