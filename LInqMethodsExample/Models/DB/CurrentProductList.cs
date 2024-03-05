using System;
using System.Collections.Generic;

namespace LInqMethodsExample.Models.DB;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
