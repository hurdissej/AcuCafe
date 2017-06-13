using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcuCafe.Core.Folder
{
    public class OrderDTO
    {
        public List<int> DrinkIds { get; set; }
        public List<int> OptionIds { get; set; }
    }
}