using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface IMesajService
  {
    List<Mesaj> GetList();
    Mesaj GetByID(int id);
    void Ekle(Mesaj item);
    void Guncelle(Mesaj item);
    void Sil(int id);
  }
}
