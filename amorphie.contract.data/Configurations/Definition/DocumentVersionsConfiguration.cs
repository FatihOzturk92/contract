using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using amorphie.contract.core.Entity.Definition;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace amorphie.contract.data.Configurations.Definition
{
    public class DocumentVersionsConfiguration : IEntityTypeConfiguration<DocumentVersions>
    {
        public void Configure(EntityTypeBuilder<DocumentVersions> builder)
        {
            // builder.HasKey(x => new { x.LanguageId,x.Id});
        }
    }
}