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
  public class LiseManager : ILiseService
  {
    private ILiseDAL _liseDAL;

    public LiseManager(ILiseDAL liseDAL)
    {
      _liseDAL = liseDAL;
    }

    public void Ekle(Lise item)
    {
      _liseDAL.Ekle(item);
    }

    public Lise GetByID(int id)
    {
      return _liseDAL.GetByID(id);
    }

    public List<Lise> GetList()
    {
      return _liseDAL.GetList();
    }

    public void Guncelle(Lise item)
    {
      _liseDAL.Guncelle(item);
    }

    public void Sil(int id)
    {
      _liseDAL.Sil(id);
    }
  }
}
