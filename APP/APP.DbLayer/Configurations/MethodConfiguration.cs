using APP.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.DbLayer.Configurations
{
    public class MethodConfiguration : IEntityTypeConfiguration<Method>
    {
        public void Configure(EntityTypeBuilder<Method> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.ParentClass);

            builder
                .HasMany(x => x.InvokesFromMethod)
                .WithMany(x => x.InvokesMethod)
                .UsingEntity(n => n.ToTable("MethodRelationship"));
        }
    }
}
