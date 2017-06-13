using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcuCafe.Models
{
    public class Orders
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public Drinks Drinks { get; set; }

        public int? DrinksId { get; set; }

        public Options Options { get; set; }

        public int? OptionsId { get; set; }
    }
}