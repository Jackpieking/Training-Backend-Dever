using System;
using Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.Entities.Generic.Contracts;

namespace Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce.Data.Entities.Generic.Implementation;

public abstract class GenericEntity : IGenericEntity
{
    private DateTime _createdAt;
    private DateTime _updatedAt;
    private string _creator;
    private string _remover;
    private bool _deleteFlag;

    public DateTime CreatedAt
    {
        get => _createdAt;
        set => _createdAt = value;
    }

    public DateTime UpdatedAt
    {
        get => _updatedAt;
        set => _updatedAt = value;
    }

    public string Creator
    {
        get => _creator;
        set => _creator = value;
    }

    public string Remover
    {
        get => _remover;
        set => _remover = value;
    }

    public bool DeleteFlag
    {
        get => _deleteFlag;
        set => _deleteFlag = value;
    }
}