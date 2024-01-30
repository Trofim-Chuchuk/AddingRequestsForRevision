using ApplicationForm.DAL.Ef;
using ApplicationForm.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace ApplicationForm.DAL {
    public class ShowInfomationDAL : IShowInfomationDAL {
        public async Task <List<ApplicationRequest>> GetInformationModelRequest() {
            using (var db = new Context()) {
                var salue = await db.requests.FromSqlRaw("SELECT * FROM requests").Include(a=>a.Application).ToListAsync();
                return salue;
           }
        }
        public async Task<List<Application>> GetInformationModelApplications() {
            using (var db = new Context()) {
                return await db.applications.ToListAsync();
            }
        }
    }
}
