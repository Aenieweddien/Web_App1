using Web_App1.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Web_App1.Models.ViewModels.Shop
{
    public class OrderVM
    {
        public OrderVM()
        {
        }
        public OrderVM(OrderDTO row)
        {
            OrderId = row.OrderId;
            UserId = row.UserId;
            Cratedat = row.Createdat;
            Status = row.Status;
        }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime Cratedat { get; set; }
        public string Status { get; set; }
    }
}