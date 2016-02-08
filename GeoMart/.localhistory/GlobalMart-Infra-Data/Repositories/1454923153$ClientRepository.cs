using GlobalMart_Domain.Entities;
using GlobalMart_Domain.Interface;
using System.Collections.Generic;
using System.Linq;

namespace GlobalMart_Infra_Data.Repositories
{
    public class ClientRepository  : RespositoryBase<Client>, IClientRepository
    {
        public IEnumerable<Client> GetClientById(int Id)
        {
            return Db.Clients.Where(p => p.ClientId == Id);
        }
    }
}
