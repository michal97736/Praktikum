using AutoMapper;
using Praktikum.Common.DTOs;
using Praktikum.Repository.entities;
using Praktikum.Repository.Interface;
using Praktikum.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum.Service.Services
{
	internal class UserService : ICrudService<UserDTO>
	{
		private readonly ICrud<User> crud;

		private readonly IMapper mapper;
		public UserService(ICrud<User> crud,IMapper mapper)
		{
			this.crud = crud;	
			this.mapper = mapper;
		}

			
		public async Task<UserDTO> AddAsync(UserDTO entity)
		{
			return mapper.Map<UserDTO>(await crud.AddAsync(mapper.Map<User>(entity)));

		}

		public async Task<List<UserDTO>> GetAllAsync()
		{
			return mapper.Map<List<UserDTO>>(await crud.GetAllAsync());
		}

		public async Task<UserDTO> GetByIdAsync(int id)
		{
			return mapper.Map<UserDTO>(await crud.GetByIdAsync(id));
		}
	}
}
