using AutoMapper;
using Praktikum.Common.DTOs;
using Praktikum.Repository.entities;
using System.Diagnostics;

namespace Praktikum.Service
{
    public class Mapping:Profile
    {
        public Mapping()
        {
			CreateMap<User, UserDTO>().ReverseMap();
			CreateMap<Child, ChildDTO>().ReverseMap(); 
		}

    }
}