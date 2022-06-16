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
  public class EFMesajRepository : IMesajDAL
  {
    public void Ekle(Mesaj item)
    {
      throw new NotImplementedException();
    }

    public Mesaj GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Mesaj> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Mesaj item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
