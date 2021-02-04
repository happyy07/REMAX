using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFinal
{
    class clsHouse
    {
        private string vHouseNumber;
        private string vLocation;
        private decimal vPrice;
        private string vClientId;
        private string vAgentPhoneNo;

        public clsHouse()
        {
            vHouseNumber = vLocation = vClientId = vAgentPhoneNo = "not defined";
            vPrice = -1;
        }

        public clsHouse(string number, string location, decimal price, string clientId, string agentPhone)
        {
            vHouseNumber = number;
            vLocation = location;
            vPrice = price;
            vClientId = clientId;
            vAgentPhoneNo = agentPhone;
        }

        public string HouseNumber
        {
            get => vHouseNumber;
            set
            {
                vHouseNumber = value;
            }
        }

        public string Location
        {
            get => vLocation;
            set
            {
                vLocation = value;
            }
        }

        public decimal Price
        {
            get => vPrice;
            set
            {
                vPrice = value;
            }
        }

        public string ClientId
        {
            get => vClientId;
            set
            {
                vClientId = value;
            }
        }

        public string AgentPhoneNo
        {
            get => vAgentPhoneNo;
            set
            {
                vAgentPhoneNo = value;
            }
        }

        public void Register(string houseNumber, string location, decimal price)
        {
            vHouseNumber = houseNumber;
            vLocation = location;
            vPrice = price;
        }

        public string Display()
        {
            string info = "\nHouseNumber: " + vHouseNumber + "\nLocation: " + vLocation + "\nPrice: " + vPrice
                + "\nClientId: " + vClientId + "\nAgentPhoneNo: " + vAgentPhoneNo;
            return info;
        }
    }
}
