using System;

namespace Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.Entities;

public sealed class StudentEntity
{
    public Guid Id { get; set; }

    public string StudentName { get; set; }

    public Guid ClassroomId { get; set; }

    public ClassRoomEntity ClassRoomEntity { get; set; }
}