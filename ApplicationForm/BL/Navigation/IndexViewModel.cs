using ApplicationForm.DAL.Model;

namespace ApplicationForm.BL.Navigation
{
    public class IndexViewModel
    {
       
        public PageViewModel PageViewModel { get; set; }
        public List<ApplicationRequest> ApplicationRequests { get;  set; }
    }
}
