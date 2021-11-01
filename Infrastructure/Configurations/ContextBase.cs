using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class ContextBase:DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            // Cria as tabelas automaticamente
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            if (!OptionsBuilder.IsConfigured)
                OptionsBuilder.UseSqlServer(GetConnectionStringsConfig());
            base.OnConfiguring(OptionsBuilder);
        }


        private string GetConnectionStringsConfig() => "";





    }
}
