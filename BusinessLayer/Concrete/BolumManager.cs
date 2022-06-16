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
  public class BolumManager : IBolumService
  {
    private IBolumDAL _bolumDAL;

    public BolumManager(IBolumDAL bolumDAL)
    {
      _bolumDAL = bolumDAL;
    }

    public void Ekle(Bolum item)
    {
      _bolumDAL.Ekle(item);
    }

    public Bolum GetByID(int id)
    {
      return _bolumDAL.GetByID(id);
    }

    public List<Bolum> GetList()
    {
      return _bolumDAL.GetList();
    }

    public void Guncelle(Bolum item)
    {
      _bolumDAL.Guncelle(item);
    }

    public void Sil(int id)
    {
      _bolumDAL.Sil(id);
    }
  }
}
