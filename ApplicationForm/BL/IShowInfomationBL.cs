using ApplicationForm.DAL.Ef;
using ApplicationForm.DAL.Model;

namespace ApplicationForm.BL {
    public interface IShowInfomationBL {
        Task<List<ApplicationRequest>> GetInformationRequest();
        Task<List<Application>> GetInformationApp();
    }
}
