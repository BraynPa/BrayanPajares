using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793T1.Models.Maps
{
    public class CuentaMap : IEntityTypeConfiguration<CuentaP>
    {
        public void Configure(EntityTypeBuilder<CuentaP> builder)
        {
            builder.ToTable("FPersona");
            builder.HasKey(o => o.id);
        }

    }

}
