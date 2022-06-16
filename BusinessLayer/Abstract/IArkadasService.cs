using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface IArkadasService
  {
    List<Arkadas> GetList();
    Arkadas GetByID(int id);
    void Ekle(Arkadas item);
    void Guncelle(Arkadas item);
    void Sil(int id);
  }
}
