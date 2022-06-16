using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
  public class GenericRepository<T> : IGenericDAL<T> where T : class
  {
    Context context = new Context();

    public void Delete(T t)
    {
      context.Remove(t);
      context.SaveChanges();
    }

    public T GetByID(int id)
    {
      return context.Set<T>().Find(id);
    }

    public List<T> GetList()
    {
      return context.Set<T>().ToList();
    }

    public void Insert(T t)
    {
      context.Add(t);
      context.SaveChanges();
    }

    public void Update(T t)
    {
      context.Update(t);
      context.SaveChanges();
    }
  }
}
