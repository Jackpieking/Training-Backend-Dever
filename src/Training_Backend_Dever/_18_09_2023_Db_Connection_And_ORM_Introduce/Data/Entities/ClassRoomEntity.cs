using System;
using System.Collections.Generic;

namespace Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.Entities;

public class ClassRoomEntity
{
    public Guid Id { get; set; }

    public string ClassroomNumber { get; set; }

    public IList<StudentEntity> StudentEntities { get; set; }
}