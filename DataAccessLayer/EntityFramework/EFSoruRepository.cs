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
  public class EFSoruRepository : ISoruDAL
  {
    public void Ekle(Soru item)
    {
      throw new NotImplementedException();
    }

    public Soru GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Soru> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Soru item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
