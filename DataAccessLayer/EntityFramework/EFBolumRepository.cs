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
   

    public class EFBolumRepository : GenericRepository<Bolum>, IBolumDAL
  {     Context c =new Context(); 
       
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
          return   c.Bolums.ToList();
            c.SaveChanges();
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
