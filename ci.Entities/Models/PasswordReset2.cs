using System;
using System.Collections.Generic;

namespace ci.Entities.Models;

public partial class PasswordReset2
{
    public string Email { get; set; } = null!;

    public string Token { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
