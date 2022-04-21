using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_controller
{
    /// <summary>
    /// Client parent
    /// </summary>
    internal class Group
    {
        private List<Client> clients;
        public List<Client> Clients
        {
            get { return clients; }
        }

        public Group()
        {
            clients = new List<Client>();
        }

        public bool AddClient(Client client)
        {
            foreach (Client c in clients)
            {
                if (c.Handle == client.Handle) return false;
            }
            clients.Add(client);
            return true;
        }

        public bool RemoveClient(IntPtr handle)
        {
            foreach (Client client in clients)
            {
                if (client.Handle == handle)
                {
                    client.Overlay.Close();
                    clients.Remove(client);
                    return true;
                }
            }
            return false;
        }

        public Client GetClient(IntPtr handle)
        {
            foreach (Client client in clients)
            {
                if (client.Handle == handle)
                {
                    return client;
                }
            }

            return null;
        }

        public List<Client> GetClientsByControlSet(ControlSet set)
        {
            List<Client> clients = new List<Client>();
            foreach (Client client in clients)
            {
                if (client.ControlSet == set)
                {
                    clients.Add(client);
                }
            }

            return clients;
        }
    }
}
