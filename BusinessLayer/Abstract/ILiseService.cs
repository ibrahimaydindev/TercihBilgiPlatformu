using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface ILiseService
  {
    List<Lise> GetList();
    Lise GetByID(int id);
    void Ekle(Lise item);
    void Guncelle(Lise item);
    void Sil(int id);
  }
}
