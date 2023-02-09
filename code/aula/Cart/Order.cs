using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aula.Cart
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}