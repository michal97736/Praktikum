using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum.Service.Interface
{
	public interface ICrudService<T>
	{
		Task<List<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task<T> AddAsync(T entity);
	}
}
