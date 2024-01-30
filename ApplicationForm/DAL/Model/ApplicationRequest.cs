using System.ComponentModel.DataAnnotations;

namespace ApplicationForm.DAL.Model {
    public class ApplicationRequest {
        public int Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Description { get; set; }
        [Required] public string Deadline { get; set; }
        [Required] public string Email { get; set; }

        public Application? Application { get; set; }
    }
}
