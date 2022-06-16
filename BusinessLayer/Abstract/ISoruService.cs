using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface ISoruService
  {
    List<Soru> GetList();
    Soru GetByID(int id);
    void Ekle(Soru item);
    void Guncelle(Soru item);
    void Sil(int id);
  }
}
