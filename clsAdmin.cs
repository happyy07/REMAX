using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFinal
{
    class clsAdmin
    {
        private string vName;
        private string vAdminNumber;
        private string vPin;
        private string vPhoneNo;
        private clsListAgent vAgents;
       

        public clsAdmin()
        {
            vName = vAdminNumber = vPin = vPhoneNo = "not defined";            
            vAgents = new clsListAgent();           
        }

        public clsAdmin(string adminNumber, string pin, string phone, clsListAgent agents, string name)
        {
            vAdminNumber = adminNumber;
            vPin = pin;
            vPhoneNo = phone;
            vName = name;
            vAgents = agents;           
        }

        public clsAdmin(string adminNumber, string pin, string name, string phone)
        {
            vAdminNumber = adminNumber;
            vPin = pin;
            vName = name;
            vPhoneNo = phone;
            vAgents = new clsListAgent();
        }

        public string AdminNumber
        {
            get => vAdminNumber;
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

        public clsListAgent Agents
        {
            get => vAgents;
            set
            {
                vAgents = value;
            }
        }

        public string Name
        {
            get => vName;
            set
            {
                vName = value;
            }
        }

        public string display()
        {
            string info = "\nAdminNumber: " + vAdminNumber + "\nName: " + vName + "\nPin: " + vPin
                  + "\nPhoneNo: " + vPhoneNo + "\nAgents -- :\n" + vAgents.display();
            return info;
        }
    }
}
