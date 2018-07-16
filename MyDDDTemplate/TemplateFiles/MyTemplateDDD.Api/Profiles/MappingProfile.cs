using AutoMapper;
using $safeprojectname$.ViewModels;
using $ext_safeprojectname$.Domain.Entities;

namespace $safeprojectname$.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ExampleListViewModel, Example>();
            CreateMap<ExampleEditViewModel, Example>();
        }       
    }
}