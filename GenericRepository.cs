using System;
namespace HomeWork4
{
	public class GenericRepository<T> : IRepository<T> where T : class
	{
        private List<T> list;  
		public GenericRepository()
		{
            list = new List<T>(); 
		}

        public void Add(T item)
        {
            
            list.Add(item); 
        }

        public IEnumerable<T> GetALL()
        {
            return list; 
        }

        public T GetbyID(int id)
        {
            //foreach(var item in list)
            //{
            //    if (item.Id == id)
            //    {
            //        return item; 
            //    }
            //}
            return list[id]; 
        }

        public void Remove(T item)
        {
            list.Remove(item); 
        }

        public void Save()
        {
            
        }
    }
}

