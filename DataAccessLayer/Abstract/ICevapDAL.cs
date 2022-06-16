using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public interface ICevapDAL
  {
    List<Cevap> GetList();
    Cevap GetByID(int id);
    void Ekle(Cevap item);
    void Guncelle(Cevap item);
    void Sil(int id);
  }
}
