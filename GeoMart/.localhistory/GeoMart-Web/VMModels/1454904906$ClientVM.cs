using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalMartWeb.VMModels
{
    public class ClientVM
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}