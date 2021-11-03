using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configurations
{
    public class ContextBase : DbContext
    {

        // Cria as tabelas automaticamente ao rodar um comando
        public ContextBase(DbContextOptions<ContextBase> options) : base(options) => Database.EnsureCreated();
        

        // DbSet tabela produto
        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            if (!OptionsBuilder.IsConfigured)
                OptionsBuilder.UseSqlServer(GetConnectionStringsConfig());
            base.OnConfiguring(OptionsBuilder);
        }

        // Ainda precisa ser implementado connection strings 
        private string GetConnectionStringsConfig() => "Data Source=WLEBRSAO3-01322\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Connect Timeout=30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";





    }
}
