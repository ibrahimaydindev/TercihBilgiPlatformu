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
  public class ArkadasManager : IArkadasService
  {
    private IArkadasDAL _arkadasDAL;

    public ArkadasManager(IArkadasDAL arkadasDAL)
    {
      _arkadasDAL = arkadasDAL;
    }

    public void Ekle(Arkadas item)
    {
      _arkadasDAL.Ekle(item);
    }

    public Arkadas GetByID(int id)
    {
      return _arkadasDAL.GetByID(id);
    }

    public List<Arkadas> GetList()
    {
      return _arkadasDAL.GetList();
    }

    public void Guncelle(Arkadas item)
    {
      _arkadasDAL.Guncelle(item);
    }

    public void Sil(int id)
    {
      _arkadasDAL.Sil(id);
    }
  }
}
