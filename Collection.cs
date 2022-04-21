using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_controller
{
    /// <summary>
    /// The parent of all control groups
    /// </summary>
    internal class Collection
    {
        private List<Group> groups;
        public List<Group> Groups
        {
            get { return groups; }
        }

        private bool allActive = false;
        public bool AllActive
        {
            get { return allActive; }
            set 
            { 
                allActive = value;
                ResetOverlays();
            }
        }

        private Group activeGroup;
        public Group ActiveGroup
        {
            get { return activeGroup; }
        }

        public Collection()
        {
            groups = new List<Group>();

            AddGroup();
            activeGroup = groups[0];
        }

        public void AddGroup()
        {
            groups.Add(new Group());
        }

        public void RemoveGroup()
        {
            if (groups.Count == 1) return;
            groups.RemoveAt(groups.Count - 1);
        }

        public List<Client> GetAllActiveClients()
        {
            if (!allActive) return activeGroup.Clients;

            List<Client> clients = new List<Client>();
            foreach (Group group in groups)
            {
                foreach (Client client in group.Clients)
                {
                    clients.Add(client);
                }
            }
            return clients;
        }

        public List<Client> GetAllActiveClients(ControlSet? controlSet)
        {
            List<Client> clients = new List<Client>();
            if (controlSet == null) return clients;
            if (!allActive)
            {
                foreach (Client client in activeGroup.Clients)
                {
                    if (client.ControlSet == controlSet) clients.Add(client);
                }
            }
            else
            {
                foreach (Group group in groups)
                {
                    foreach (Client client in group.Clients)
                    {
                        if (client.ControlSet == controlSet) clients.Add(client);
                    }
                }
            }
            return clients;
        }

        public List<Client> GetAllInactiveClients()
        {
            List<Client> clients = new List<Client>();
            if (allActive) return clients;

            foreach (Group group in groups)
            {
                if (group != activeGroup)
                {
                    foreach (Client client in group.Clients)
                    {
                        clients.Add(client);
                    }
                }
            }
            return clients;
        }

        public List<Client> GetAllClients()
        {
            List<Client> clients = new List<Client>();
            foreach (Group group in groups)
            {
                foreach (Client client in group.Clients)
                {
                    clients.Add(client);
                }
            }
            return clients;
        }

        public List<Client> GetAllClients(ControlSet controlSet)
        {
            List<Client> clients = new List<Client>();
            foreach (Group group in groups)
            {
                foreach (Client client in group.Clients)
                {
                    if (client.ControlSet == controlSet) clients.Add(client);
                }
            }
            return clients;
        }

        internal bool IsActive(IntPtr handle)
        {
            foreach (Client client in ActiveGroup.Clients)
            {
                if (client.Handle == handle)
                {
                    return true;
                }
            }
            return false;
        }

        public void SetActiveGroup(int num)
        {
            if (num > groups.Count || num <= 0) return;
            activeGroup = groups[num - 1];
            ResetOverlays();
        }

        public void ResetOverlays()
        {
            foreach (Client client in GetAllInactiveClients())
            {
                client.Overlay.Hide();
            }
            foreach (Client client in GetAllActiveClients())
            {
                client.Overlay.Show();
            }
        }
    }
}
