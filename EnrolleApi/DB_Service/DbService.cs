using EnrolleApi.Model.BD_Model;
using Microsoft.EntityFrameworkCore;

namespace Enrollee.DB_Service
{
    public class DbService : DbContext
    {
        public DbService(DbContextOptions<DbService> options): base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<EnrolleModel> ListEnrolle {  get; set; }
        //public DbSet<OneEnrolleListModel> OneEnrolle {  get; set; }
    }
}
