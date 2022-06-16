using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface IYetkiService
  {
    List<Yetki> GetList();
    Yetki GetByID(int id);
    void Ekle(Yetki item);
    void Guncelle(Yetki item);
    void Sil(int id);
  }
}
