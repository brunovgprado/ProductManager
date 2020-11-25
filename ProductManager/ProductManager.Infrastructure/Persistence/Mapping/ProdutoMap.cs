using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager.Infrastructure.Persistence.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(p => p.Id).HasColumnName("ID_PRODUTO");
            builder.Property(p => p.Nome).HasColumnName("NOME_PRODUTO");
            builder.Property(p => p.Valor).HasColumnName("VALOR_PRODUTO");
            builder.Property(p => p.imagemUri).HasColumnName("IMAGEMURI_PRODUTO");
        }
    }
}
