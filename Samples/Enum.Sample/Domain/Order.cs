﻿using System.ComponentModel.DataAnnotations;

namespace Enum.Sample.Domain;

public sealed record Order
{
    [Key]
    public int OrderId { get; set; }

    public DateTime Date { get; set; }

    public OrderStatus Status { get; set; } = OrderStatus.Pending;
}