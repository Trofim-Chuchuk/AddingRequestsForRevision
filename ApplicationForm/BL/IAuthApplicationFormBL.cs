using ApplicationForm.DAL.Ef;
using ApplicationForm.DAL.Model;
using ApplicationForm.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace ApplicationForm.BL {
    public interface IAuthApplicationFormBL {
        Task CreateApplicationFormBL(ApplicationRequest model);
        Task <ValidationResult?> ValidateTime(string email);
    }
}
