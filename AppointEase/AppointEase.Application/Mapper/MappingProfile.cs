using AppointEase.Application.Contracts.Models.Request;
using AppointEase.Data.Contracts.Identity;
using AppointEase.Data.Contracts.Models;
using AutoMapper;

namespace AppointEase.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Patient, PatientRequest>().ReverseMap();
            CreateMap<Admin, AdminRequest>().ReverseMap();
            CreateMap<Clinic, ClinicRequest>().ReverseMap();
            CreateMap<Doctor, DoctorRequest>().ReverseMap();
            CreateMap<ApplicationUser, PatientRequest>().ReverseMap();
            CreateMap<Patient, ApplicationUser>();
            CreateMap<Clinic, ApplicationUser>();
        }
    }
}
