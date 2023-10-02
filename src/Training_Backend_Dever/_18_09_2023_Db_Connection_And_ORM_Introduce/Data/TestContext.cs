using Microsoft.EntityFrameworkCore;
using Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.Entities;

namespace Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data;

public sealed class TestContext : DbContext
{
    //Tuong tac voi table (QUERY)
    public DbSet<StudentEntity> StudentEntities { get; set; }

    public DbSet<ClassRoomEntity> ClassRoomEntities { get; set; }

    //Cau hinh database
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(connectionString: "Server=localhost;Database=TestDb1;Integrated Security=True;Encrypt=False")
            .EnableDetailedErrors(true)
            .EnableSensitiveDataLogging(true);
    }

    //Cau hinh tung table
    //table === entity
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //IsRequired: not null
        //HasColumnType: Change col data type
        //HasDefaultValueSql: Default in sql
        //ToTable: change table name
        //HasKey: primary key

        modelBuilder
            .Entity<StudentEntity>(buildAction: builder =>
            {
                builder.ToTable("Student");

                //Primary key.
                builder.HasKey(keyExpression: student => student.Id);

                //Id property configuration.
                builder
                    .Property(propertyExpression: student => student.Id)
                    .HasDefaultValueSql(sql: "NEWID()");

                //Name property configuration.
                builder
                    .Property(propertyExpression: student => student.StudentName)
                    .HasColumnType("NVARCHAR(50)")
                    .IsRequired();
            })
            .Entity<ClassRoomEntity>(builder =>
            {
                builder.ToTable("Classroom");

                //Primary key.
                builder.HasKey(keyExpression: classRoom => classRoom.Id);

                //Id property configuration.
                builder
                    .Property(propertyExpression: classRoom => classRoom.Id)
                    .HasDefaultValueSql(sql: "NEWID()");

                //ClassroomNumber property configuration.
                builder
                    .Property(propertyExpression: classRoom => classRoom.ClassroomNumber)
                    .HasColumnType(typeName: "VARCHAR(5)")
                    .IsRequired();

                //ClassRoom [1] - Students [N]
                builder
                    .HasMany(navigationExpression: classRoom => classRoom.StudentEntities)
                    .WithOne(navigationExpression: student => student.ClassRoomEntity)
                    .HasForeignKey(foreignKeyExpression: student => student.ClassroomId)
                    .HasPrincipalKey(keyExpression: classRoom => classRoom.Id)
                    .OnDelete(DeleteBehavior.Cascade);
            });
    }
}