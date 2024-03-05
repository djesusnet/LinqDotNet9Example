using System;
using System.Collections.Generic;

namespace LInqMethodsExample.Models.DB;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
