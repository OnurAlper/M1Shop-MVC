﻿using System;
using System.Collections.Generic;

namespace M1Shop.Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
