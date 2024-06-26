﻿using System;
using System.Collections.Generic;

namespace Events.Data.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateOnly OrderDate { get; set; }

    public float TotalPrice { get; set; }

    public string? Notes { get; set; }

    public int PaymentMethod { get; set; }

    public int Status { get; set; }

    public int Email { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
