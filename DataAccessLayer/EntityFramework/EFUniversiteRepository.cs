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
  public class EFUniversiteRepository : IUniversiteDAL
  {
    public void Ekle(Universite item)
    {
      throw new NotImplementedException();
    }

    public Universite GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Universite> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Universite item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
