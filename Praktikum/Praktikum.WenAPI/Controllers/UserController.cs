using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Praktikum.Common.DTOs;
using Praktikum.Service.Interface;
using Praktikum.WenAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Praktikum.WenAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly ICrudService<UserDTO> crudService;
		public UserController(ICrudService<UserDTO> crudService)
		{
			this.crudService = crudService;
		}
		// GET: api/<UserController>
		[HttpGet]
		public async Task<List<UserDTO>> Get()
		{
			return await crudService.GetAllAsync();
		}

		// GET api/<UserController>/5
		[HttpGet("{id}")]
		public async Task<UserDTO> Get(int id)
		{
			return await crudService.GetByIdAsync(id);
		}

		// POST api/<UserController>
		[HttpPost]
		public async Task<UserDTO> Post([FromBody] UserPostModel User)
		{
			return await crudService.AddAsync(new UserDTO
			{
				//UserId = User.UserId,
				FirstName = User.FirstName,
				LastName = User.LastName,
				TZ = User.TZ,
				BirthDate = User.BirthDate,
				Gender = User.Gender,
				HMO = User.HMO
			});
		}

		//// PUT api/<UserController>/5
		//[HttpPut("{id}")]
		//public void Put(int id, [FromBody] string value)
		//{
		//}

		//// DELETE api/<UserController>/5
		//[HttpDelete("{id}")]
		//public void Delete(int id)
		//{
		//}
	}
}
