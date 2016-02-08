using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalMartWeb.VMModels
{
    public class ProductVM
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int ClientId { get; set; }
        //public Client Client { get; set; }
    }
}