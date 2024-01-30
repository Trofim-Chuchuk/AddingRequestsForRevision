using ApplicationForm.DAL.Model;
using System.ComponentModel.DataAnnotations;

namespace ApplicationForm.ViewModels {
    public class RegisterViewModel {

        [Required(ErrorMessage = "Название обязателено")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Описание обязателено")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Время обязателено")]
        public string Deadline { get; set; }
        
        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Некоректный формат")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Выберите модель.")]
        public int ApplicationId { get; set; }

        public Application? Application { get; set; }

        public static ApplicationRequest MapRegisterViewModelToApplicationRequest(RegisterViewModel model) {
            return new ApplicationRequest {
                Title = model.Title,
                Description = model.Description,
                Deadline = model.Deadline,
                Email = model.Email,
                Application = model.Application,

               // ApplicationId = model.ApplicationId,
               
            };
        }


    }
}

















