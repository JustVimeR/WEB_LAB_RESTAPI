using System;
using System.Collections.Generic;

namespace WEB_LAB21.Models;

public partial class Order
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime OrderDate { get; set; }

    public int TotalAmount { get; set; }
}
