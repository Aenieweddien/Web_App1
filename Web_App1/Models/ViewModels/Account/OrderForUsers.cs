﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_App1.Models.ViewModels.Account
{
    public class OrdersForUsersVM
    {
        public int OrderNumber { get; set; }
        public decimal Total { get; set; }
        public Dictionary<string, int> ProductsAndQty { get; set; }
        public DateTime Cratedat { get; set; }
        public String Status { get; set; }
    }
}