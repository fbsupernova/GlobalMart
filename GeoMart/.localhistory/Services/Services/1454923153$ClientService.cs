using GlobalMart_Domain.Entities;
using GlobalMart_Infra_Data.Repositories;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ClientService : IClientService
    {
        private readonly ClientRepository _clientRepository;
        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }

        public IEnumerable<Client> GetClients()
        {
            var repoStudies = _clientRepository.GetAll();
            return repoStudies;
        }

        public Client GetClientById(int id)
        {
            var repoStudies = _clientRepository.GetbyId(id);
            return repoStudies;
        }


        public void Add(Client clientObj)
        {
            _clientRepository.Add(clientObj);           
        }

    }
}
