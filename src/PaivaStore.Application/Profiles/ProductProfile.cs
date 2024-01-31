using AutoMapper;
using PaivaStore.Application.Dtos.Product.Response;
using PaivaStore.Domain.Entities;

namespace PaivaStore.Application.Profiles;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductResponse>().ReverseMap();
    }
}