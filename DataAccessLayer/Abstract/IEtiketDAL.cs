﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public interface IEtiketDAL
  {
    List<Etiket> GetList();
    Etiket GetByID(int id);
    void Ekle(Etiket item);
    void Guncelle(Etiket item);
    void Sil(int id);
  }
}
