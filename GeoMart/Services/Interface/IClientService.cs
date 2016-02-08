using GlobalMart_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
   public interface IClientService
    {
         IEnumerable<Client> GetClients();
        void Add(Client clientObj);
        Client GetClientById(int Id);
    }
}
