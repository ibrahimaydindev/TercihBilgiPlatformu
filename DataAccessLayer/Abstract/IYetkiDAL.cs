using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public interface IYetkiDAL
  {
    List<Yetki> GetList();
    Yetki GetByID(int id);
    void Ekle(Yetki item);
    void Guncelle(Yetki item);
    void Sil(int id);
  }
}
