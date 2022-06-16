using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
  public class Context : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("server=LAPTOP-29QULOVF;database=TercihBilgiPlatformuDB;integrated security=true;");
    }

    public DbSet<Arkadas> Arkadas { get; set; }
    public DbSet<Bolum> Bolums { get; set; }
    public DbSet<Cevap> Cevaps { get; set; }
    public DbSet<Etiket> Etikets { get; set; }
    public DbSet<Kullanici> Kullanicis { get; set; }
    public DbSet<Lise> Lises { get; set; }
    public DbSet<Mesaj> Mesajs { get; set; }
    public DbSet<Sayfa> Sayfas { get; set; }
    public DbSet<Soru> Sorus { get; set; }
    public DbSet<Universite> Universites { get; set; }
    public DbSet<Yetki> Yetkis { get; set; }
  }
}
