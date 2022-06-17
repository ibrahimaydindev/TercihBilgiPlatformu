using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    
  public class EFEtiketRepository : IEtiketDAL
  {
        Context c = new Context();
    public void Ekle(Etiket item)
    {
      throw new NotImplementedException();
    }

    public Etiket GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Etiket> GetList()
    {
            return c.Etikets.ToList();
            c.SaveChanges();
    }

    public void Guncelle(Etiket item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
