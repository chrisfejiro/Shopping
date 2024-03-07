using AutoMapper;
using Shopping.Models;
using Shopping.Models.Dto;

namespace Shopping.AutoMapper
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<MenuItemCreateDTO, MenuItem>();
        }
    }
}
