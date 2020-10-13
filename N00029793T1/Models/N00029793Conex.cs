using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using N00029793T1.Models.Maps;



namespace N00029793T1.Models
{
    public class N00029793Conex: DbContext
    {
        //esto se repite por cada tabla de base de datos
        public DbSet<CuentaP> Cuentas { get; set; }


        public N00029793Conex(DbContextOptions<N00029793Conex> options)
                : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //esto se repite por cada tabla de base de datos
            ModelBuilder modelBuilder1 = modelBuilder.ApplyConfiguration(new CuentaMap());
        }
    }
}



