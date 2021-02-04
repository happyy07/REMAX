using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFinal
{
    class clsAgent
    {
        private string vName;
        private string vAgentNumber;
        private string vPin;
        private string vPhoneNo;
        private string vStatus;
        private clsListClient vClients;

        public clsAgent(string name, string agentNumber, string pin, string phone, string status, clsListClient clients)
        {
            vName = name;
            vAgentNumber = agentNumber;
            vPin = pin;
            vPhoneNo = phone;
            vStatus = status;          
            vClients = clients;
        }

        public clsAgent(string name, string agentNumber, string pin, string phone, string status)
        {
            vName = name;
            vAgentNumber = agentNumber;
            vPin = pin;
            vPhoneNo = phone;
            vStatus = status;
            vClients = new clsListClient();
        }

        public clsAgent()
        {
            vName = vAgentNumber = vPin = vPhoneNo = vStatus = "not defined";
            vClients = new clsListClient();
        }

        public string Name
        {
            get => vName;
            set
            {
                vName = value;
            }
        }

        public string AgentNumber
        {
            get => vAgentNumber;
        }

        public string Pin
        {
            get => vPin;
            set
            {
                vPin = value;
            }
        }

        public string PhoneNo
        {
            get => vPhoneNo;
            set
            {
                vPhoneNo = value;
            }
        }

        public string Status
        {
            get => vStatus;
            set
            {
                vStatus = value;
            }
        }

        public clsListClient Clients
        {
            get => vClients;
            set
            {
                vClients = value;
            }
        }

        public void Register(string name, string agentNumber, string pin, string phone)
        {
            vAgentNumber = agentNumber;
            Name = name;
            Pin = pin;
            PhoneNo = phone;
            vStatus = "active";
        }

        public string Display()
        {
            string info = "\nAgentNumber: " + vAgentNumber + "\nName: " + vName + "\nPin: " + vPin
                 + "\nPhoneNo: " + vPhoneNo + "\nStatus: " + vStatus + "\nClients --:" + vClients.Display();
            return info;
        }
    }
}
