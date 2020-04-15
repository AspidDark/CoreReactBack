using System.ComponentModel.DataAnnotations;

namespace WebApiReact.Entity.Entities
{
    public class DCandidate
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public string BloodGroup { get; set; }

        public string Address { get; set; }
    }
}
