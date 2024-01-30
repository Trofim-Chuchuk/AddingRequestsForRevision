using System.Collections.ObjectModel;

namespace ApplicationForm.DAL.Model {
    public class Application {
        public int ApplicationId { get; set; }
        public string Name { get; set; }

        public List<ApplicationRequest> Requests { get; set; }= new List<ApplicationRequest>();
    }
}
