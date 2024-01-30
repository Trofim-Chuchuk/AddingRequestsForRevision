using ApplicationForm.DAL.Ef;
using ApplicationForm.DAL.Model;

namespace ApplicationForm.DAL {
    public class AuthApplicationFormDAL : IAuthApplicationFormDAL {
        public async Task CreateApplicationFormDAL(ApplicationRequest model) {
            using (Context context = new()) {
                // Получаем приложение из базы данных по его идентификатору
                var application = await context.applications.FindAsync(model.Application.ApplicationId);
                if (application != null) {
                    application.Requests.Add(model);
                    await context.SaveChangesAsync();
                }
                else {
                    throw new Exception("null application");
                }
                await context.SaveChangesAsync();
            }
        }
    }
}
