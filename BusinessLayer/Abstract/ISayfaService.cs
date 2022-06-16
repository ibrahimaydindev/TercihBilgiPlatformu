using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface ISayfaService
  {
    List<Sayfa> GetList();
    Sayfa GetByID(int id);
    void Ekle(Sayfa item);
    void Guncelle(Sayfa item);
    void Sil(int id);
  }
}
