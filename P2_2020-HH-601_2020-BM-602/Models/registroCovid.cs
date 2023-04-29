using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using P2_2020_HH_601_2020_BM_602.Models;


namespace P2_2020_HH_601_2020_BM_602.Models
{
    public class registroCovid : DbContext
    {
        public registroCovid(DbContextOptions<registroCovid> options): base(options)
        {

        }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<CasoReportado> CasoReportado { get; set; }
    }
}
