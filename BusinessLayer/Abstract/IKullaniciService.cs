using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface IKullaniciService
  {
    List<Kullanici> GetList();
    Kullanici GetByID(int id);
    void Ekle(Kullanici item);
    void Guncelle(Kullanici item);
    void Sil(int id);
  }
}
