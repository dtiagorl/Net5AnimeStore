using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5AnimeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Repository
{
    public class FigureMapping : IEntityTypeConfiguration<Figure>
    {
        public void Configure(EntityTypeBuilder<Figure> builder)
        {
            builder.ToTable("tbl_figure");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.ShortDescription).IsRequired().HasMaxLength(250);
            builder.Property(x => x.LongDescription).IsRequired().HasMaxLength(700);
            builder.Property(x => x.ImageUrl).IsRequired();
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
