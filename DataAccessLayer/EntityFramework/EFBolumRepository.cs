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
  public class EFBolumRepository : IBolumDAL
  {
    public void Ekle(Bolum item)
    {
      throw new NotImplementedException();
    }

    public Bolum GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Bolum> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Bolum item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
