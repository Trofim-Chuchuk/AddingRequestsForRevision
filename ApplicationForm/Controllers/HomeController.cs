using ApplicationForm.BL;
using ApplicationForm.DAL.Model;
using ApplicationForm.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ApplicationForm.Controllers {
    public class HomeController : Controller {
        private readonly IAuthApplicationFormBL appFormBL;
        private readonly IShowInfomationBL showInfomationBL;

        public HomeController(IAuthApplicationFormBL appFormBL,
            IShowInfomationBL showInfomationBL) {
            this.appFormBL = appFormBL;
            this.showInfomationBL = showInfomationBL;
        }

        [HttpGet]
        [Route("/")]
        public async Task<IActionResult> Index() {
            IEnumerable<Application>? iEnumerableApplication = await showInfomationBL.GetInformationApp();
            ViewBag.ApplicationId = new SelectList(iEnumerableApplication, "ApplicationId", "Name");
            return View("Index", new RegisterViewModel());
        }

        [HttpPost]
        [Route("/")]
        public async Task<IActionResult> IndexSave(RegisterViewModel model) {

            var ApplicationList = await showInfomationBL.GetInformationApp();
            ViewBag.ApplicationId = new SelectList(ApplicationList, "ApplicationId", "Name");
            var SelectedApplication = ApplicationList[model.ApplicationId - 1];
            model.Application = SelectedApplication;

            if (ModelState.IsValid) {
                var errorModel = await appFormBL.ValidateTime(model.Deadline);
                if (errorModel != null) {
                    ModelState.TryAddModelError("Deadline", errorModel.ErrorMessage!);
                }
            }
            if (ModelState.IsValid) {
                await appFormBL.CreateApplicationFormBL(
                    RegisterViewModel.MapRegisterViewModelToApplicationRequest(model));
                return Redirect("/info");
            }
            return View("Index", model);
        }
    }
}
