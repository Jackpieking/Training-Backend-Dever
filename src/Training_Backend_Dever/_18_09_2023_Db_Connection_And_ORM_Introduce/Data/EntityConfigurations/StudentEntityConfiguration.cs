using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.Entities;
using Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.EntityConfigurations.Generic;

namespace Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.EntityConfigurations;

public class StudentEntityConfiguration :
GenericEntityConfiguration<StudentEntity>,
IEntityTypeConfiguration<StudentEntity>
{
    public new void Configure(EntityTypeBuilder<StudentEntity> builder)
    {
        const string TableName = "Students";
        const string GenerateNewIdSqlFunction = "NEWID()";
        const string Nvarchar_40 = "NVARCHAR(40)";

        builder.ToTable(name: TableName);

        builder.HasKey(keyExpression: student => student.Id);

        builder
            .Property(propertyExpression: student => student.Id)
            .HasDefaultValueSql(sql: GenerateNewIdSqlFunction);

        builder
            .Property(propertyExpression: student => student.Name)
            .HasColumnType(typeName: Nvarchar_40)
            .HasDefaultValue(value: string.Empty)
            .IsRequired();
    }
}