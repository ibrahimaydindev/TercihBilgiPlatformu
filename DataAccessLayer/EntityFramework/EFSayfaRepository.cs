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
  public class EFSayfaRepository : ISayfaDAL
  {
    public void Ekle(Sayfa item)
    {
      throw new NotImplementedException();
    }

    public Sayfa GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Sayfa> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Sayfa item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
