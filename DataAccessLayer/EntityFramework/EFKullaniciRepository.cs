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
  public class EFKullaniciRepository : IKullaniciDAL
  {
    public void Ekle(Kullanici item)
    {
      throw new NotImplementedException();
    }

    public Kullanici GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Kullanici> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Kullanici item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
