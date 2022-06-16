using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
  public class KullaniciManager:IKullaniciService
  {
    private IKullaniciDAL _kullaniciDAL; 

    public KullaniciManager(IKullaniciDAL kullaniciDAL)
    {
      _kullaniciDAL = kullaniciDAL;
    }

    public void Ekle(Kullanici item)
    {
      _kullaniciDAL.Ekle(item);
    }

    public Kullanici GetByID(int id)
    {
      return _kullaniciDAL.GetByID(id);
    }

    public List<Kullanici> GetList()
    {
      return _kullaniciDAL.GetList();
    }

    public void Guncelle(Kullanici item)
    {
      _kullaniciDAL.Guncelle(item);
    }

    public void Sil(int id)
    {
      _kullaniciDAL.Sil(id);
    }
  }
}
