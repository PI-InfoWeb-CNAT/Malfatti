﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aula.Cart;
using Modelo.Cart;

namespace malfatti.Models.ViewModels
{
    public class OrderVM
    {
        public OrderVM()
        {
        }

        public OrderVM(Order row)
        {
            OrderId = row.OrderId;
            UserId = row.UserId;
            CreatedAt = row.CreatedAt;
        }

        public long OrderId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}