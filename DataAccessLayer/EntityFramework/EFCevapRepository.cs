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
  public class EFCevapRepository : ICevapDAL
  {
    public void Ekle(Cevap item)
    {
      throw new NotImplementedException();
    }

    public Cevap GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Cevap> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Cevap item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
