using ApplicationForm.DAL.Model;
using ApplicationForm.ViewModels;

namespace ApplicationForm.DAL {
    public interface IAuthApplicationFormDAL{
        Task CreateApplicationFormDAL(ApplicationRequest model);
    }
}
