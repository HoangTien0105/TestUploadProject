using System;
using System.Collections.Generic;

namespace Events.Data.Models;

public partial class Collaborator
{
    public int Id { get; set; }

    public string? IsCheckIn { get; set; }

    public int AccountId { get; set; }

    public int? EventId { get; set; }

    public int? Status { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Event? Event { get; set; }
}
