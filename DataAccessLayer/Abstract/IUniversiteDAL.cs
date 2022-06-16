using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public interface IUniversiteDAL
  {
    List<Universite> GetList();
    Universite GetByID(int id);
    void Ekle(Universite item);
    void Guncelle(Universite item);
    void Sil(int id);
  }
}
