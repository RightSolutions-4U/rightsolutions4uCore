using System;
using System.Collections.Generic;

namespace rightsolutions4u.common.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Latname { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Phoneno { get; set; }

    public DateTime? Endate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
