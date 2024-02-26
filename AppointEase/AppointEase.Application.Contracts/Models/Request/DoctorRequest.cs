
using System.ComponentModel.DataAnnotations;

namespace AppointEase.Application.Contracts.Models.Request
{
    public class DoctorRequest
    {
        public DoctorRequest()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; private set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        public int PersonalNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string? Specialisation { get; set; }
        public string ClinicId { get; set; }
        public virtual ClinicRequest Clinic { get; set; }
    }
}
