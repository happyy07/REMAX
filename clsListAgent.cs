using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFinal
{
    class clsListAgent
    {
        // declaration of private or hidden dictionary to store the goup of agents
        private Dictionary<string, clsAgent> myList;

        public clsListAgent()
        {
            myList = new Dictionary<string, clsAgent>();
        }

        public Dictionary<string, clsAgent>.ValueCollection Elements
        {
            get => myList.Values;
        }

        public int Quantity
        {
            get => myList.Count;
        }

        public bool Add(clsAgent agent)
        {
            if (Exist(agent.AgentNumber) == false)
            {
                myList.Add(agent.AgentNumber, agent);
                return true;
            }
            else { return false; }
        }

        public bool Delete(string agentNumber)
        {
            return myList.Remove(agentNumber);
        }

        public bool Exist(string agentNumber)
        {
            return myList.ContainsKey(agentNumber);
        }

        public string display()
        {
            string info = "\n --- Agents --- \n";
            foreach (clsAgent itm in myList.Values)
            {
                info += itm.Display() + "\n";
            }
            return info;
        }

        public clsAgent Find(string agentNumber)
        {
            if (Exist(agentNumber) == true)
            {
                return myList[agentNumber];
            }
            else { return null; }
        }

    }
}
