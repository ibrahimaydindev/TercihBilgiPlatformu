using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public interface IGenericDAL<T> where T:class
  {
    public List<T> GetList();
    public T GetByID(int id);
    public void Insert(T t);
    public void Delete(T t);
    public void Update(T t);
  }
}
