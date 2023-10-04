using Core.DTOs;
using Core.Entities;
using AutoMapper;

namespace Core.Mappers
{
    public class AppProfile:Profile
    {
        public AppProfile()
        {

            CreateMap<Service, ServiceDto>().ReverseMap();
            CreateMap<Worker, WorkerDto>().ReverseMap();
            // Map Movie into MovieDto
            CreateMap<Customer, CustomerDto>()
                .ForMember(movieDto => movieDto.Services, options => options.MapFrom(movie => movie.Services.Select(i => i)));
            CreateMap<CustomerDto, Customer>();
            CreateMap<CreateCustomerDto, Customer>();
        }
    }
}
