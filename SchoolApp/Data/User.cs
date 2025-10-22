using System;
using System.Collections.Generic;
using SchoolApp.core.enums;

namespace SchoolApp.Data;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public UserRole? UserRole { get; set; } = null!; //ToDo Create Enum for UserRole

    public virtual Student? Student { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
