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
  public class EFLiseRepository : ILiseDAL
  {
    public void Ekle(Lise item)
    {
      throw new NotImplementedException();
    }

    public Lise GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Lise> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Lise item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
