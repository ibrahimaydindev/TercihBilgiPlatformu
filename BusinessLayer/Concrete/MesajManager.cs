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
  public class MesajManager : IMesajService
  {
    private IMesajDAL _mesajDAL;

    public MesajManager(IMesajDAL mesajDAL)
    {
      _mesajDAL = mesajDAL;
    }
    public void Ekle(Mesaj item)
    {
      _mesajDAL.Ekle(item);
    }

    public Mesaj GetByID(int id)
    {
      return _mesajDAL.GetByID(id);
    }

    public List<Mesaj> GetList()
    {
      return _mesajDAL.GetList();
    }

    public void Guncelle(Mesaj item)
    {
      _mesajDAL.Guncelle(item);
    }

    public void Sil(int id)
    {
      _mesajDAL.Sil(id);
    }
  }
}
