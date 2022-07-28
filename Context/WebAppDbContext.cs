using Asm.Models.BaseDB;
using Microsoft.EntityFrameworkCore;

namespace SIRP.Context
{
    public class WebAppDbContext : DbContext
    {

        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
        {
        }

        public DbSet<ContratadosModel>Contratados { get; set; }
        public DbSet<EmpresasModel> EmpresasModels { get; set; }
        public DbSet<VendasModel> VendasModel { get; set; }
        public DbSet<BauItens> BauItens { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContratadosModel>().ToTable("Contratados");
            modelBuilder.Entity<EmpresasModel>().ToTable("Empresas");
            modelBuilder.Entity<VendasModel>().ToTable("Vendas");
            modelBuilder.Entity<BauItens>().ToTable("Bau");

        }
    }
}