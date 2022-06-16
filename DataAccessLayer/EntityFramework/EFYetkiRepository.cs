using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
  public class EFYetkiRepository : IYetkiDAL
  {
    public void Ekle(Yetki item)
    {
      throw new NotImplementedException();
    }

    public Yetki GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Yetki> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Yetki item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
