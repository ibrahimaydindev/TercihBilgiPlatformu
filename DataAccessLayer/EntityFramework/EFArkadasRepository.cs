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
  public class EFArkadasRepository : IArkadasDAL
  {
    private Context context;

    public EFArkadasRepository()
    {
      context = new Context();
    }

    public void Ekle(Arkadas item)
    {
      item.Silindi = false;
      item.KayitTarihi = DateTime.Now;
      var entry = context.Entry(item);
      entry.State = EntityState.Added;
      context.SaveChanges();
    }

    public Arkadas GetByID(int id)
    {
      return context.Arkadas.FirstOrDefault(x => x.ArkadasID == id);
    }

    public List<Arkadas> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Arkadas item)
    {
      var arkadas = context.Arkadas.FirstOrDefault(x => x.ArkadasID == item.ArkadasID);

      arkadas.GuncellemeTarihi = DateTime.Now;

      var entry = context.Entry(item);
      entry.State = EntityState.Modified;
      context.SaveChanges();
    }

    public void Sil(int id)
    {
      var item = context.Arkadas.FirstOrDefault(x => x.ArkadasID == id);

      if (item != null)
      {
        item.Silindi = true;
        var entry = context.Entry(item);
        entry.State = EntityState.Modified;
        context.SaveChanges();
      }
    }
  }
}
