using ADP.JKR.Example.Api.Models;
using ADP.JKR.Example.Core.Entities;

using AutoMapper;

namespace ADP.JKR.Example.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
