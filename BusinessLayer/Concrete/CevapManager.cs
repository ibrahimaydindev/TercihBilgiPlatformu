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
  public class CevapManager : ICevapService
  {
    private ICevapDAL _cevapDAL;

    public CevapManager(ICevapDAL cevapDAL)
    {
      _cevapDAL = cevapDAL;
    }

    public void Ekle(Cevap item)
    {
      _cevapDAL.Ekle(item);
    }

    public Cevap GetByID(int id)
    {
      return _cevapDAL.GetByID(id);
    }

    public List<Cevap> GetList()
    {
      return _cevapDAL.GetList();
    }

    public void Guncelle(Cevap item)
    {
      _cevapDAL.Guncelle(item);
    }

    public void Sil(int id)
    {
      _cevapDAL.Sil(id);
    }
  }
}
