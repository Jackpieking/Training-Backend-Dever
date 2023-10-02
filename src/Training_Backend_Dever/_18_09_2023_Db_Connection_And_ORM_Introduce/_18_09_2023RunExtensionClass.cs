using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data;
using Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.Entities;

namespace Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce;

/*
    DATABASE: database là kho lưu trữ, lưu trữ có format, dễ truy vấn, dễ lấy
    C# [Language] -> Database

    Database:
        Human
        {
            ID: VARCHAR(length(guid)) (guid)
            Name: NVARCHAR(30)
        }

    C#
        humans.Select(human => human)

        - 1 list các human
        - SELECT * FROM Human

        Step to query db from code:

        -> Database first
        -> Code first [current]

        - Install package
        - Connect to db
        - Write a query
        - Send to db
        - get back result from db
        - Parse result and handle

        Microsoft.EntityFrameworkCore (ORM)

        - Table: class
        - DbContext -> la 1 database
        - OnModelCreating -> Config cac class -> config table
        - OnConfiguring -> Config ket noi den database va nhung thu khac lien quang ve database
        - DbSet<T>: Đại diện cho nguồn dữ liệu cua table T
        - EX: DbSet<Student> => Data của table student
        entity === Table

        Base ORM: dùng để phát triển các provider
        Provider: Các loại database
        Reasons
        {
            - Các database hoạt động khác nhau
            - Function [postgres != ms sqlserver]
        }
        - Migrations
            - Snapshot về cấu hình tất cả mọi thứ về database
                + Table
                + Relationship
                + Procedure
            - Snapshot từ code

        - Db update -> apply snapshot vào db
        - Data seeding: dữ liệu ban đầu của db
        - Scaffold: []

        M1: Init Db
        M2: Student id field datatype [string (varchar(20))  -> guid]
        M3: Add new field "age"

        =====================
        Microsoft.EntityFrameworkCore.SqlServer -> Ms sqlserver

        Microsoft.EntityFrameworkCore.InMemory

        Microsoft.EntityFrameworkCore.Sqlite -> SQLLITE

        Npgsql.EntityFrameworkCore.PostgreSQL -> Postgres ++++

        Pomelo.EntityFrameworkCore.MySql -> Mysql

        Microsoft.EntityFrameworkCore.Design ++++
*/

public static class _18_09_2023_Db_Connection_And_ORM_IntroduceRunExtensionMethod
{
    public static async Task ExecuteAsync()
    {
        await using TestContext context = new();

        ClassRoomEntity classRoomEntity = new()
        {
            ClassroomNumber = "SA111",
        };

        // await context.ClassRoomEntities.AddAsync(classRoomEntity);

        // await context.StudentEntities.AddAsync(entity: new()
        // {
        //     StudentName = "My name",
        //     ClassRoomEntity = classRoomEntity
        // });

        // await context.SaveChangesAsync();

        var foundStudent = await context.StudentEntities
            .AsNoTracking()
            .Where(predicate: student => student.StudentName.Equals("My name"))
            .Select(selector: student => new StudentEntity
            {
                StudentName = student.StudentName
            })
            .FirstOrDefaultAsync();

        System.Console.WriteLine(foundStudent.StudentName);
    }
}