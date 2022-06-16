using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
  public class SayfaManager : ISayfaService
  {
    private ISayfaDAL _sayfaDAL;

    public SayfaManager(ISayfaDAL sayfaDAL)
    {
      _sayfaDAL = sayfaDAL; 
    }
    public void Ekle(Sayfa item)
    {
      _sayfaDAL.Ekle(item);
    }

    public Sayfa GetByID(int id)
    {
      return _sayfaDAL.GetByID(id);
    }

    public List<Sayfa> GetList()
    {
      return _sayfaDAL.GetList();
    }

    public void Guncelle(Sayfa item)
    {
      _sayfaDAL.Guncelle(item);
    }

    public void Sil(int id)
    {
      _sayfaDAL.Sil(id);
    }
  }
}
