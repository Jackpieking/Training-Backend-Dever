using System;
using Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.Entities.Generic.Implementation;

namespace Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.Entities;

public sealed class StudentEntity : GenericEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; }
}