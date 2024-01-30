using ApplicationForm.DAL.Ef;
using ApplicationForm.DAL.Model;

namespace ApplicationForm.DAL {
    public interface IShowInfomationDAL {
        Task<List<ApplicationRequest>> GetInformationModelRequest();
        Task<List<Application>> GetInformationModelApplications();
    }
}
