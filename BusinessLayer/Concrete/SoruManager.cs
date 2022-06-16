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
  public class SoruManager : ISoruService
  {
    private ISoruDAL _soruDAL;

    public SoruManager(ISoruDAL soruDAL)
    {
      _soruDAL = soruDAL;
    }
    public void Ekle(Soru item)
    {
      _soruDAL.Ekle(item);
    }

    public Soru GetByID(int id)
    {
      return _soruDAL.GetByID(id);
    }

    public List<Soru> GetList()
    {
      return _soruDAL.GetList();
    }

    public void Guncelle(Soru item)
    {
      _soruDAL.Guncelle(item);
    }

    public void Sil(int id)
    {
      _soruDAL.Sil(id);
    }
  }
}
