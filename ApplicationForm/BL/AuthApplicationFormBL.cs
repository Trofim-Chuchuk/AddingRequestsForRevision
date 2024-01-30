using ApplicationForm.DAL;
using ApplicationForm.DAL.Ef;
using ApplicationForm.DAL.Model;
using ApplicationForm.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ApplicationForm.BL {
    public class AuthApplicationFormBL : IAuthApplicationFormBL {
        private readonly IAuthApplicationFormDAL authApplicationFormDAL;
        public AuthApplicationFormBL(IAuthApplicationFormDAL authApplicationFormDAL) {
            this.authApplicationFormDAL = authApplicationFormDAL;
        }
        public async Task CreateApplicationFormBL(ApplicationRequest model) {
              await authApplicationFormDAL.CreateApplicationFormDAL(model);
            
        }
        public async Task<ValidationResult?> ValidateTime(string time) {
            var deadline = new DateTime();
            var Valid =
                DateTime.TryParseExact(time, "dd.MM.yyyy", new CultureInfo("de-DE"), DateTimeStyles.None,out deadline);
            if (Valid==false) {
                return new ValidationResult("Не cоответствие формату ДД.ММ.ГГГГ");
            }
            return null;
        }
      /*  public async Task EnteringApplicationsBL(List<string> name) {

            return 
        }
      */
    }
}
