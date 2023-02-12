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
	internal class ChildService : ICrudService<ChildDTO>
	{
		private readonly ICrud<Child> crud;

		private readonly IMapper mapper;
		public ChildService(ICrud<Child> crud, IMapper mapper)
		{
			this.crud = crud;
			this.mapper = mapper;
		}
		public async Task<ChildDTO> AddAsync(ChildDTO entity)
		{
			return mapper.Map<ChildDTO>(await crud.AddAsync(mapper.Map<Child>(entity)));
		}

		public async Task<List<ChildDTO>> GetAllAsync()
		{
			return mapper.Map<List<ChildDTO>>(await crud.GetAllAsync());
		}

		public async Task<ChildDTO> GetByIdAsync(int id)
		{
			return mapper.Map<ChildDTO>(await crud.GetByIdAsync(id));

		}
	}
}
