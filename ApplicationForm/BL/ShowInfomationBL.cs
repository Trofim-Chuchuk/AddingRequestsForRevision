using ApplicationForm.DAL;
using ApplicationForm.DAL.Ef;
using ApplicationForm.DAL.Model;

namespace ApplicationForm.BL {
    public class ShowInfomationBL : IShowInfomationBL {
        private readonly IShowInfomationDAL showInfomationDAL;

        public ShowInfomationBL(IShowInfomationDAL showInfomationDAL) {
            this.showInfomationDAL = showInfomationDAL;
        }

        public async Task<List<ApplicationRequest>> GetInformationRequest() {
           return await showInfomationDAL.GetInformationModelRequest();
        }
        public async Task<List<Application>> GetInformationApp() {
            return await showInfomationDAL.GetInformationModelApplications();
        }

    }
}
