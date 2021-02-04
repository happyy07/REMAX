using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFinal
{
    class clsListClient
    {
        // declaration of private or hidden dictionary to store the goup of clients
        private Dictionary<string, clsClient> myList;

        public clsListClient()
        {
            myList = new Dictionary<string, clsClient>();
        }

        public Dictionary<string, clsClient>.ValueCollection Elements
        {
            get => myList.Values;
        }

        public int Quantity
        {
            get => myList.Count;
        }

        public bool Add(clsClient client)
        {
            if (Exist(client.ClientNumber) == false)
            {
                myList.Add(client.ClientNumber, client);
                return true;
            }
            else { return false; }
        }

        public bool Delete(string clientNumber)
        {
            return myList.Remove(clientNumber);
        }

        public string Display()
        {
            string info = "\n --- Clients --- \n";
            foreach (clsClient itm in myList.Values)
            {
                info += itm.Display() + "\n";
            }
            return info;
        }

        public bool Exist(string clientNumber)
        {
            return myList.ContainsKey(clientNumber);
        }

        public clsClient Find(string clientNumber)
        {
            if (Exist(clientNumber) == true)
            {
                return myList[clientNumber];
            }
            else { return null; }

        }
    }
}
