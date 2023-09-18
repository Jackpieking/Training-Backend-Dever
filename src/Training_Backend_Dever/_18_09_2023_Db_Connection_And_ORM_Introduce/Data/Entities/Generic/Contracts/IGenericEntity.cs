using System;

namespace Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.Entities.Generic.Contracts;

public interface IGenericEntity
{
    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string Creator { get; set; }

    public string Remover { get; set; }

    public bool DeleteFlag { get; set; }
}