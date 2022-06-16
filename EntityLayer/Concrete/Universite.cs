using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public class Universite
  {
    [Key]
    public int UniversiteID { get; set; }
    public string Ad { get; set; }
    public bool Silindi { get; set; }
    public DateTime? KayitTarihi { get; set; }
    public List<Bolum> Bolums { get; set; }
  }
}
