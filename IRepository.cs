using System;
namespace HomeWork4
{
	public interface IRepository<T> where T : class
	{
		public void Add(T item);
		public void Remove(T item);
		public void Save();
		public IEnumerable<T> GetALL();
		public T GetbyID(int id); 
	}
}

