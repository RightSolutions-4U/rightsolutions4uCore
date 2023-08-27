using System;
using System.Collections.Generic;

namespace rightsolutions4u.common.Models;

public partial class Contactus
{
    public int Id { get; set; }

    public string? Fullname { get; set; }

    public string? Email { get; set; }

    public string? Phoneno { get; set; }

    public string? Message { get; set; }

    public bool? Replied { get; set; }

    public DateTime? Endate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
