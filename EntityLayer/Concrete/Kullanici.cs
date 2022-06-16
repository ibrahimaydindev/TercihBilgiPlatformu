using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public class Kullanici
  {
    [Key]
    public int KullaniciID { get; set; }
    public string AdSoyad { get; set; }
    public bool Cinsiyet { get; set; }
    public DateTime? DogumTarihi { get; set; }
    public string OkulAdi { get; set; }
    public string BolumAdi { get; set; }
    public bool Mezun { get; set; }
    public string Resim { get; set; }
    public string EMail { get; set; }
    public string Telefon { get; set; }
    public string KullaniciAdi { get; set; }
    public string Sifre { get; set; }
    public bool Silindi { get; set; }
    public DateTime? KayitTarihi { get; set; }
    public List<Mesaj> Mesajs { get; set; }
    public List<Soru> Sorus { get; set; }
    public List<Cevap> Cevaps { get; set; }
    public List<Arkadas> Arkadas { get; set; }
    public List<Yetki> Yetkis { get; set; }
  }
}
