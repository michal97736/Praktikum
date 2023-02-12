using Microsoft.AspNetCore.Mvc;
using Praktikum.Common.DTOs;
using Praktikum.Service.Interface;
using Praktikum.WenAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Praktikum.WenAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ChildController : ControllerBase
	{
		private readonly ICrudService<ChildDTO> crudService;
		public ChildController(ICrudService<ChildDTO> crudService)
		{
			this.crudService = crudService;
		}

		// GET: api/<ChildController>
		[HttpGet]
		public async Task<List<ChildDTO>> Get()
		{
			return await crudService.GetAllAsync();
		}

		// GET api/<ChildController>/5
		[HttpGet("{id}")]
		public async Task<ChildDTO> Get(int id)
		{
			return await crudService.GetByIdAsync(id);
		}

		// POST api/<ChildController>
		[HttpPost]
		public async Task<ChildDTO> Post([FromBody] ChildPostModel child)
		{
			
			return await crudService.AddAsync(new ChildDTO
			{
				//ChildId = child.ChildId,
				FirstName = child.FirstName,
				LastName = child.LastName,
				TZ = child.TZ,
				BirthDate = child.BirthDate,
				ParentId = child.ParentId
				
			}) ;
		}

		//// PUT api/<ChildController>/5
		//[HttpPut("{id}")]
		//public void Put(int id, [FromBody] string value)
		//{
		//}

		//// DELETE api/<ChildController>/5
		//[HttpDelete("{id}")]
		//public void Delete(int id)
		//{
		//}
	}
}
