using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHotel.Models;
using TestHotel.Views;

namespace TestHotel.Services
{
    class ClientsService
    {
        public void AddClient(clients client)
        {
            using (HotelModel context = new HotelModel())
            {
                if (client != null)
                {
                    context.clients.Add(client);
                    context.SaveChanges();
                }
            }
        }

        public clients GetClient(int id)
        {
            using (HotelModel context = new HotelModel())
            {
                return context.clients.Find(id);
            }
        }

        public List<clients> GetAllClients()
        {
            using (HotelModel context = new HotelModel())
            {
                return context.clients.ToList();
            }
        }

        public void UpdateClient(clients client)
        {
            using (HotelModel context = new HotelModel())
            {
                clients clientToUpdate = context.clients.Find(client.IdentifiantCli);
                if (clientToUpdate != null)
                {
                    clientToUpdate.Nom = client.Nom;
                    clientToUpdate.Prenom = client.Prenom;
                    clientToUpdate.Telephone = client.Telephone;
                    clientToUpdate.Email = client.Email;
                    context.SaveChanges();
                }
            }
        }

        public void RemoveClient(int id)
        {
            using (HotelModel context = new HotelModel())
            {
                clients clientToRemove = context.clients.Find(id);
                if (clientToRemove != null)
                {
                    context.clients.Remove(clientToRemove);
                    context.SaveChanges();
                }
            }
        }
    }
}
