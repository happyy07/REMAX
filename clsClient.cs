using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFinal
{
    class clsClient
    {
        private string vName;
        private string vPin;
        private string vClientNumber;
        private string vPhoneNo;
        private string vStatus;
        private string vType;
        private clsListHouse vHouses;

        public clsClient(string name, string clientNumber, string pin, string phone, string status, string type, clsListHouse houses)
        {
            vName = name;
            vClientNumber = clientNumber;
            vPin = pin;
            vPhoneNo = phone;
            vStatus = status;
            vType = type;
            vHouses = houses;
        }

        public clsClient(string name, string clientNumber, string pin, string phone, string status, string type)
        {
            vName = name;
            vClientNumber = clientNumber;
            vPin = pin;
            vPhoneNo = phone;
            vStatus = status;
            vType = type;
            vHouses = new clsListHouse();
        }

        public clsClient()
        {
            vName = vClientNumber = vPin = vPhoneNo = vStatus = vType = "not defined";
            vHouses = new clsListHouse();
        }

        public string Name
        {
            get => vName;
            set
            {
                vName = value;
            }
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

        public string ClientNumber
        {
            get => vClientNumber;
        }

        public string Status
        {
            get => vStatus;
            set
            {
                vStatus = value;
            }
        }

        public string Type
        {
            get => vType;
            set
            {
                vType = value;
            }
        }

        public string Display()
        {
            string info = "\nClientNumber: " + vClientNumber + "\nName: " + vName + "\nPin: " + vPin
                + "\nPhoneNo: " + vPhoneNo + "\nStatus: " + vStatus + "\nType: " + vType;
            return info;
        }

        public void Register(string name, string clientNumber, string pin, string phone)
        {
            vClientNumber = clientNumber;
            Name = name;
            Pin = pin;
            PhoneNo = phone;
            vStatus = "active";
        }
    }
}
