﻿using System;
using System.Collections.Generic;
using System.Text;
using WebMyPham.Data.Enums;

namespace WebMyPham.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid UserID { get; set; }
        public string ShipName { get; set; }
        public string ShipEmail { get; set; }
        public string ShipAddress { get; set; }
        public string ShipPhoneNumber { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        public AppUser AppUser { get; set; }
    }
}
