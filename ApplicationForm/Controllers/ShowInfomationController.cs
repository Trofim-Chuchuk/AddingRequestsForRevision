using ApplicationForm.BL;
using ApplicationForm.BL.Navigation;
using ApplicationForm.DAL.Ef;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationForm.Controllers {
    public class ShowInfomationController:Controller {
        private readonly IShowInfomationBL showInfomationBL;

        public ShowInfomationController(IShowInfomationBL showInfo) {
            showInfomationBL = showInfo;
        }

        [HttpGet]
        [Route("/info")]
        public async Task<ActionResult> Index(int page = 1) {
            int pageSize = 3;   // количество элементов на странице

         var count=showInfomationBL.GetInformationRequest().Result.Count;
         var items= showInfomationBL.GetInformationRequest().Result.
                Skip((page - 1) * pageSize).Take(count).ToList();

         PageViewModel pageViewModel = new(count, page, pageSize);

            IndexViewModel viewModel = new() {
                PageViewModel = pageViewModel,
                ApplicationRequests = items
            };
            return View(viewModel);
        }
    }
}
