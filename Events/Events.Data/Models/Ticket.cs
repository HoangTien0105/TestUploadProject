using System;
using System.Collections.Generic;

namespace Events.Data.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public int? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public int? Email { get; set; }

    public int EventId { get; set; }

    public double Price { get; set; }

    public string? IsCheckIn { get; set; }

    public int? OrderDetailsId { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual OrderDetail? OrderDetails { get; set; }
}
