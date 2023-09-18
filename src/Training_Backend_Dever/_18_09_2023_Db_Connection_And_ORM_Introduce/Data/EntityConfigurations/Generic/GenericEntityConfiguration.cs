using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.Entities.Generic.Contracts;

namespace Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.EntityConfigurations.Generic;

public abstract class GenericEntityConfiguration<TSource> : IEntityTypeConfiguration<TSource> where TSource : class, IGenericEntity
{
    public void Configure(EntityTypeBuilder<TSource> builder)
    {

    }
}