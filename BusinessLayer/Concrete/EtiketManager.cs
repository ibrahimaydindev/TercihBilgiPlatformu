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
  public class EtiketManager : IEtiketService
  {
    private IEtiketDAL _etiketDAL;

    public EtiketManager(IEtiketDAL etiketDAL) 
    {
      _etiketDAL = etiketDAL;
    }

    public void Ekle(Etiket item)
    {
      _etiketDAL.Ekle(item);
    }

    public Etiket GetByID(int id)
    {
      return _etiketDAL.GetByID(id);
    }

    public List<Etiket> GetList()
    {
      return _etiketDAL.GetList();
    }

    public void Guncelle(Etiket item)
    {
      _etiketDAL.Guncelle(item);
    }

    public void Sil(int id)
    {
      _etiketDAL.Sil(id);
    }
  }
}
