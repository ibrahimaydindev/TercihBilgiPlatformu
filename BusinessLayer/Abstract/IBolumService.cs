using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface IBolumService
  {
    List<Bolum> GetList();
    Bolum GetByID(int id);
    void Ekle(Bolum item);
    void Guncelle(Bolum item);
    void Sil(int id);
  }
}
