using System;
using System.Collections.Generic;

namespace Events.Data.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public DateOnly TicketDate { get; set; }

    public byte Quantity { get; set; }

    public byte UsedTicket { get; set; }

    public int OrderId { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
