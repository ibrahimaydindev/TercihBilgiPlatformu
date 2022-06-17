using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
  public class EFUniversiteRepository :GenericRepository<Universite>, IUniversiteDAL
  {
        Context c =new Context();
       
    public void Ekle(Universite item)
    {
           
    }

    public Universite GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Universite> GetListAll()
    {
          return   c.Universites.ToList();
            c.SaveChanges();

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
