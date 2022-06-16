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
  public class UniversiteManager : IUniversiteService
  {
    private IUniversiteDAL _universiteDAL;

    public UniversiteManager(IUniversiteDAL universiteDAL)
    {
      _universiteDAL = universiteDAL;
    }

    public void Ekle(Universite item)
    {
      _universiteDAL.Ekle(item);
    }

    public Universite GetByID(int id)
    {
      return _universiteDAL.GetByID(id);
    }

    public List<Universite> GetList()
    {
      return _universiteDAL.GetList();
    }

    public void Guncelle(Universite item)
    {
      _universiteDAL.Guncelle(item);
    }

    public void Sil(int id)
    {
      _universiteDAL.Sil(id);
    }
  }
}
