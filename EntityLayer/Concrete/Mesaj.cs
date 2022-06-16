using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public class Mesaj
  {
    [Key]
    public int MesajID { get; set; }
    public string Baslik { get; set; }
    public string Icerik { get; set; }
    public int? GonderenKullaniciId { get; set; }
    public int? AlanKullaniciId { get; set; }
    public bool Silindi { get; set; }
    public DateTime? KayitTarihi { get; set; }
    public DateTime? GuncellemeTarihi { get; set; }
    public Kullanici Kullanici { get; set; }
  }
}
