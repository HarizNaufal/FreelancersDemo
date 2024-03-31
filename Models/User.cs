using System.ComponentModel.DataAnnotations;

namespace FreelancersApp.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string skillset { get; set; }
        public string hobby { get; set; }
    }
}
