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
  public class YetkiManager : IYetkiService
  {
    private IYetkiDAL _yetkiDAL;

    public YetkiManager(IYetkiDAL yetkiDAL)
    {
      _yetkiDAL = yetkiDAL;
    }

    public void Ekle(Yetki item)
    {
      _yetkiDAL.Ekle(item);
    }

    public Yetki GetByID(int id)
    {
      return _yetkiDAL.GetByID(id);
    }

    public List<Yetki> GetList()
    {
      return _yetkiDAL.GetList();
    }

    public void Guncelle(Yetki item)
    {
      _yetkiDAL.Guncelle(item);
    }

    public void Sil(int id)
    {
      _yetkiDAL.Sil(id);
    }
  }
}
